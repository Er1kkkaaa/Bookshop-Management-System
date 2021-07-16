using BookShop.Common;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hours_Tick(object sender, EventArgs e)
        {
            lbHours.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
        }

        private void DoOnClick(object sender, EventArgs e)
        {
            int nCommandID = -1;


            ToolStripMenuItem oSenderMenuItem = sender as ToolStripMenuItem;  
                                                                           
            if (oSenderMenuItem == null)
            {
                Control oSenderButton = sender as Control;
                if (oSenderButton != null)
                    nCommandID = Int32.Parse((string)oSenderButton.Tag);
            }
            else
                nCommandID = Int32.Parse((string)oSenderMenuItem.Tag);

            AppFormTypes nFormType = AppFormTypes.UNKNOWN;
            if (nCommandID >= 1000)
                nFormType = (AppFormTypes)(nCommandID - 1000);  

            Form oForm = CFormFactory.CreateForm(nFormType);
            if (oForm != null)
            {
                oForm.MdiParent = this;
                oForm.Show();
            }
        }
    }
}
