using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Logic
{
    public class CTransactionDetails
    {
        public int orderID { get; set; }
        public string AuthorName { get; set; }
        public string BookTitle { get; set; }
        public float Price { get; set; }
        public int Qty { get; set; }
        public float Total { get; set; }
    }
}
