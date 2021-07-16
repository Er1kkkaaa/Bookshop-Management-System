using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public static class CHelper //class that returns the connection string specified in the App.config file
    {
        public static string CnnVal(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
