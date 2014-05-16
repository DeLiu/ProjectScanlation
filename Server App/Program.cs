using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Server_App
{
    class Program
    {


        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=testdb;     
                                                          Integrated Security=True");
            conn.Open();
            SqlCommand _command = new SqlCommand("SELECT Firstname, Adress FROM Customer", conn);
            SqlDataReader read = _command.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine("{1}","{0}",read.GetString(0 ) + " " +  read.GetString(1));
            }
            read.Close();
            conn.Close();


            

        }
    }
}
