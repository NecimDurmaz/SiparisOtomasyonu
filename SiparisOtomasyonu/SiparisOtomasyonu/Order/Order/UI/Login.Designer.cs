namespace Order
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.radioCustomer = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.lnkSign = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Red;
            this.lblLogin.Location = new System.Drawing.Point(78, 25);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(222, 93);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "        LOGIN\r\n--------------------------\r\n\r\n";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(69, 237);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(242, 33);
            this.txtID.TabIndex = 3;
            // 
            // radioCustomer
            // 
            this.radioCustomer.AutoSize = true;
            this.radioCustomer.BackColor = System.Drawing.Color.Transparent;
            this.radioCustomer.ForeColor = System.Drawing.Color.White;
            this.radioCustomer.Location = new System.Drawing.Point(63, 137);
            this.radioCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.radioCustomer.Name = "radioCustomer";
            this.radioCustomer.Size = new System.Drawing.Size(118, 30);
            this.radioCustomer.TabIndex = 1;
            this.radioCustomer.TabStop = true;
            this.radioCustomer.Text = "Customer";
            this.radioCustomer.UseVisualStyleBackColor = false;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radioAdmin.ForeColor = System.Drawing.Color.White;
            this.radioAdmin.Location = new System.Drawing.Point(231, 137);
            this.radioAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(91, 30);
            this.radioAdmin.TabIndex = 2;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = false;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.Window;
            this.txtSifre.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(69, 325);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(242, 33);
            this.txtSifre.TabIndex = 4;
            // 
            // bttnExit
            // 
            this.bttnExit.BackgroundImage = global::Order.Properties.Resources.exit;
            this.bttnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnExit.FlatAppearance.BorderSize = 0;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnExit.Location = new System.Drawing.Point(20, 424);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(115, 65);
            this.bttnExit.TabIndex = 8;
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnLogin
            // 
            this.bttnLogin.BackColor = System.Drawing.Color.Transparent;
            this.bttnLogin.BackgroundImage = global::Order.Properties.Resources.loginb;
            this.bttnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnLogin.FlatAppearance.BorderSize = 0;
            this.bttnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnLogin.Location = new System.Drawing.Point(160, 424);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(231, 65);
            this.bttnLogin.TabIndex = 5;
            this.bttnLogin.UseVisualStyleBackColor = false;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // lnkSign
            // 
            this.lnkSign.AutoSize = true;
            this.lnkSign.BackColor = System.Drawing.Color.Transparent;
            this.lnkSign.Font = new System.Drawing.Font("Cooper Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSign.LinkColor = System.Drawing.Color.Yellow;
            this.lnkSign.Location = new System.Drawing.Point(341, 689);
            this.lnkSign.Name = "lnkSign";
            this.lnkSign.Size = new System.Drawing.Size(112, 31);
            this.lnkSign.TabIndex = 9;
            this.lnkSign.TabStop = true;
            this.lnkSign.Text = "Sign In";
            this.lnkSign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.radioCustomer);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.radioAdmin);
            this.panel1.Controls.Add(this.bttnLogin);
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Location = new System.Drawing.Point(26, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 551);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // Login
            // 
            this.AcceptButton = this.bttnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Order.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bttnExit;
            this.ClientSize = new System.Drawing.Size(465, 813);
            this.Controls.Add(this.lnkSign);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RadioButton radioCustomer;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.LinkLabel lnkSign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

