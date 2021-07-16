using BookShop.Data;
using BookShop.Logic;
using BookShop.Validators;
using FluentValidation.Results;
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
    public partial class frmEmployees : Form
    {
        CDataAccess dataAccess = new CDataAccess();
        CEmployee employee = new CEmployee(); //instance of the employee class

        public frmEmployees()
        {
            InitializeComponent();
        }


        private void searchnametxt_TextChanged(object sender, EventArgs e)
        {
            if (searchnametxt.Text == "")
            {
                dataGridView.DataSource = null;
            }
            else
            {
                dataGridView.DataSource = dataAccess.SearchEmployees(searchnametxt.Text.Trim());
            }
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView.CurrentRow.Index != -1)
                {
                    firstnametxt.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                    lastnametxt.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                    usernametxt.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                    emailtxt.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                    passwordtxt.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
                    phonetxt.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void OnUpdateClick(object sender, EventArgs e)
        {
            employee.FirstName = firstnametxt.Text.Trim();
            employee.LastName = lastnametxt.Text.Trim();
            employee.Username = usernametxt.Text.Trim();
            employee.Email = emailtxt.Text.Trim();
            employee.Password = passwordtxt.Text.Trim();
            employee.Phone = phonetxt.Text.Trim();


            CEmployeeValidator validator = new CEmployeeValidator();
            var results = validator.Validate(employee);

            if (results.IsValid == false) //if errors present them to the user
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Registration failed!");
                }
            }
            else
            {
                dataAccess.UpdateEmployeeInfo(employee);
                MessageBox.Show("Updation was successful!");
                Clear();
            }
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            employee.Username = usernametxt.Text.Trim();
            dataAccess.DeleteEmployee(employee);
            Clear();
        }

        void Clear()
        {
            firstnametxt.Text = lastnametxt.Text = usernametxt.Text = emailtxt.Text = passwordtxt.Text = passwordtxt.Text = phonetxt.Text = searchnametxt.Text = null;
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
