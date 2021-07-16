namespace BookShop.UX
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OnExit = new System.Windows.Forms.Button();
            this.logoName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.OnExit);
            this.panel1.Controls.Add(this.logoName);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 63);
            this.panel1.TabIndex = 0;
            // 
            // OnExit
            // 
            this.OnExit.FlatAppearance.BorderSize = 0;
            this.OnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.OnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnExit.Image = ((System.Drawing.Image)(resources.GetObject("OnExit.Image")));
            this.OnExit.Location = new System.Drawing.Point(1211, 4);
            this.OnExit.Name = "OnExit";
            this.OnExit.Size = new System.Drawing.Size(27, 21);
            this.OnExit.TabIndex = 3;
            this.OnExit.UseVisualStyleBackColor = true;
            this.OnExit.Click += new System.EventHandler(this.OnExitClick);
            // 
            // logoName
            // 
            this.logoName.AutoSize = true;
            this.logoName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoName.ForeColor = System.Drawing.Color.White;
            this.logoName.Location = new System.Drawing.Point(86, 21);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(268, 23);
            this.logoName.TabIndex = 2;
            this.logoName.Text = "The Rough Pages Book Shop";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(68, 56);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(384, 323);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(231, 27);
            this.firstname.TabIndex = 1;
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(641, 323);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(231, 27);
            this.lastname.TabIndex = 2;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(383, 391);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(232, 27);
            this.username.TabIndex = 3;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(383, 452);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(489, 27);
            this.emailTxt.TabIndex = 4;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(384, 517);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(489, 27);
            this.password.TabIndex = 6;
            this.password.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(487, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Teal;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(384, 568);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(489, 33);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Tag = "1003";
            this.btnRegister.Text = "Register Now";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.OnRegistrationClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(380, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(380, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(637, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(378, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(380, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password:";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(640, 391);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(232, 27);
            this.phone.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(637, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone:";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 788);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c_RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label logoName;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OnExit;
    }
}