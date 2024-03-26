using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Interfece
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=root;database=kyrsovaya_kis;");
        public void openConnection() 
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection() 
        {
            return connection;
        }
    }
}
