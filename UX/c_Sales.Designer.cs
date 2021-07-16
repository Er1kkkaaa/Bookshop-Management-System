namespace BookShop.UX
{
    partial class c_Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(c_Sales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchedTitleTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(895, 55);
            this.panel1.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(356, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "SALES FORM";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(856, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 21);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Location = new System.Drawing.Point(35, 171);
            this.salesDataGridView.Name = "salesDataGridView";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.salesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.salesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDataGridView.Size = new System.Drawing.Size(822, 334);
            this.salesDataGridView.TabIndex = 60;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Teal;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchBtn.Location = new System.Drawing.Point(328, 114);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(128, 30);
            this.searchBtn.TabIndex = 63;
            this.searchBtn.Tag = "1002";
            this.searchBtn.Text = "Refresh";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // searchedTitleTxt
            // 
            this.searchedTitleTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedTitleTxt.Location = new System.Drawing.Point(47, 113);
            this.searchedTitleTxt.Name = "searchedTitleTxt";
            this.searchedTitleTxt.Size = new System.Drawing.Size(243, 31);
            this.searchedTitleTxt.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(43, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(364, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Search Sales By Genres (TO BE IMPLEMENTED):";
            // 
            // c_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 661);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchedTitleTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salesDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "c_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c_Sales";
            this.Load += new System.EventHandler(this.c_Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchedTitleTxt;
        private System.Windows.Forms.Label label8;
    }
}