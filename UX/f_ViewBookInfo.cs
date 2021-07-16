using BookShop.Data;
using BookShop.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.UX
{
    public partial class frmViewBookInfo : Form
    {
        CBookDataAccess dataAccess = new CBookDataAccess();

        public frmViewBookInfo()
        {
            InitializeComponent();
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            List<CBooks> list = dataAccess.ViewORSearchBooks(searchedTitleTxt.Text.Trim());
            dataGridView1.DataSource = list;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string author = dataGridView1.SelectedRows[0].Cells["AuthorName"].Value.ToString();
                string title = dataGridView1.SelectedRows[0].Cells["Title"].Value.ToString();
                int genre = Int32.Parse(dataGridView1.SelectedRows[0].Cells["GenreID"].Value.ToString());
                string isbn = dataGridView1.SelectedRows[0].Cells["ISBN"].Value.ToString();
                string publisher = dataGridView1.SelectedRows[0].Cells["Publisher"].Value.ToString();
                float price = float.Parse(dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString(), CultureInfo.InvariantCulture);
                int year = Int32.Parse(dataGridView1.SelectedRows[0].Cells["PublicationYear"].Value.ToString());
                Byte[] cover = (byte[])dataGridView1.SelectedRows[0].Cells["Cover"].Value;

                Form f2 = new frmBookUpdateDelete(author, title, genre-1, isbn, publisher, price, year, cover);
                f2.StartPosition = FormStartPosition.Manual;
                f2.Left = 330;
                f2.Top = 120;
                f2.Show();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message, "Not able to retrieve records!");
            }
        }

        private void searchedTitleTxt_TextChanged(object sender, EventArgs e)
        {
            List<CBooks> list = dataAccess.ViewORSearchBooks(searchedTitleTxt.Text.Trim());
            dataGridView1.DataSource = list;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
