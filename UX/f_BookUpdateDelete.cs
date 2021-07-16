using BookShop.Data;
using BookShop.Logic;
using BookShop.Validators;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.UX
{
    public partial class frmBookUpdateDelete : Form
    {
        CBookDataAccess dataAccess = new CBookDataAccess();

        public frmBookUpdateDelete(String author, String title, int genreID, String isbn, String publisher, float price, int publicationYear, Byte[] cover)
        {
            InitializeComponent();

            ViewGenre();

            authortxt1.Text = author;
            titletxt.Text = title;
            isbntxt.Text = isbn;
            genreIDcombo.SelectedIndex = genreID;
            publishertxt.Text = publisher;
            pricetxt.Text = price.ToString();
            yeartxt.Text = publicationYear.ToString();
            imagePictureBox.Image = ByteToImage(cover);
        }

        private void OnBtnUpdateClick(object sender, EventArgs e)
        {
            CBooks books = new CBooks(); //instance of the employee class

            books.AuthorName = authortxt1.Text.Trim();
            books.Title = titletxt.Text.Trim();
            books.ISBN = isbntxt.Text.Trim();
            books.Publisher = publishertxt.Text.Trim();
            books.Price = float.Parse(pricetxt.Text.Trim());
            books.PublicationYear = Int32.Parse(yeartxt.Text.Trim());
            

            CBookValidator validator = new CBookValidator();
            var results = validator.Validate(books);


            if (results.IsValid == false) //if errors present them to the user
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Updation failed!");
                }
            }
            else
            {
                books.GenreID = genreIDcombo.SelectedIndex + 1;
                dataAccess.UpdateBooks(books);
            } 
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void ViewGenre()
        {
            var list = dataAccess.RetrieveGenres();

            genreIDcombo.DataSource = list;

            foreach (var l in list)
            {
                genreIDcombo.ValueMember = nameof(l.GenreID);
                genreIDcombo.DisplayMember = nameof(l.GenreName);
            }
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void Clear()
        {
            authortxt1.Text = titletxt.Text = isbntxt.Text = publishertxt.Text = pricetxt.Text = yeartxt.Text = null;
            imagePictureBox.Image = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CBooks books = new CBooks(); //instance of the employee class
            books.ISBN = isbntxt.Text.Trim();
            dataAccess.DeleteBook(books);
            Clear();
        }

        private void yeartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Number!");
            }
        }

        private void pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter A Number!");
            }
        }

        private void authortxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Letters Only!");
            }
        }
    }
}
