using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CTVConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PotentialVoter testVoter;
            testVoter = new PotentialVoter();

            LikelyDemocraticVoter newDemoVoter;
            newDemoVoter = new LikelyDemocraticVoter(testVoter);
           


           
        }
        public void ConnectToDatabase()
        {
            string connStr = "server=localhost;user=root;database=ctv;port=3306;password=root";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL");
                conn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void sqlCommand(string command, MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand(command, conn);
            object result = cmd.ExecuteScalar();
            Console.WriteLine(result);
            result = Convert.ToString(result);
            return;
        }

        public void closeConnection(MySqlConnection conn)
        {
            conn.Close();
            return;
        }



    }
}
