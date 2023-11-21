
namespace clothes_store
{
    partial class Welcome_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Admin));
            this.Change_Password = new System.Windows.Forms.Button();
            this.show_data = new System.Windows.Forms.Button();
            this.Logut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Inventory = new System.Windows.Forms.Button();
            this.Sale = new System.Windows.Forms.Button();
            this.Manage_products = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.create_Acc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Change_Password
            // 
            this.Change_Password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Change_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change_Password.Location = new System.Drawing.Point(395, 378);
            this.Change_Password.Name = "Change_Password";
            this.Change_Password.Size = new System.Drawing.Size(130, 30);
            this.Change_Password.TabIndex = 9;
            this.Change_Password.Text = "Change Password";
            this.Change_Password.UseVisualStyleBackColor = true;
            this.Change_Password.Click += new System.EventHandler(this.Change_Password_Click);
            // 
            // show_data
            // 
            this.show_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.show_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_data.Location = new System.Drawing.Point(690, 385);
            this.show_data.Name = "show_data";
            this.show_data.Size = new System.Drawing.Size(97, 23);
            this.show_data.TabIndex = 8;
            this.show_data.Text = "Show Data";
            this.show_data.UseVisualStyleBackColor = true;
            this.show_data.Click += new System.EventHandler(this.show_data_Click);
            // 
            // Logut
            // 
            this.Logut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logut.Location = new System.Drawing.Point(10, 385);
            this.Logut.Name = "Logut";
            this.Logut.Size = new System.Drawing.Size(75, 23);
            this.Logut.TabIndex = 7;
            this.Logut.Text = "Logut";
            this.Logut.UseVisualStyleBackColor = true;
            this.Logut.Click += new System.EventHandler(this.Logut_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Inventory);
            this.panel1.Controls.Add(this.Sale);
            this.panel1.Controls.Add(this.Manage_products);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 6;
            // 
            // Inventory
            // 
            this.Inventory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventory.Location = new System.Drawing.Point(363, 7);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(81, 26);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = true;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // Sale
            // 
            this.Sale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sale.Location = new System.Drawing.Point(529, 7);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(75, 23);
            this.Sale.TabIndex = 0;
            this.Sale.Text = "Sale";
            this.Sale.UseVisualStyleBackColor = true;
            this.Sale.Click += new System.EventHandler(this.Sale_Click);
            // 
            // Manage_products
            // 
            this.Manage_products.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Manage_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Manage_products.Location = new System.Drawing.Point(152, 7);
            this.Manage_products.Name = "Manage_products";
            this.Manage_products.Size = new System.Drawing.Size(128, 23);
            this.Manage_products.TabIndex = 0;
            this.Manage_products.Text = "Mange Products";
            this.Manage_products.UseVisualStyleBackColor = true;
            this.Manage_products.Click += new System.EventHandler(this.Manage_products_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::clothes_store.Properties.Resources._109074631;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // create_Acc
            // 
            this.create_Acc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.create_Acc.BackColor = System.Drawing.SystemColors.Control;
            this.create_Acc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_Acc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.create_Acc.Location = new System.Drawing.Point(255, 378);
            this.create_Acc.Name = "create_Acc";
            this.create_Acc.Size = new System.Drawing.Size(111, 30);
            this.create_Acc.TabIndex = 10;
            this.create_Acc.Text = "Create Account";
            this.create_Acc.UseVisualStyleBackColor = false;
            this.create_Acc.Click += new System.EventHandler(this.create_Acc_Click);
            // 
            // Welcome_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_Acc);
            this.Controls.Add(this.Change_Password);
            this.Controls.Add(this.show_data);
            this.Controls.Add(this.Logut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome_Admin";
            this.Text = "Welcome_Admin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Change_Password;
        private System.Windows.Forms.Button show_data;
        private System.Windows.Forms.Button Logut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button Sale;
        private System.Windows.Forms.Button Manage_products;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button create_Acc;
    }
}