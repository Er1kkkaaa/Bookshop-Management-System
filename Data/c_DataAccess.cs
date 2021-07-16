using BookShop.Logic;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.Data
{
    public class CDataAccess //class that contains queries needed to access and retrieve data from the Employees table
    {
 
        public void InsertEmployees(CEmployee u)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) //connecting to the server
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction()) //beginning the transaction
                {
                    try
                    {
                        DynamicParameters parameter = new DynamicParameters();

                        parameter.Add("@FirstName", u.FirstName);
                        parameter.Add("@LastName", u.LastName);
                        parameter.Add("@Username", u.Username);
                        parameter.Add("@Email", u.Email);
                        parameter.Add("@Password", u.Password);
                        parameter.Add("@Phone", u.Phone);

                        connection.Query<CEmployee>("AddEmployees @FirstName, @LastName, @Username, @Email, @Password, @Phone", parameter, transaction: transaction); //this query runs for every single record on the list

                        transaction.Commit(); //committing the transaction if successful
                    }
                    catch (Exception E) //catching exceptions and rolling back
                    {
                        Console.WriteLine($"Error: {E.Message}");
                        transaction.Rollback();
                        transaction.Dispose();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }


        public List<CEmployee> SearchEmployees(String text)
        {
             using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) 
             {
                connection.Open();
                
                DynamicParameters parameter = new DynamicParameters();

                parameter.Add("@FirstName", text);

                return connection.Query<CEmployee>("SearchEmployees @FirstName", parameter).ToList(); 
   
             }
        }


         public void UpdateEmployeeInfo(CEmployee u)
         {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) 
            {
                connection.Open();

                 try
                 {
                    DynamicParameters parameter = new DynamicParameters();

                    parameter.Add("@FirstName", u.FirstName);
                    parameter.Add("@LastName", u.LastName);
                    parameter.Add("@Username", u.Username);
                    parameter.Add("@Email", u.Email);
                    parameter.Add("@Password", u.Password);
                    parameter.Add("@Phone", u.Phone);

                    connection.Query<CEmployee>("UpdateEmployees @FirstName, @LastName, @Username, @Email, @Password, @Phone", parameter); 
                 }
                 catch (Exception E)
                 {
                     MessageBox.Show(E.Message, "The updation was not successful!");
                 }
            }
         }



         public void DeleteEmployee(CEmployee u)
         {
             using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB")))
            { 
                connection.Open();
                try
                {
                    DynamicParameters parameter = new DynamicParameters();

                    parameter.Add("@Username", u.Username);

                    connection.Query<CEmployee>("DeleteEmployees @Username", parameter); 
                    MessageBox.Show("The deletion was successful!");
                }
                catch (Exception E)
                {
                     MessageBox.Show(E.Message, "The deletion was not successful!");
                }
                finally
                {
                    connection.Close();
                }
             }
         }



         public bool LoginAuthentication(CEmployee u) //boolean method - returns true if the user exists
         {
             bool IsReal = false;
             using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB")))
             {
                 try
                 {
                    connection.Open();

                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@Username", u.Username);
                    parameter.Add("@Password", u.Password);

                    var n = connection.Query<CEmployee>("UserLogin @Username, @Password", parameter);
                    
                    if (n.Count() != 0)
                    {
                         IsReal = true;
                    }
                    else
                         IsReal = false;
                 }
                 catch (Exception E) 
                 {
                     Console.WriteLine($"Error: {E.Message}");
                 }
                 finally
                 {
                     connection.Close();
                 }
             }
             return IsReal;
         }




      /*  public override string SqlString()
        {
            return "UsernameAuthenticity @Username";
        }


        public override DynamicParameters DynamicParameters()
        {
            CEmployee u = new CEmployee();
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("@Username", u.Username);

            return dynamic;
        } */

        public bool UsernameAuthentication(CEmployee u) //boolean method - returns true if the username already exists
         {
            bool IsReal = false;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB")))
             {
                 try
                 {
                    connection.Open();

                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@Username", u.Username);

                    var n = connection.Query<CEmployee>("UsernameAuthenticity @Username", parameter);

                    if (n.Count() != 0)
                    {
                         IsReal = true;
                    }
                    else
                         IsReal = false;
                 }
                 catch (Exception E)
                 {
                     Console.WriteLine($"Error: {E.Message}");
                 }
                 finally
                 {
                     connection.Close();
                 }
             }
             return IsReal;
         }

    }
}




