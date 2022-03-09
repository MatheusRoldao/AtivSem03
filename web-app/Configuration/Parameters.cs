using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_app.Configuration
{
    public class Parameters
    {
        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["Empresa"].ConnectionString;
        }
    }
}