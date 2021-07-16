using BookShop.Data;
using BookShop.Logic;
using BookShop.Validators;
using Dapper;
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
    public partial class frmBookInsert : Form
    {
        String imageUrl = null;
        CBookDataAccess dataAccess = new CBookDataAccess();

        public frmBookInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            

            CBooks books = new CBooks(); //instance of the book class
            books.ISBN = isbntxt.Text.Trim();
            bool DoesExist = dataAccess.ISBNAuthentication(books);

            books.AuthorName = authortxt.Text.Trim();
            books.Title = titletxt.Text.Trim();
            books.Publisher = publishertxt.Text.Trim();
            books.Price = float.Parse(pricetxt.Text.Trim());
            books.PublicationYear = Int32.Parse(yeartxt.Text.Trim());

            CBookValidator validator = new CBookValidator();
            var results = validator.Validate(books);


            if (results.IsValid == false) //if errors present them to the user
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Insertion failed!");
                }
            }
            else
            {
                if (DoesExist)
                {
                    MessageBox.Show("A book with the same ISBN already exists, please re-check the credentials!");
                }
                else
                {
                    Image image = imagePictureBox.Image;

                    if (image == null)
                    {
                        MessageBox.Show("Please Enter The Book's Cover!");
                    }
                    else
                    {
                        byte[] arr;
                        ImageConverter converter = new ImageConverter();
                        arr = (byte[])converter.ConvertTo(image, typeof(byte[]));
                        books.Cover = arr;

                        books.GenreID = comboBox1.SelectedIndex + 1;


                        dataAccess.InsertBooks(books);
                        Clear();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    imagePictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void frmBookCRUD_Load(object sender, EventArgs e)
        {

            var list = dataAccess.RetrieveGenres();

            comboBox1.DataSource = list;

            foreach (var l in list)
            {
                comboBox1.ValueMember = nameof(l.GenreID);
                comboBox1.DisplayMember = nameof(l.GenreName);
            }
        }

        private void onExitClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        void Clear()
        {
            authortxt.Text = titletxt.Text = isbntxt.Text = publishertxt.Text = pricetxt.Text = yeartxt.Text = null;
            imagePictureBox.Image = null;
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

        private void authortxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Letters Only!");
            }
        }
    }
 }


