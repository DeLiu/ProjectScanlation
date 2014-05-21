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

            SQLInterface sqlinterface = new SQLInterface();
            sqlinterface.SelectData();
            sqlinterface.Insert();
            sqlinterface.Update();
            CheckKlient ck = new CheckKlient();
            ck.ValidateUserInfo("Junas65", "Theundertaker");
            ck.ValidateUserInfo("Maria76", "Mrjuicy");

           

         
            
            
        }

    }
}   
          
            
