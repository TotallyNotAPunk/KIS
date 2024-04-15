using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Interfece
{
    public class User
    {
        private string user_id;
        private string name;
        private string password;
        private string role;

        public User(string user_id, string name, string password, string role)
        {
            this.user_id = user_id;
            this.name = name;
            this.password = password;
            this.role = role;
        }

        public string User_ID 
        {
            get { return user_id; }
            private set { user_id = value; }
        }

        public string Name 
        {
            get { return name; }
            private set { name = value; }
        }

        public string Password 
        {
            get { return password; }
            private set { password = value; }
        }

        public string Role 
        {
            get { return role; }
            private set { role = value; }
        }

    }
}
