using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Interfece
{
    internal class Publisher
    {
        private int publisher_id;
        private string publisher_name;
        public Publisher(int publisher_id, string publisher_name) 
        { 
            this.publisher_id = publisher_id;
            this.publisher_name = publisher_name;
        }
        public int Publisher_Id
        {
            get { return publisher_id; }
            private set { publisher_id = value; }
        }

        public string Publisher_Name
        {
            get { return publisher_name; }
            private set { publisher_name = value; }
        }
    }
}
