using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Logic
{
    public class CBooks
    {

        public String AuthorName { get; set; }
        public String Title { get; set; }
        public int GenreID { get; set; }
        public String ISBN { get; set; }
        public String Publisher { get; set; }
        public float Price { get; set; }
        public int PublicationYear { get; set; }
        public Byte[] Cover { get; set; }

    }
}
