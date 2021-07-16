using BookShop.Logic;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BookShop.Data
{
    public class CTransactionsAccess
    {
        public int InsertTransactions(CTransactions u)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) //connecting to the server
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction()) //beginning the transaction
                {
                    try
                    {
                        DynamicParameters parameter = new DynamicParameters();
                        parameter.Add("@GrandTotal", u.GrandTotal);
                        parameter.Add("@PurchaseDate", u.PurchaseDate);
                        parameter.Add("@VAT", u.VAT);
                        parameter.Add("@Discount", u.Discount);

                        connection.Query<CTransactions>("AddTransactions @GrandTotal, @PurchaseDate, @VAT, @Discount", parameter, transaction: transaction); //this query runs for every single record on the list

                        int id = Convert.ToInt32(connection.ExecuteScalar<object>("SELECT @@IDENTITY", null, transaction: transaction));

                        transaction.Commit(); //committing the transaction if successful
                        return id;

                    }
                    catch (Exception E) //catching exceptions and rolling back
                    {
                        Console.WriteLine($"Error: {E.Message}");
                        transaction.Rollback();
                        transaction.Dispose();
                        return 0;
                    }
                    finally
                    {
                        connection.Close();
                    }
                    
                }
            }
        }



        public void InsertTransactionDetails(CTransactionDetails u)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) //connecting to the server
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction()) //beginning the transaction
                {
                    try
                    {
                        DynamicParameters parameter = new DynamicParameters();
                        parameter.Add("@orderID", u.orderID);
                        parameter.Add("@AuthorName", u.AuthorName);
                        parameter.Add("@BookTitle", u.BookTitle);
                        parameter.Add("@Price", u.Price);
                        parameter.Add("@Qty", u.Qty);
                        parameter.Add("@Total", u.Total);

                        connection.Query<CTransactionDetails>("AddTransactionDetails @orderID, @AuthorName, @BookTitle, @Price, @Qty, @Total", parameter, transaction: transaction); //this query runs for every single record on the list

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

        public List<CTransactions> RetrieveTransactions()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB"))) //connecting to the server
            {
                string sql = @"select * from TRANSACTIONS";

                try
                {
                    return connection.Query<CTransactions>(sql).ToList();
                }
                catch (Exception E)
                {
                    Console.WriteLine($"Error: {E.Message}");
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
           
        }
    }
}