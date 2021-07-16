using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookShop.Logic
{
    public class CEmployee //representing the Employee sql table
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Username { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Phone { get; set; }

    }
}
