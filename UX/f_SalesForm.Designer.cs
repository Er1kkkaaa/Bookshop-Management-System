namespace BookShop.UX
{
    partial class frmSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searched = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cover = new System.Windows.Forms.DataGridViewImageColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.productDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.qtyTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.changeTxt = new System.Windows.Forms.TextBox();
            this.paidAmountTxt = new System.Windows.Forms.TextBox();
            this.grandTotalTxt = new System.Windows.Forms.TextBox();
            this.vatTxt = new System.Windows.Forms.TextBox();
            this.subTotalTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewAdded = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.printBill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdded)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 41);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(383, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "SALES FORM";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(899, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 21);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Product Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Author Name:";
            // 
            // searched
            // 
            this.searched.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searched.Location = new System.Drawing.Point(155, 37);
            this.searched.Name = "searched";
            this.searched.Size = new System.Drawing.Size(449, 27);
            this.searched.TabIndex = 27;
            this.searched.TextChanged += new System.EventHandler(this.searched_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewSearch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.productDateTimePicker);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.qtyTxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.titleTxt);
            this.panel2.Controls.Add(this.authorTxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.priceTxt);
            this.panel2.Controls.Add(this.searched);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 202);
            this.panel2.TabIndex = 37;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToAddRows = false;
            this.dataGridViewSearch.AllowUserToDeleteRows = false;
            this.dataGridViewSearch.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorName,
            this.Title,
            this.Price,
            this.PublicationYear,
            this.ISBN,
            this.Publisher,
            this.GenreID,
            this.Cover});
            this.dataGridViewSearch.Location = new System.Drawing.Point(621, 6);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.ReadOnly = true;
            this.dataGridViewSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSearch.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearch.Size = new System.Drawing.Size(290, 181);
            this.dataGridViewSearch.TabIndex = 71;
            this.dataGridViewSearch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearch_CellContentDoubleClick);
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "Author Name";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // PublicationYear
            // 
            this.PublicationYear.DataPropertyName = "PublicationYear";
            this.PublicationYear.HeaderText = "Publication Year";
            this.PublicationYear.Name = "PublicationYear";
            this.PublicationYear.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // GenreID
            // 
            this.GenreID.DataPropertyName = "GenreID";
            this.GenreID.HeaderText = "Genre";
            this.GenreID.Name = "GenreID";
            this.GenreID.ReadOnly = true;
            this.GenreID.Visible = false;
            // 
            // Cover
            // 
            this.Cover.DataPropertyName = "Cover";
            this.Cover.HeaderText = "Cover";
            this.Cover.Name = "Cover";
            this.Cover.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(19, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Bill Date:";
            // 
            // productDateTimePicker
            // 
            this.productDateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDateTimePicker.Location = new System.Drawing.Point(155, 164);
            this.productDateTimePicker.Name = "productDateTimePicker";
            this.productDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.productDateTimePicker.TabIndex = 69;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(520, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 30);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Tag = "";
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // qtyTxt
            // 
            this.qtyTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTxt.Location = new System.Drawing.Point(437, 109);
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.Size = new System.Drawing.Size(167, 27);
            this.qtyTxt.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(382, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Qty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(381, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Search Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(19, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Title:";
            // 
            // titleTxt
            // 
            this.titleTxt.BackColor = System.Drawing.Color.White;
            this.titleTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(155, 121);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.ReadOnly = true;
            this.titleTxt.Size = new System.Drawing.Size(200, 27);
            this.titleTxt.TabIndex = 41;
            // 
            // authorTxt
            // 
            this.authorTxt.BackColor = System.Drawing.Color.White;
            this.authorTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTxt.Location = new System.Drawing.Point(155, 80);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.ReadOnly = true;
            this.authorTxt.Size = new System.Drawing.Size(200, 27);
            this.authorTxt.TabIndex = 40;
            // 
            // priceTxt
            // 
            this.priceTxt.BackColor = System.Drawing.Color.White;
            this.priceTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(437, 76);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(167, 27);
            this.priceTxt.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.printBill);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.discountTxt);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.changeTxt);
            this.panel3.Controls.Add(this.paidAmountTxt);
            this.panel3.Controls.Add(this.grandTotalTxt);
            this.panel3.Controls.Add(this.vatTxt);
            this.panel3.Controls.Add(this.subTotalTxt);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(446, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 311);
            this.panel3.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(18, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Discount (%):";
            // 
            // discountTxt
            // 
            this.discountTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTxt.Location = new System.Drawing.Point(158, 72);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(308, 27);
            this.discountTxt.TabIndex = 81;
            this.discountTxt.TextChanged += new System.EventHandler(this.discountTxt_TextChanged);
            this.discountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTxt_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(187, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 30);
            this.button2.TabIndex = 71;
            this.button2.Tag = "";
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Teal;
            this.label16.Location = new System.Drawing.Point(18, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 20);
            this.label16.TabIndex = 80;
            this.label16.Text = "VAT (%):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(18, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 79;
            this.label15.Text = "Grand Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(18, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 78;
            this.label14.Text = "Paid Ammount:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(18, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 77;
            this.label13.Text = "Return Ammount:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(18, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "Sub Total:";
            // 
            // changeTxt
            // 
            this.changeTxt.BackColor = System.Drawing.Color.White;
            this.changeTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTxt.Location = new System.Drawing.Point(158, 228);
            this.changeTxt.Name = "changeTxt";
            this.changeTxt.ReadOnly = true;
            this.changeTxt.Size = new System.Drawing.Size(308, 27);
            this.changeTxt.TabIndex = 76;
            // 
            // paidAmountTxt
            // 
            this.paidAmountTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmountTxt.Location = new System.Drawing.Point(158, 189);
            this.paidAmountTxt.Name = "paidAmountTxt";
            this.paidAmountTxt.Size = new System.Drawing.Size(308, 27);
            this.paidAmountTxt.TabIndex = 75;
            this.paidAmountTxt.TextChanged += new System.EventHandler(this.paidAmount_TextChanged);
            // 
            // grandTotalTxt
            // 
            this.grandTotalTxt.BackColor = System.Drawing.Color.White;
            this.grandTotalTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalTxt.Location = new System.Drawing.Point(158, 150);
            this.grandTotalTxt.Name = "grandTotalTxt";
            this.grandTotalTxt.ReadOnly = true;
            this.grandTotalTxt.Size = new System.Drawing.Size(308, 27);
            this.grandTotalTxt.TabIndex = 74;
            // 
            // vatTxt
            // 
            this.vatTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatTxt.Location = new System.Drawing.Point(158, 111);
            this.vatTxt.Name = "vatTxt";
            this.vatTxt.Size = new System.Drawing.Size(308, 27);
            this.vatTxt.TabIndex = 73;
            this.vatTxt.TextChanged += new System.EventHandler(this.vatTxt_TextChanged);
            // 
            // subTotalTxt
            // 
            this.subTotalTxt.BackColor = System.Drawing.Color.White;
            this.subTotalTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTxt.ForeColor = System.Drawing.Color.Black;
            this.subTotalTxt.Location = new System.Drawing.Point(158, 33);
            this.subTotalTxt.Name = "subTotalTxt";
            this.subTotalTxt.ReadOnly = true;
            this.subTotalTxt.Size = new System.Drawing.Size(308, 27);
            this.subTotalTxt.TabIndex = 71;
            this.subTotalTxt.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(18, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 19);
            this.label11.TabIndex = 72;
            this.label11.Text = "Calculation Details:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewAdded);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(12, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 311);
            this.panel4.TabIndex = 73;
            // 
            // dataGridViewAdded
            // 
            this.dataGridViewAdded.AllowUserToAddRows = false;
            this.dataGridViewAdded.AllowUserToDeleteRows = false;
            this.dataGridViewAdded.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdded.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAdded.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewAdded.Name = "dataGridViewAdded";
            this.dataGridViewAdded.ReadOnly = true;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAdded.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAdded.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdded.Size = new System.Drawing.Size(403, 289);
            this.dataGridViewAdded.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(12, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 19);
            this.label10.TabIndex = 71;
            this.label10.Text = "Added Products:";
            // 
            // printBill
            // 
            this.printBill.BackColor = System.Drawing.Color.Teal;
            this.printBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBill.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.printBill.Location = new System.Drawing.Point(333, 278);
            this.printBill.Name = "printBill";
            this.printBill.Size = new System.Drawing.Size(122, 30);
            this.printBill.TabIndex = 83;
            this.printBill.Tag = "";
            this.printBill.Text = "Print Bill";
            this.printBill.UseVisualStyleBackColor = false;
            this.printBill.Click += new System.EventHandler(this.printBill_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 610);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_SalesForm";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdded)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searched;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox qtyTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker productDateTimePicker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox changeTxt;
        private System.Windows.Forms.TextBox paidAmountTxt;
        private System.Windows.Forms.TextBox grandTotalTxt;
        private System.Windows.Forms.TextBox vatTxt;
        private System.Windows.Forms.TextBox subTotalTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.DataGridView dataGridViewAdded;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicationYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreID;
        private System.Windows.Forms.DataGridViewImageColumn Cover;
        private System.Windows.Forms.Button printBill;
    }
}