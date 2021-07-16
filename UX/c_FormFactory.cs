using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Common;

namespace BookShop.UX
{
    public class CFormFactory
    {
        public static Form CreateForm(AppFormTypes p_oType) //Factory method pattern
        {
            switch (p_oType)
            {
                case AppFormTypes.ADD: return new frmBookInsert();
                case AppFormTypes.TRANSACTIONS: return new c_Sales();
                case AppFormTypes.MENU: return new frmMenu();
                case AppFormTypes.EMPLOYEES: return new frmEmployees();
                case AppFormTypes.SALES: return new frmSales();
                case AppFormTypes.VIEWBOOKS: return new frmViewBookInfo();
                default: return null;
            }
        }
    }
}
