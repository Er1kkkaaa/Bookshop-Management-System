namespace BookShop.UX
{
    partial class frmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchnametxt = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 58);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(267, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "EMPLOYEE INFORMATION";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(852, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 26);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnExitClick);
            // 
            // firstnametxt
            // 
            this.firstnametxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnametxt.ForeColor = System.Drawing.Color.Teal;
            this.firstnametxt.Location = new System.Drawing.Point(30, 158);
            this.firstnametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(283, 31);
            this.firstnametxt.TabIndex = 6;            // 
            // lastnametxt
            // 
            this.lastnametxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxt.ForeColor = System.Drawing.Color.Teal;
            this.lastnametxt.Location = new System.Drawing.Point(27, 232);
            this.lastnametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(283, 31);
            this.lastnametxt.TabIndex = 7;
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.ForeColor = System.Drawing.Color.Teal;
            this.emailtxt.Location = new System.Drawing.Point(29, 454);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(283, 31);
            this.emailtxt.TabIndex = 8;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.ForeColor = System.Drawing.Color.Teal;
            this.passwordtxt.Location = new System.Drawing.Point(28, 380);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(283, 31);
            this.passwordtxt.TabIndex = 9;
            // 
            // phonetxt
            // 
            this.phonetxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetxt.ForeColor = System.Drawing.Color.Teal;
            this.phonetxt.Location = new System.Drawing.Point(29, 528);
            this.phonetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(283, 31);
            this.phonetxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(25, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(22, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(24, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(25, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(26, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(465, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Search By First Name:";
            // 
            // searchnametxt
            // 
            this.searchnametxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchnametxt.Location = new System.Drawing.Point(645, 117);
            this.searchnametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchnametxt.Name = "searchnametxt";
            this.searchnametxt.Size = new System.Drawing.Size(238, 31);
            this.searchnametxt.TabIndex = 17;
            this.searchnametxt.TextChanged += new System.EventHandler(this.searchnametxt_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(365, 156);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(518, 414);
            this.dataGridView.TabIndex = 18;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(27, 587);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 41);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Tag = "1002";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.OnUpdateClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(175, 587);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 41);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Tag = "";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.OnDeleteClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(23, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Username:";
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.White;
            this.usernametxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.ForeColor = System.Drawing.Color.Teal;
            this.usernametxt.Location = new System.Drawing.Point(28, 306);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.ReadOnly = true;
            this.usernametxt.Size = new System.Drawing.Size(283, 31);
            this.usernametxt.TabIndex = 22;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 661);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.searchnametxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_EmployeesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchnametxt;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox usernametxt;
    }
}