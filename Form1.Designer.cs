namespace BookShop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.logoName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.logoName);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1203, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(35, 21);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.OnLogout);
            // 
            // logoName
            // 
            this.logoName.AutoSize = true;
            this.logoName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoName.ForeColor = System.Drawing.Color.White;
            this.logoName.Location = new System.Drawing.Point(86, 19);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(268, 23);
            this.logoName.TabIndex = 1;
            this.logoName.Text = "The Rough Pages Book Shop";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(68, 56);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(459, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter Your Login Credentials";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(463, 458);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(328, 31);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(459, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(459, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(463, 392);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(328, 31);
            this.usernametxt.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(463, 513);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(328, 33);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Tag = "1002";
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.OnLoginClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.ForeColor = System.Drawing.Color.Teal;
            this.registrationLabel.Location = new System.Drawing.Point(438, 591);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(374, 21);
            this.registrationLabel.TabIndex = 8;
            this.registrationLabel.Tag = "1001";
            this.registrationLabel.Text = "Don\'t have an account already? Register now!";
            this.registrationLabel.Click += new System.EventHandler(this.OnRegisterClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 749);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Button btnLogout;
    }
}

