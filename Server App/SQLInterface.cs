using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Server_App
{

    class SQLInterface
    {

        public void SelectData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=testdb;     
                                                          Integrated Security=True");
            conn.Open();
            SqlCommand _command = new SqlCommand("SELECT Firstname, Adress FROM Customer", conn);
            SqlDataReader read = _command.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine("{1}", "{0}", read.GetString(0) + " " + read.GetString(1));
            }
            read.Close();
            conn.Close();

        }
        public void Insert()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=testdb;     
                                                          Integrated Security=True");

            conn.Open();
            String query = "INSERT INTO Customer(Firstname,Adress) VALUES(@Firstname, @Adress)";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@Firstname", SqlDbType.NChar);
            command.Parameters["@Firstname"].Value = "Michael";
            command.Parameters.Add("@Adress", SqlDbType.NChar);
            command.Parameters["@Adress"].Value = "Odense";

            command.ExecuteNonQuery();

        }
        public void Update()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=testdb;     
                                                          Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Customer SET Firstname = @Firstname, Adress=@Adress Where ID=3", conn);
            cmd.Parameters.AddWithValue("@Firstname", "Kaj");
            cmd.Parameters.AddWithValue("@Adress", "Århus");

            int row = cmd.ExecuteNonQuery();

        }
    }
}
            
    

      






           


       
    
