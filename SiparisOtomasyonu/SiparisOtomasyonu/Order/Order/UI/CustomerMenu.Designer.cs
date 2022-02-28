namespace Order.UI
{
    partial class CustomerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bilgilerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifSiparişlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişSiparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Corbel Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgilerimToolStripMenuItem,
            this.sepetimToolStripMenuItem,
            this.aktifSiparişlerimToolStripMenuItem,
            this.geçmişSiparişlerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1298, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bilgilerimToolStripMenuItem
            // 
            this.bilgilerimToolStripMenuItem.Name = "bilgilerimToolStripMenuItem";
            this.bilgilerimToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.bilgilerimToolStripMenuItem.Text = "New Order";
            this.bilgilerimToolStripMenuItem.Click += new System.EventHandler(this.bilgilerimToolStripMenuItem_Click);
            // 
            // sepetimToolStripMenuItem
            // 
            this.sepetimToolStripMenuItem.Name = "sepetimToolStripMenuItem";
            this.sepetimToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.sepetimToolStripMenuItem.Text = "My Basket";
            this.sepetimToolStripMenuItem.Click += new System.EventHandler(this.sepetimToolStripMenuItem_Click);
            // 
            // aktifSiparişlerimToolStripMenuItem
            // 
            this.aktifSiparişlerimToolStripMenuItem.Name = "aktifSiparişlerimToolStripMenuItem";
            this.aktifSiparişlerimToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.aktifSiparişlerimToolStripMenuItem.Text = "Active Orders";
            this.aktifSiparişlerimToolStripMenuItem.Click += new System.EventHandler(this.aktifSiparişlerimToolStripMenuItem_Click_1);
            // 
            // geçmişSiparişlerToolStripMenuItem
            // 
            this.geçmişSiparişlerToolStripMenuItem.Name = "geçmişSiparişlerToolStripMenuItem";
            this.geçmişSiparişlerToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.geçmişSiparişlerToolStripMenuItem.Text = "Past Orders";
            this.geçmişSiparişlerToolStripMenuItem.Click += new System.EventHandler(this.geçmişSiparişlerToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(50, 27);
            this.çıkışToolStripMenuItem.Text = "Exit";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 822);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bilgilerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktifSiparişlerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geçmişSiparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepetimToolStripMenuItem;
    }
}