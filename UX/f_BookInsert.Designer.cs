namespace BookShop.UX
{
    partial class frmBookInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookInsert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.publishertxt = new System.Windows.Forms.TextBox();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 60);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(296, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "BOOK INFORMATION";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(856, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 21);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.onExitClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(329, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 51;
            this.label8.Text = "ISBN:";
            // 
            // publishertxt
            // 
            this.publishertxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishertxt.Location = new System.Drawing.Point(332, 250);
            this.publishertxt.Name = "publishertxt";
            this.publishertxt.Size = new System.Drawing.Size(243, 31);
            this.publishertxt.TabIndex = 41;
            // 
            // titletxt
            // 
            this.titletxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletxt.Location = new System.Drawing.Point(36, 250);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(243, 31);
            this.titletxt.TabIndex = 38;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Teal;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInsert.Location = new System.Drawing.Point(447, 407);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(128, 30);
            this.btnInsert.TabIndex = 48;
            this.btnInsert.Tag = "1002";
            this.btnInsert.Text = "Add";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(32, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Publication Year:";
            // 
            // pricetxt
            // 
            this.pricetxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(333, 328);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(243, 31);
            this.pricetxt.TabIndex = 40;
            this.pricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricetxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(329, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Publisher:";
            // 
            // yeartxt
            // 
            this.yeartxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeartxt.Location = new System.Drawing.Point(35, 328);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(243, 31);
            this.yeartxt.TabIndex = 42;
            this.yeartxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yeartxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(329, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(32, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Book Title:";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.Location = new System.Drawing.Point(611, 141);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(261, 257);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 52;
            this.imagePictureBox.TabStop = false;
            // 
            // isbntxt
            // 
            this.isbntxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbntxt.Location = new System.Drawing.Point(332, 177);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(243, 31);
            this.isbntxt.TabIndex = 53;
            // 
            // authortxt
            // 
            this.authortxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authortxt.Location = new System.Drawing.Point(35, 178);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(243, 31);
            this.authortxt.TabIndex = 54;
            this.authortxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authortxt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(31, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "Author Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(779, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 56;
            this.button1.Tag = "1002";
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 22;
            this.comboBox1.Location = new System.Drawing.Point(35, 399);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 30);
            this.comboBox1.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(31, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 58;
            this.label9.Text = "Genre:";
            // 
            // frmBookInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 661);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.authortxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isbntxt);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.publishertxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c_BookCRUD";
            this.Load += new System.EventHandler(this.frmBookCRUD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox publishertxt;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
    }
}