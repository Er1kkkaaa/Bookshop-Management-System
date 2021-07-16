using BookShop.UX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Common;
using BookShop.Data;
using BookShop.Logic;

namespace BookShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.passwordtxt.AutoSize = false;
            this.passwordtxt.Size = new Size(this.passwordtxt.Size.Width, 50);
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            CDataAccess dataAccess = new CDataAccess(); //data access instance
            CEmployee employee = new CEmployee(); //instance of the employee class

            if (!String.IsNullOrEmpty(usernametxt.Text.Trim()) && !String.IsNullOrEmpty(passwordtxt.Text.Trim()))
            {
                //if the user input is not empty check to see if the user exists

                employee.Username = usernametxt.Text.Trim();
                employee.Password = passwordtxt.Text.Trim();

                bool IsReal = dataAccess.LoginAuthentication(employee);

                if (IsReal) //if true redirect the user to the Main Menu
                {
                    Form oForm = new frmMenu();
                    this.Hide();
                    oForm.Show();
                }
                else
                    MessageBox.Show("Your credentials are not part of the system!");
            }
            else
                MessageBox.Show("Please enter your credentials!");

        }

        private void OnRegisterClick(object sender, EventArgs e) //if the registration label is clicked lead to the registation form
        {
            Form oForm = new frmRegistration(); 
            this.Hide();
            oForm.Show();
        }

        private void OnLogout(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
