using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    class SQLhandler
    {
        public readonly string connString = "server=localhost;Port=3306;Database=survey;Uid=root;password=root;"; //change to save data on another server
        MySqlConnection conn;

        public SQLhandler() {

            conn = new MySqlConnection(connString);
        }
      
        public void addQuestion(string question)// MySQL schema to insert a question into the table 
        {
            applyQuery("insert into surveytable (question) values('" + question+"');");

        }
        public void updateOpinion(string question, string opinion, int stat)//updates the opinions for the existing question
        {

            string query = "update surveytable SET " + opinion + " = " + stat + " where question = '" + question + "';";
            Console.WriteLine(query);
            applyQuery(query);


        }

        public int[] dbread(string question)
        {
            int[] arr = new int[5];
            connect();
            MySqlCommand msc = new MySqlCommand("SELECT * FROM surveytable  where question = '" + question + "';", conn);
            MySqlDataReader dataReader = msc.ExecuteReader();

            while (dataReader.Read())
            {
                arr[0] =(int)dataReader["sd"];
                arr[1] = (int)dataReader["d"];
                arr[2] = (int)dataReader["n"];
                arr[3] = (int)dataReader["a"];
                arr[4] = (int)dataReader["sa"];
                
            }
            dataReader.Close();
            disconnect();
            return arr;
        }

        public void applyQuery(string a) {
            connect();
            MySqlCommand msc = conn.CreateCommand();
            msc.CommandText = a;

            msc.ExecuteReader();
            disconnect();
        }
        public void connect() {//sets the connection with the db
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void disconnect() {//disconnects from the db
            conn.Close();
        }

        public string getLastQuestion()
        {
            string a= null;
            connect();
            MySqlCommand msc = new MySqlCommand("SELECT * FROM surveytable WHERE id=(SELECT MAX(id) FROM surveytable);", conn);
            MySqlDataReader dataReader = msc.ExecuteReader();
            while (dataReader.Read())
            {
                a= (string)dataReader["question"];
            }
            dataReader.Close();
            return a;
        }

        
        

    }//end class
}
