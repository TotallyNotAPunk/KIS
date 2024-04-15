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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            String loginUser = textBoxUsername.Text;
            String passwordUser = textBoxPassword.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `user_name` = @username AND `user_password` = @user_password", db.getConnection());
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@user_password", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            { 
                DataRow[] rows = table.Select();
                User user = new User(
                    Convert.ToString(rows[0]["user_id"]),
                    Convert.ToString(rows[0]["user_name"]),
                    Convert.ToString(rows[0]["user_password"]),
                    Convert.ToString(rows[0]["user_role"]));
                this.Hide();
                if (user.Role == "User")
                { 
                    Form1 form1 = new Form1(user);
                    form1.Show();
                }
                else if (user.Role == "Admin") 
                {
                    Form3 form3 = new Form3(user);
                    form3.Show();
                }
            }
            else
            { MessageBox.Show("Не верный логин или пароль. Проверьте введеные данные."); }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
