using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL_Interfece
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getShoppingCartSummary();
        }
        List<Game> FindedGames = new List<Game>();
        List<Product> ShoppingCart = new List<Product>();
        int GameMarker = 0;
        int ProductMarker = 0;
        

        void UpdateProductInterfece()
        {
            if (ShoppingCart.Count <= 0) 
            {
                labelWebStoreProduct.Text = "---";
                labelTitelProduct.Text = "---";
                labelCostProduct.Text = "---";
                labelAllProductCost.Text = "---";
                labelProductList.Text = "0/0";
            }
            else
            {
                labelWebStoreProduct.Text = ShoppingCart[ProductMarker].Web_Store;
                labelTitelProduct.Text = ShoppingCart[ProductMarker].Titel;
                labelCostProduct.Text = ShoppingCart[ProductMarker].Cost;
                labelAllProductCost.Text = ShoppingCart[ProductMarker].Bill_Sum;
                labelProductList.Text = Convert.ToString(ProductMarker + 1) + "/" + Convert.ToString(ShoppingCart.Count);
            }
        }

        void getShoppingCartSummary() 
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;
            command = new MySqlCommand("SELECT * FROM `shopping_cart_summary`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (!(table.Rows.Count > 0)) 
            {
                ShoppingCart = new List<Product>();
                UpdateProductInterfece();
            }
            else
            {
                FromTableToListProduct(table);
                UpdateProductInterfece();
            }
            
        }

        void FromTableToListProduct(DataTable table)
        {
            List<Product> a = new List<Product>();
            DataRow[] rows = table.Select();
            for (int i = 0; i < rows.Length; i++)
            {
                Product p = new Product(
                    Convert.ToInt32(rows[i]["product_id"]), Convert.ToString(rows[i]["store_name"]),
                    Convert.ToString(rows[i]["game_title"]), Convert.ToString(rows[i]["cost"]),
                    Convert.ToString(rows[i]["bill_sum"]));

                a.Add(p);
            }
            ProductMarker = 0;
            ShoppingCart = a;
        }

        void FromTableToListGame(DataTable table) 
        {
            List<Game> a = new List<Game>();
            DataRow[] rows = table.Select();
            for (int i = 0; i < rows.Length; i++) {
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
                labelWebStoreGame.Text = "---";
                labelTitelGame.Text = "---";
                labelDescriptionGame.Text = "---";
                labelCostGame.Text = "---";
                labelReviewsGame.Text = "---";
                labelDeveloperGame.Text = "---";
                labelPublisherGame.Text = "---";
                labelReleaseYearGame.Text = "---";
                labelGameList.Text = "0/0";
            }
            else
            {
                labelWebStoreGame.Text = FindedGames[GameMarker].Web_Store;
                labelTitelGame.Text = FindedGames[GameMarker].Titel;
                labelDescriptionGame.Text = FindedGames[GameMarker].Description;
                labelCostGame.Text = FindedGames[GameMarker].Cost;
                labelReviewsGame.Text = FindedGames[GameMarker].Reviews;
                labelDeveloperGame.Text = FindedGames[GameMarker].Developer_Name;
                labelPublisherGame.Text = FindedGames[GameMarker].Publisher_Name;
                labelReleaseYearGame.Text = FindedGames[GameMarker].Release_Year;
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
            if (radioButtonTitel.Checked) {
                command = new MySqlCommand("SELECT * FROM `game_summary` WHERE `titel` = @Titel", db.getConnection());
                command.Parameters.Add("@Titel", MySqlDbType.VarChar).Value =search;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (!(table.Rows.Count > 0))
                {
                    MessageBox.Show("По вашему запросу ничего не найдено");
                    FindedGames = new List<Game>();
                    UpdateGameInterfece();
                }
                else {
                    FromTableToListGame(table);
                    UpdateGameInterfece();

                }
            }
            else if (radioButtonDeveloper.Checked) {
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
                else {
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
                else {
                    FromTableToListGame(table);
                    UpdateGameInterfece();
                }
            }
            else if (radioButtonWebStore.Checked) {
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
                else {
                    FromTableToListGame(table);
                    UpdateGameInterfece();
                }
            }
            else if (radioButtonCost.Checked)
            {
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
            else {
                MessageBox.Show("Параметры поcика не выбраны!");
                
            }
        }

        private void buttonNextGame_Click(object sender, EventArgs e)
        {
            if (GameMarker + 1 >= FindedGames.Count) { }
            else {
                GameMarker = GameMarker + 1;
                UpdateGameInterfece();
            }
        }

        private void buttonPrevGame_Click(object sender, EventArgs e)
        {
            if (GameMarker <= 0) { }
            else
            {
                GameMarker = GameMarker -1;
                UpdateGameInterfece();
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int game_id = Convert.ToInt32(FindedGames[GameMarker].Game_Id);
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `kyrsovaya_kis`.`shopping_cart` (`game_game_id`, `bill_bill_id`) VALUES (@Game_Id, '1')", db.getConnection());
            command.Parameters.Add("@Game_Id", MySqlDbType.Int32).Value = game_id;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            { MessageBox.Show("Игра успешно добавленна в корзину"); }
            else
            { MessageBox.Show("Упс! При добавлении иры в корзину возникла ошибка"); }
            db.closeConnection();
            getShoppingCartSummary();
        }

        private void buttonNextProduct_Click(object sender, EventArgs e)
        {
            if (ProductMarker + 1 >= ShoppingCart.Count) { }
            else
            {
                ProductMarker = ProductMarker + 1;
                UpdateProductInterfece();
            }
        }

        private void buttonPrevProduct_Click(object sender, EventArgs e)
        {
            if (ProductMarker <= 0) { }
            else
            {
                ProductMarker = ProductMarker - 1;
                UpdateProductInterfece();
            }
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            int product_id = Convert.ToInt32(ShoppingCart[ProductMarker].Product_ID);
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM `kyrsovaya_kis`.`shopping_cart` WHERE `product_id` = @Product_ID", db.getConnection());
            command.Parameters.Add("@Product_ID", MySqlDbType.Int32).Value = product_id;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            { MessageBox.Show("Игра успешно удалена в корзину"); }
            else
            { MessageBox.Show("Упс! При удалении из корзину возникла ошибка"); }
            db.closeConnection();
            getShoppingCartSummary();
            UpdateProductInterfece();
        }
    }
}
