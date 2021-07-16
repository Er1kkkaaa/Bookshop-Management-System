using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Logic
{
    public class CTransactions
    {
        //public int ID { get; set; }
        public float GrandTotal { get; set; }
        public DateTime PurchaseDate { get; set; }
        public float VAT { get; set; }
        public float Discount { get; set; }
    }
}
