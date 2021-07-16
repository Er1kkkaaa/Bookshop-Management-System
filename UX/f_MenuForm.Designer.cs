namespace BookShop.UX
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logoName = new System.Windows.Forms.Label();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.lbHours = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.exitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Teal;
            this.menuPanel.Controls.Add(this.button4);
            this.menuPanel.Controls.Add(this.button3);
            this.menuPanel.Controls.Add(this.button2);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Controls.Add(this.categoriesBtn);
            this.menuPanel.Controls.Add(this.logo);
            this.menuPanel.Controls.Add(this.logoName);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(215, 788);
            this.menuPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 56);
            this.button3.TabIndex = 6;
            this.button3.Tag = "1007";
            this.button3.Text = "       Add New Books";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DoOnClick);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 55);
            this.button2.TabIndex = 5;
            this.button2.Tag = "1005";
            this.button2.Text = "       Sales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DoOnClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 55);
            this.button1.TabIndex = 4;
            this.button1.Tag = "1004";
            this.button1.Text = "       Employees";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DoOnClick);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.FlatAppearance.BorderSize = 0;
            this.categoriesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoriesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesBtn.ForeColor = System.Drawing.Color.White;
            this.categoriesBtn.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBtn.Image")));
            this.categoriesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriesBtn.Location = new System.Drawing.Point(3, 178);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(216, 56);
            this.categoriesBtn.TabIndex = 2;
            this.categoriesBtn.Tag = "1006";
            this.categoriesBtn.Text = "       View Books";
            this.categoriesBtn.UseVisualStyleBackColor = true;
            this.categoriesBtn.Click += new System.EventHandler(this.DoOnClick);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(66, 19);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(101, 65);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // logoName
            // 
            this.logoName.AutoSize = true;
            this.logoName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoName.ForeColor = System.Drawing.Color.White;
            this.logoName.Location = new System.Drawing.Point(33, 87);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(166, 23);
            this.logoName.TabIndex = 2;
            this.logoName.Text = "The Rough Pages";
            // 
            // exitPanel
            // 
            this.exitPanel.BackColor = System.Drawing.Color.White;
            this.exitPanel.Controls.Add(this.lbDate);
            this.exitPanel.Controls.Add(this.logoutBtn);
            this.exitPanel.Controls.Add(this.lbHours);
            this.exitPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitPanel.Location = new System.Drawing.Point(215, 0);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(1035, 121);
            this.exitPanel.TabIndex = 1;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Teal;
            this.lbDate.Location = new System.Drawing.Point(282, 77);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(76, 33);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date";
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.Location = new System.Drawing.Point(991, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(32, 22);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.OnExitClick);
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.ForeColor = System.Drawing.Color.Teal;
            this.lbHours.Location = new System.Drawing.Point(373, 12);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(100, 42);
            this.lbHours.TabIndex = 2;
            this.lbHours.Text = "Time";
            // 
            // hours
            // 
            this.hours.Enabled = true;
            this.hours.Tick += new System.EventHandler(this.hours_Tick);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 516);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 55);
            this.button4.TabIndex = 7;
            this.button4.Tag = "1008";
            this.button4.Text = "       Transactions";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DoOnClick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 788);
            this.Controls.Add(this.exitPanel);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c_MenuForm";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.exitPanel.ResumeLayout(false);
            this.exitPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.Label logoName;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Timer hours;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}