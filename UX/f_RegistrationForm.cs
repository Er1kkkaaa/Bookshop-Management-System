using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using BookShop.Validators;
using FluentValidation.Results;
using BookShop.Data;
using BookShop.Logic;

namespace BookShop.UX
{
    public partial class frmRegistration : Form
    {

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void OnRegistrationClick(object sender, EventArgs e)
        {

            CDataAccess db = new CDataAccess(); //instance of CDataAccess
            CEmployee employee = new CEmployee(); //instance of the employee class

            employee.Username = username.Text.Trim();
            bool DoesExist = db.UsernameAuthentication(employee); //Checking if the username entered exists

            employee.FirstName = firstname.Text.Trim();
            employee.LastName = lastname.Text.Trim();
            employee.Email = emailTxt.Text.Trim();
            employee.Password = password.Text.Trim();
            employee.Phone = phone.Text.Trim();

            CEmployeeValidator validator = new CEmployeeValidator();
            var results = validator.Validate(employee); //abstract function for the validation of the Employee registration form

            if(results.IsValid == false) //if errors present them to the user
            {
                foreach(ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Registration failed!");
                }
            }
            else
            {
                try
                {
                    if (DoesExist) //if the username exists ask the user for a new one
                    {
                        MessageBox.Show("This username already exists, please choose another one!");
                    }
                    else
                    {
                        //enter the new user information into the database
                        db.InsertEmployees(employee);
                        MessageBox.Show("Registration was successful!");
                        this.Hide();
                        Form oForm = new Form1();
                        oForm.Show();
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Unsuccessful registration!");
                }
            }
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            Form oForm = new Form1();
            this.Hide();
            oForm.Show();
        }
    }
}
