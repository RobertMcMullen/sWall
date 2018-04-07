using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
 

namespace WindowsFormsApplication2
{
    class MySQLhandler
    {
        static void Main(String[] args)
        {
            trying();

        }

        public void trying() {

            string connString = "server=localhost;Port=3306;Database=survey;Uid=root;password=root";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand = conn.CreateCommand();

            Console.WriteLine("Hello World!");


        }

        
    }
}
