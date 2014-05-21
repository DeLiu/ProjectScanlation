using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Server_App
{
    class CheckKlient
    {
   
        public void ValidateUserInfo(string username, string password)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=testdb;     
                                                          Integrated Security=True");
            conn.Open();

            string sql = "SELECT * FROM Customer WHERE Username=@Username And Password=@Password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("Username", username));
            cmd.Parameters.Add(new SqlParameter("Password", password));
            SqlDataReader reader = cmd.ExecuteReader();
            String strResult = String.Empty;

            while (reader.Read())
            {
                Console.WriteLine("{1}", "{0}", reader.GetString(0) + " " + reader.GetString(1));
                if ((strResult.Length > 0) || (strResult.Length == 1))
                {
                    Console.WriteLine("InValid Username, Password");
                }
                else
                {
                    Console.WriteLine("Valid Username, Password");



                }
            }
        }
    }
}


      






          
    
    
    
    
    
    
    
    
    
    
    
