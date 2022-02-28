namespace Order
{
    partial class NewItem
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
            this.rchProductDesrciption = new System.Windows.Forms.RichTextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbmaterial = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnIncrease10 = new System.Windows.Forms.Button();
            this.btnDecrement10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchProductDesrciption
            // 
            this.rchProductDesrciption.Location = new System.Drawing.Point(969, 489);
            this.rchProductDesrciption.Margin = new System.Windows.Forms.Padding(4);
            this.rchProductDesrciption.Name = "rchProductDesrciption";
            this.rchProductDesrciption.Size = new System.Drawing.Size(246, 100);
            this.rchProductDesrciption.TabIndex = 5;
            this.rchProductDesrciption.Text = "";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Sweatshirt",
            "Gömlek",
            "Ceket",
            "Kazak"});
            this.cmbType.Location = new System.Drawing.Point(969, 221);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(246, 27);
            this.cmbType.TabIndex = 1;
            // 
            // cmbmaterial
            // 
            this.cmbmaterial.FormattingEnabled = true;
            this.cmbmaterial.Items.AddRange(new object[] {
            "Pamuk",
            "Keten",
            "Kadife"});
            this.cmbmaterial.Location = new System.Drawing.Point(969, 280);
            this.cmbmaterial.Name = "cmbmaterial";
            this.cmbmaterial.Size = new System.Drawing.Size(246, 27);
            this.cmbmaterial.TabIndex = 2;
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL"});
            this.cmbSize.Location = new System.Drawing.Point(969, 338);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(246, 27);
            this.cmbSize.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(969, 610);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrement.Location = new System.Drawing.Point(1001, 401);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(54, 42);
            this.btnDecrement.TabIndex = 22;
            this.btnDecrement.Text = "--";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrease.Location = new System.Drawing.Point(1134, 401);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(54, 42);
            this.btnIncrease.TabIndex = 23;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click_1);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(1073, 401);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(55, 42);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Text = "0";
            // 
            // btnIncrease10
            // 
            this.btnIncrease10.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrease10.Location = new System.Drawing.Point(1194, 400);
            this.btnIncrease10.Name = "btnIncrease10";
            this.btnIncrease10.Size = new System.Drawing.Size(83, 42);
            this.btnIncrease10.TabIndex = 24;
            this.btnIncrease10.Text = "+10";
            this.btnIncrease10.UseVisualStyleBackColor = true;
            this.btnIncrease10.Click += new System.EventHandler(this.btnIncrease10_Click);
            // 
            // btnDecrement10
            // 
            this.btnDecrement10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecrement10.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrement10.Location = new System.Drawing.Point(912, 401);
            this.btnDecrement10.Name = "btnDecrement10";
            this.btnDecrement10.Size = new System.Drawing.Size(83, 42);
            this.btnDecrement10.TabIndex = 25;
            this.btnDecrement10.Text = "-10";
            this.btnDecrement10.UseVisualStyleBackColor = true;
            this.btnDecrement10.Click += new System.EventHandler(this.btnDecrement10_Click);
            // 
            // NewItem
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Order.Properties.Resources.addproduct;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1298, 822);
            this.Controls.Add(this.btnDecrement10);
            this.Controls.Add(this.btnIncrease10);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.cmbmaterial);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.rchProductDesrciption);
            this.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewItem";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rchProductDesrciption;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbmaterial;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnIncrease10;
        private System.Windows.Forms.Button btnDecrement10;
    }
}