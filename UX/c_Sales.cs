using BookShop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.UX
{
    public partial class c_Sales : Form
    {
        public c_Sales()
        {
            InitializeComponent();
        }

        private void c_Sales_Load(object sender, EventArgs e)
        {
            CTransactionsAccess data = new CTransactionsAccess();
            var list = data.RetrieveTransactions();
            salesDataGridView.DataSource = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
