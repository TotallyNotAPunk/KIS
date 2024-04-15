using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Interfece
{
    public partial class Form3 : Form
    {
        public Form3(User user)
        {
            InitializeComponent();
        }
        List<Game> FindedGames = new List<Game>();
        int GameMarker = 0;

        void FromTableToListGame(DataTable table)
        {
            List<Game> a = new List<Game>();
            DataRow[] rows = table.Select();
            for (int i = 0; i < rows.Length; i++)
            {
                Game game = new Game(
                    Convert.ToString(rows[i]["game_id"]),
                    Convert.ToString(rows[i]["titel"]), Convert.ToString(rows[i]["description"]),
                    Convert.ToString(rows[i]["release_year"]), Convert.ToString(rows[i]["cost"]),
                    Convert.ToString(rows[i]["reviews"]), Convert.ToString(rows[i]["developer_name"]),
                    Convert.ToString(rows[i]["publisher_name"]), Convert.ToString(rows[i]["web_store"]));
                a.Add(game);
            }
            GameMarker = 0;
            FindedGames = a;
        }


        void UpdateGameInterfece()
        {
            if (FindedGames.Count <= 0)
            {
                labelWebStoreProduct.Text = "---";
                labelTitelProduct.Text = "---";
                labelDescriptionProduct.Text = "---";
                labelCostProduct.Text = "---";
                labelReviewsProduct.Text = "---";
                labelDeveloperProduct.Text = "---";
                labelPublisherProduct.Text = "---";
                labelReleaseYearProduct.Text = "---";
                labelGameList.Text = "0/0";
            }
            else
            {
                labelWebStoreProduct.Text = FindedGames[GameMarker].Web_Store;
                labelTitelProduct.Text = FindedGames[GameMarker].Titel;
                labelDescriptionProduct.Text = FindedGames[GameMarker].Description;
                labelCostProduct.Text = FindedGames[GameMarker].Cost;
                labelReviewsProduct.Text = FindedGames[GameMarker].Reviews;
                labelDeveloperProduct.Text = FindedGames[GameMarker].Developer_Name;
                labelPublisherProduct.Text = FindedGames[GameMarker].Publisher_Name;
                labelReleaseYearProduct.Text = FindedGames[GameMarker].Release_Year;
                labelGameList.Text = Convert.ToString(GameMarker + 1) + "/" + Convert.ToString(FindedGames.Count);
            }
        }


        private void FindButton_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;
            if (radioButtonTitel.Checked)
            {
                command = new MySqlCommand("SELECT * FROM `game_summary` WHERE `titel` = @Titel", db.getConnection());
                command.Parameters.Add("@Titel", MySqlDbType.VarChar).Value = search;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (!(table.Rows.Count > 0))
                {
                    MessageBox.Show("По вашему запросу ничего не найдено");
                    FindedGames = new List<Game>();
                    UpdateGameInterfece();
                }
                else
                {
                    FromTableToListGame(table);
                    UpdateGameInterfece();

                }
            }
            else if (radioButtonDeveloper.Checked)
            {
                command = new MySqlCommand("SELECT * FROM `game_summary` WHERE `developer_name` = @Developer;", db.getConnection());
                command.Parameters.Add("@Developer", MySqlDbType.VarChar).Value = search;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (!(table.Rows.Count > 0))
                {
                    MessageBox.Show("По вашему запросу ничего не найдено");
                    FindedGames = new List<Game>();
                    UpdateGameInterfece();
                }
                else
                {
                    FromTableToListGame(table);
                    UpdateGameInterfece();
                }
            }
            else if (radioButtonPublisher.Checked)
            {
                command = new MySqlCommand("SELECT * FROM `game_summary` WHERE `publisher_name` = @Publisher;", db.getConnection());
                command.Parameters.Add("@Publisher", MySqlDbType.VarChar).Value = search;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (!(table.Rows.Count > 0))
                {
                    MessageBox.Show("По вашему запросу ничего не найдено");
                    FindedGames = new List<Game>();
                    UpdateGameInterfece();
                }
                else
                {
                    FromTableToListGame(table);
                    UpdateGameInterfece();
                }
            }
            else if (radioButtonWebStore.Checked)
            {
                command = new MySqlCommand("SELECT * FROM `game_summary` WHERE `web_store` = @Web_Store;", db.getConnection());
                command.Parameters.Add("@Web_Store", MySqlDbType.VarChar).Value = search;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (!(table.Rows.Count > 0))
                {
                    MessageBox.Show("По вашему запросу ничего не найдено");
                    FindedGames = new List<Game>();
                    UpdateGameInterfece();
                }
                else
                {
                    FromTableToListGame(table);
                    UpdateGameInterfece();
                }
            }
            else if (radioButtonCost.Checked)
            {
                try { Convert.ToInt32(search); }
                catch
                {
                    MessageBox.Show("Цена должна быть числом");
                    return;
                }
                command = new MySqlCommand("SELECT * FROM `game_summary` WHERE `cost` < @Cost;", db.getConnection());
                command.Parameters.Add("@Cost", MySqlDbType.Int32).Value = search;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (!(table.Rows.Count > 0))
                {
                    MessageBox.Show("По вашему запросу ничего не найдено");
                    FindedGames = new List<Game>();
                    UpdateGameInterfece();
                }
                else
                {
                    FromTableToListGame(table);
                    UpdateGameInterfece();
                }
            }
            else
            {
                MessageBox.Show("Параметры поcика не выбраны!");

            }
        }

        private void buttonNextGame_Click(object sender, EventArgs e)
        {
            if (GameMarker + 1 >= FindedGames.Count) { }
            else
            {
                GameMarker = GameMarker + 1;
                UpdateGameInterfece();
            }
        }

        private void buttonPrevGame_Click(object sender, EventArgs e)
        {
            if (GameMarker <= 0) { }
            else
            {
                GameMarker = GameMarker - 1;
                UpdateGameInterfece();
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            int game_id = Convert.ToInt32(FindedGames[GameMarker].Game_Id);
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `kyrsovaya_kis`.`game` WHERE `game_id` = @Game_ID", db.getConnection());
            command.Parameters.Add("@Game_ID", MySqlDbType.Int32).Value = game_id;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            { MessageBox.Show("Игра успешно удалена "); }
            else
            { MessageBox.Show("Упс! При удалении возникла ошибка"); }
            db.closeConnection();
            FindButton_Click(sender, e);
            
        }

        private List<Developer> getDevelopers() 
        {
            List<Developer> developers = new List<Developer>();
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;

            command = new MySqlCommand("SELECT * FROM `developer`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            DataRow[] rows = table.Select();
            for (int i = 0; i < rows.Length; i++)
            {
                Developer p = new Developer(Convert.ToInt32(rows[i]["developer_id"]), Convert.ToString(rows[i]["developer_name"]));
                developers.Add(p);
            }
            return developers;
        }

        private List<Publisher> getPublishers()
        {
            List<Publisher> publishers = new List<Publisher>();
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;

            command = new MySqlCommand("SELECT * FROM `publisher`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            DataRow[] rows = table.Select();
            for (int i = 0; i < rows.Length; i++)
            {
                Publisher p = new Publisher(Convert.ToInt32(rows[i]["publisher_id"]), Convert.ToString(rows[i]["publisher_name"]));
                publishers.Add(p);
            }
            return publishers;
        }

       private void createDeveloper() 
        {
            string developer_name = textBoxDeveloperName.Text;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `kyrsovaya_kis`.`developer` (`developer_name`) VALUES (@Developer_Name);", db.getConnection());
            command.Parameters.Add("@Developer_Name", MySqlDbType.String).Value = developer_name;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            { MessageBox.Show("Разработчик успешно добавленн"); }
            else
            { MessageBox.Show("Упс! При добавлении Разработчика возникла ошибка"); }
            db.closeConnection();
        }

        private void createPublisher()
        {
            string publisher_name = textBoxPublisherName.Text;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `kyrsovaya_kis`.`publisher` (`publisher_name`) VALUES (@Publisher_Name);", db.getConnection());
            command.Parameters.Add("@Publisher_Name", MySqlDbType.String).Value = publisher_name;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            { MessageBox.Show("Издатель успешно добавленн"); }
            else
            { MessageBox.Show("Упс! При добавлении Издателя возникла ошибка"); }
            db.closeConnection();
        }


        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            List<Developer> developers = getDevelopers();
            List<Publisher> publishers = getPublishers();
            Developer curent_developer = null;
            Publisher curent_publisher = null;
            int web_store_id=0;

            string web_store = textBoxWebStore.Text;
            string titel = textBoxTitel.Text;
            string description = textBoxDescription.Text;
            string cost = textBoxCost.Text;
            string reviews = comboBox1.Text;
            string developer_name = textBoxDeveloperName.Text;
            string publisher_name = textBoxPublisherName.Text;
            string release_year = textBoxReleaseYear.Text;

            // Проверки полей.
            if (web_store == "")
            {
                MessageBox.Show("Не введено название магазаина");
                return;
            }
            else if (web_store == "Steam") { web_store_id = 1; }
            else if (web_store == "Epic Games") { web_store_id = 2; }
            else 
            {
                MessageBox.Show("Такого магазина не существует, проверьде корректность введенных данных.") ;
                return;
            }

            if (titel == "")
            { 
                MessageBox.Show("Не введено название игры");
                return;
            }
            if(description == "")
            { 
                MessageBox.Show("Не введено название описание игры");
                return;
            }
            if(cost == "")
            { 
                MessageBox.Show("Не введена стоимость игры");
                return;
            }
            if(reviews == "")
            {
                MessageBox.Show("Не введены отзывы");
                return;
            }
            if (developer_name == "")
            { 
                MessageBox.Show("Не введено название разработчика");
                return;
            }
            if(publisher_name == "")
            { 
                MessageBox.Show("Не введено название издателя");
                return;
            }
            if(release_year == "")
            { 
                MessageBox.Show("Не введен год выхода игры");
                return;
            }
            try 
            { int new_cost = Convert.ToInt32(cost); }
            catch 
            { 
                MessageBox.Show("Цена должна быть числом"); 
                return;
            }
            try
            { int new_release_year = Convert.ToInt32(release_year);
            }
            catch
            { 
                MessageBox.Show("Год выхода должен быть числом");
                return;
            }


            for (int i = 0; i < developers.Count; i++)
            { 
                if (developers[i].Developer_Name == developer_name) 
                { 
                    curent_developer = developers[i];
                }
            }
            if (curent_developer == null) 
            {
                createDeveloper();
                developers = getDevelopers();
                for (int i = 0; i < developers.Count; i++)
                {
                    if (developers[i].Developer_Name == developer_name)
                    {
                        curent_developer = developers[i];
                    }
                }
            }

            for (int i = 0; i < publishers.Count; i++)
            {
                if (publishers[i].Publisher_Name == publisher_name)
                {
                    curent_publisher = publishers[i];
                }
            }
            if (curent_publisher == null)
            {
                createPublisher();
                publishers = getPublishers();
                for (int i = 0; i < publishers.Count; i++)
                {
                    if (publishers[i].Publisher_Name == publisher_name)
                    {
                        curent_publisher = publishers[i];
                    }
                }
            }

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `kyrsovaya_kis`.`game` (`titel`, `description`, `release_year`, `cost`, `reviews`, `inventory_inventory_id`, `publisher_publisher_id`, `developer_developer_id`) VALUES (@Titel, @Description, @Release_Year, @Cost, @Reviews, @Inventory_Inventory_Id, @Publisher_Publisher_Id, @Developer_Developer_Id);", db.getConnection());
            command.Parameters.Add("@Titel", MySqlDbType.VarChar).Value = titel;
            command.Parameters.Add("@Description", MySqlDbType.Text).Value = description;
            command.Parameters.Add("@Release_Year", MySqlDbType.Year).Value = release_year;
            command.Parameters.Add("@Cost", MySqlDbType.Int32).Value = cost;
            command.Parameters.Add("@Reviews", MySqlDbType.Enum).Value = reviews;
            command.Parameters.Add("@Inventory_Inventory_Id", MySqlDbType.Int32).Value = web_store_id;
            command.Parameters.Add("@Publisher_Publisher_Id", MySqlDbType.Int32).Value = curent_publisher.Publisher_Id;
            command.Parameters.Add("@Developer_Developer_Id", MySqlDbType.Int32).Value = curent_developer.Developer_Id;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            { MessageBox.Show("Продукт успешно добавленн"); }
            else
            { MessageBox.Show("Упс! При добавлении Продукта возникла ошибка"); }
            db.closeConnection();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
