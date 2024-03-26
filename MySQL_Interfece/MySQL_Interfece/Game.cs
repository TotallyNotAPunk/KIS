using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Interfece
{
    class Game
    {
        private string game_id;
        private string titel;
        private string description;
        private string release_year;
        private string cost;
        private string reviews;
        private string developer_name;
        private string publisher_name;
        private string web_store;

        public Game(string game_id, string titel, string description, string release_year, string cost, string reviews, string developer_name, string publisher_name, string web_store)
        {
            this.game_id = game_id;
            this.web_store = web_store;
            this.titel = titel;
            this.description = description;
            this.release_year = release_year;
            this.cost = cost;
            this.reviews = reviews;
            this.developer_name = developer_name;
            this.publisher_name = publisher_name;
        }

        public string Game_Id
        {
            get { return game_id; }
            private set { game_id = value; }
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
        public string Description
        {
            get { return description; }
            private set { description = value; }
        }
        public string Release_Year
        {
            get { return release_year; }
            private set { release_year = value; }
        }
        public string Cost
        {
            get { return cost; }
            private set { cost = value; }
        }
        public string Reviews
        {
            get { return reviews; }
            private set { reviews = value; }
        }
        public string Developer_Name
        {
            get { return developer_name; }
            private set { developer_name = value; }
        }
        public string Publisher_Name
        {
            get { return publisher_name; }
            private set { publisher_name = value; }
        }
    }
}
