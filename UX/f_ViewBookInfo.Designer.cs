namespace BookShop.UX
{
    partial class frmViewBookInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBookInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cover = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchedTitleTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorName,
            this.Title,
            this.GenreID,
            this.ISBN,
            this.Publisher,
            this.Price,
            this.PublicationYear,
            this.Cover});
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 140;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(871, 468);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellClick);
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "AuthorName";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            this.AuthorName.Width = 91;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 52;
            // 
            // GenreID
            // 
            this.GenreID.DataPropertyName = "GenreID";
            this.GenreID.HeaderText = "GenreID";
            this.GenreID.Name = "GenreID";
            this.GenreID.ReadOnly = true;
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
            this.PublicationYear.HeaderText = "PublicationYear";
            this.PublicationYear.Name = "PublicationYear";
            this.PublicationYear.ReadOnly = true;
            // 
            // Cover
            // 
            this.Cover.DataPropertyName = "Cover";
            this.Cover.HeaderText = "Cover";
            this.Cover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Cover.Name = "Cover";
            this.Cover.ReadOnly = true;
            this.Cover.Width = 200;
            // 
            // searchedTitleTxt
            // 
            this.searchedTitleTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedTitleTxt.Location = new System.Drawing.Point(60, 105);
            this.searchedTitleTxt.Name = "searchedTitleTxt";
            this.searchedTitleTxt.Size = new System.Drawing.Size(243, 31);
            this.searchedTitleTxt.TabIndex = 56;
            this.searchedTitleTxt.TextChanged += new System.EventHandler(this.searchedTitleTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(56, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Search Books By Title:";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Teal;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchBtn.Location = new System.Drawing.Point(341, 106);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(128, 30);
            this.searchBtn.TabIndex = 57;
            this.searchBtn.Tag = "1002";
            this.searchBtn.Text = "Refresh";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.OnSearchClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 55);
            this.panel1.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(296, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "BOOK SEARCH FORM";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(855, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 21);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmViewBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchedTitleTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewBookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_ViewBookInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchedTitleTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicationYear;
        private System.Windows.Forms.DataGridViewImageColumn Cover;
    }
}