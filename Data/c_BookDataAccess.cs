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
    public class CBookDataAccess
    {
        List<c_Genre> genre = new List<c_Genre>();

        public void InsertBooks(CBooks u)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) //connecting to the server
            {
                connection.Open();

                try
                {
                    DynamicParameters parameter = new DynamicParameters();

                    parameter.Add("@AuthorName", u.AuthorName);
                    parameter.Add("@Title", u.Title);
                    parameter.Add("@GenreID", u.GenreID);
                    parameter.Add("@ISBN", u.ISBN);
                    parameter.Add("@Publisher", u.Publisher);
                    parameter.Add("@Price", u.Price);
                    parameter.Add("@PublicationYear", u.PublicationYear);
                    parameter.Add("@Cover", u.Cover);

                    connection.Query<CBooks>("InsertBook @AuthorName, @Title, @GenreID, @ISBN, @Publisher, @Price, @PublicationYear, @Cover", parameter); //this query runs for every single record on the list
                    MessageBox.Show("The book was added successfully!");
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
        }


        public List<c_Genre> RetrieveGenres()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) //connecting to the server
            {
                string sql = @"select * from Genres";

                try
                {
                    genre = connection.Query<c_Genre>(sql).ToList();
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
            return genre;
        }


        public List<CBooks> ViewORSearchBooks(string title)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) //connecting to the server
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Title", title);

                return connection.Query<CBooks>("ViewAllBooksOrSearch @Title", parameter).ToList();
            }
        }


        public List<CBooks> SearchSales(String text)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) //connecting to the server
            {
                connection.Open();

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Title", text);

                return connection.Query<CBooks>("SalesSearch @Title", parameter).ToList(); //this query runs for every single record on the list
            }
        }

        public void UpdateBooks(CBooks u)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) //connecting to the server
            {
                connection.Open();

                try
                {
                    DynamicParameters parameter = new DynamicParameters();

                    parameter.Add("@AuthorName", u.AuthorName);
                    parameter.Add("@Title", u.Title);
                    parameter.Add("@GenreID", u.GenreID);
                    parameter.Add("@ISBN", u.ISBN);
                    parameter.Add("@Publisher", u.Publisher);
                    parameter.Add("@Price", u.Price);
                    parameter.Add("@PublicationYear", u.PublicationYear);

                    connection.Query<CBooks>("UpdateBooks @AuthorName, @Title, @GenreID, @ISBN, @Publisher, @Price, @PublicationYear", parameter);
                    MessageBox.Show("The updation was successful!");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "The updation was not successful!");
                }
            }
        }


        public bool ISBNAuthentication(CBooks u) //boolean method - returns true if the ISBN already exists
        {
            bool IsReal = false;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB")))
            {
                try
                {
                    connection.Open();

                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@ISBN", u.ISBN);

                    var n = connection.Query<CBooks>("ISBNAuthentication @ISBN", parameter);

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


        public void DeleteBook(CBooks u)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) //connecting to the server
            {
                connection.Open();
                try
                {
                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@ISBN", u.ISBN);
                    connection.Query<CBooks>("DeleteBook @ISBN", parameter);
                    MessageBox.Show("The deletion was successful!");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "The deletion was not successful!");
                }
            }
        }
    }
}

