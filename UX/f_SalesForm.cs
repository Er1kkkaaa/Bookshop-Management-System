using BookShop.Data;
using BookShop.Logic;
using DGVPrinterHelper;
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
    public partial class frmSales : Form
    {
        DataTable dataTable = new DataTable();

        public frmSales()
        {
            InitializeComponent();
        }

        private void searched_TextChanged(object sender, EventArgs e)
        {
            CBookDataAccess dataAccess = new CBookDataAccess();
            if(searched.Text.Trim() == "")
            {
                dataGridViewSearch.DataSource = null;
            }
            else
            {
                var list = dataAccess.SearchSales(searched.Text.Trim());
                dataGridViewSearch.DataSource = list;
            }
        }

        private void dataGridViewSearch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewSearch.CurrentRow.Index != -1)
                {
                    authorTxt.Text = dataGridViewSearch.CurrentRow.Cells[0].Value.ToString();
                    titleTxt.Text = dataGridViewSearch.CurrentRow.Cells[1].Value.ToString();
                    priceTxt.Text = dataGridViewSearch.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Total");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string Author = authorTxt.Text;
                string Title = titleTxt.Text;
                float Price = float.Parse(priceTxt.Text);
                int Qty = int.Parse(qtyTxt.Text);
                float Total = Price * Qty;
                float subTotal = float.Parse(subTotalTxt.Text);
                subTotal = subTotal + Total;

                dataTable.Rows.Add(Author, Title, Price, Qty, Total);
                dataGridViewAdded.DataSource = dataTable;

                subTotalTxt.Text = subTotal.ToString();

                searched.Text = "";
                authorTxt.Text = "";
                titleTxt.Text = "";
                priceTxt.Text = "0.00";
                qtyTxt.Text = "0.00";
            }
            catch(Exception)
            {
                MessageBox.Show("Please select an item and add the purchased quantity!");
            }
        }

        private void discountTxt_TextChanged(object sender, EventArgs e)
        {
            string value = discountTxt.Text;

            if(value == "")
            {
                MessageBox.Show("Please Enter The Appropriate Discount!");
            }
            else
            {
                float subTotal = float.Parse(subTotalTxt.Text);
                float discount = float.Parse(discountTxt.Text);
                float grandTotal = ((100 - discount) / 100) * subTotal;

                grandTotalTxt.Text = grandTotal.ToString();
            }
        }

        private void vatTxt_TextChanged(object sender, EventArgs e)
        {
            string check = grandTotalTxt.Text;

            if(check == "")
            {
                MessageBox.Show("Please Enter The Discount! Enter 0 For No Discount.");
            }
            else
            {
                try
                {
                    float previousGT = float.Parse(grandTotalTxt.Text);
                    float vat = float.Parse(vatTxt.Text);
                    float grandTotalWithVAT = ((100 + vat) / 100) * previousGT;

                    grandTotalTxt.Text = grandTotalWithVAT.ToString();
                }
                catch(Exception)
                {
                    MessageBox.Show("Please Enter A Number!");
                }
                
            }
        }

        private void paidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float grandTotal = float.Parse(grandTotalTxt.Text);
                float paidAmount = float.Parse(paidAmountTxt.Text);
                float change = paidAmount - grandTotal;

                changeTxt.Text = change.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter A Number!");
            }
            
        }

        private void discountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Number!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CTransactionsAccess transactionsAccess = new CTransactionsAccess();
                CTransactions cTransactions = new CTransactions();
                CTransactionDetails cTransactionDetails = new CTransactionDetails();

                cTransactions.GrandTotal = float.Parse(grandTotalTxt.Text);
                cTransactions.PurchaseDate = DateTime.Now;
                cTransactions.Discount = float.Parse(discountTxt.Text);
                cTransactions.VAT = float.Parse(vatTxt.Text);

                int retrievedID = transactionsAccess.InsertTransactions(cTransactions);

                cTransactionDetails.orderID = retrievedID;

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string author = dataTable.Rows[i][0].ToString();
                    string title = dataTable.Rows[i][1].ToString();
                    float price = float.Parse(dataTable.Rows[i][2].ToString());
                    int qty = int.Parse(dataTable.Rows[i][3].ToString());
                    float total = float.Parse(dataTable.Rows[i][4].ToString());

                    cTransactionDetails.AuthorName = author;
                    cTransactionDetails.BookTitle = title;
                    cTransactionDetails.Price = price;
                    cTransactionDetails.Qty = qty;
                    cTransactionDetails.Total = total;

                    transactionsAccess.InsertTransactionDetails(cTransactionDetails);
                }
                MessageBox.Show("The bill details were saved successfully!");
            }
            catch(Exception)
            {
                MessageBox.Show("The bill details could not be saved successfully!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void printBill_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n\r\n THE ROUGH PAGES BOOKSTORE";
            printer.SubTitle = "Sola, Erika \r\n Phone: 0030-69XXXXXX \r\n\r\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Discount: " + discountTxt.Text + "% \r\n" + "VAT: " + vatTxt.Text + "% \r\n" + "Grand Total: " +grandTotalTxt.Text+ "\r\n" + "Thank you for your purchase!";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridViewAdded);
        }
    }
}
