using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace DailyCheckins.Classes
{
    public class DBConnect
    {
        public static string ConnectionString
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString.ToString();
            }
        }
       
    }
}