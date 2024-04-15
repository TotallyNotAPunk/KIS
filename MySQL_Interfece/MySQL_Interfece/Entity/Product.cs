using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Interfece
{
    class Product
    {
        private int product_id;
        private string web_store;
        private string titel;
        private string cost;
        private string bill_sum;

        public Product(int product_id, string web_store, string titel, string cost, string bill_sum)
        {
            this.product_id = product_id;
            this.web_store = web_store;
            this.titel = titel;
            this.cost = cost;
            this.bill_sum = bill_sum;
        }

        public int Product_ID
        {
            get { return product_id; }
            private set { product_id = value; }
        }
        public string Web_Store
        {
            get { return web_store; }
            private set { web_store = value; }
        }
        public string Titel
        {
            get { return titel; }
            private set { titel = value; }
        }
        public string Cost
        {
            get { return cost; }
            private set { cost = value; }
        }
        public string Bill_Sum
        {
            get { return bill_sum; }
            private set { bill_sum = value; }
        }
    }
}
