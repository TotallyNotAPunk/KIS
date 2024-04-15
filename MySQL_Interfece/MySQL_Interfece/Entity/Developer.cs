using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Interfece
{ 
    internal class Developer
    {
        private int developer_id;
        private string developer_name;
        public Developer(int developer_id, string developer_name)
        {
            this.developer_id = developer_id;
            this.developer_name = developer_name;
        }
        public int Developer_Id 
        { 
            get {  return developer_id; }
            private set {  developer_id = value; } 
        }

        public string Developer_Name 
        { 
            get {  return developer_name; }
            private set { developer_name = value; }
        }
    }
}
