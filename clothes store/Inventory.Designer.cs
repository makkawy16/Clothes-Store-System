
namespace clothes_store
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Serial = new System.Windows.Forms.TextBox();
            this.New_price = new System.Windows.Forms.TextBox();
            this.New_Number = new System.Windows.Forms.TextBox();
            this.Change__Price = new System.Windows.Forms.Button();
            this.Update__number = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.show_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(50, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "serial Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Serial
            // 
            this.Serial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Serial.Location = new System.Drawing.Point(198, 36);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(118, 24);
            this.Serial.TabIndex = 4;
            // 
            // New_price
            // 
            this.New_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_price.Location = new System.Drawing.Point(216, 91);
            this.New_price.Name = "New_price";
            this.New_price.Size = new System.Drawing.Size(117, 24);
            this.New_price.TabIndex = 5;
            this.New_price.Tag = "";
            this.New_price.Text = "New Price";
            // 
            // New_Number
            // 
            this.New_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_Number.ForeColor = System.Drawing.SystemColors.MenuText;
            this.New_Number.Location = new System.Drawing.Point(356, 91);
            this.New_Number.Name = "New_Number";
            this.New_Number.Size = new System.Drawing.Size(116, 24);
            this.New_Number.TabIndex = 6;
            this.New_Number.Text = " Item\'s Number\r\n";
            // 
            // Change__Price
            // 
            this.Change__Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Change__Price.BackColor = System.Drawing.Color.Tan;
            this.Change__Price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change__Price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Change__Price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Change__Price.Location = new System.Drawing.Point(216, 129);
            this.Change__Price.Name = "Change__Price";
            this.Change__Price.Size = new System.Drawing.Size(117, 27);
            this.Change__Price.TabIndex = 7;
            this.Change__Price.Text = "Change Price";
            this.Change__Price.UseVisualStyleBackColor = false;
            this.Change__Price.Click += new System.EventHandler(this.Change__Price_Click);
            // 
            // Update__number
            // 
            this.Update__number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update__number.BackColor = System.Drawing.Color.Tan;
            this.Update__number.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update__number.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update__number.Location = new System.Drawing.Point(356, 129);
            this.Update__number.Name = "Update__number";
            this.Update__number.Size = new System.Drawing.Size(116, 27);
            this.Update__number.TabIndex = 8;
            this.Update__number.Text = "Update Number";
            this.Update__number.UseVisualStyleBackColor = false;
            this.Update__number.Click += new System.EventHandler(this.Update__number_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.BackColor = System.Drawing.SystemColors.Control;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 372);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 9;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // show_data
            // 
            this.show_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.show_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_data.Location = new System.Drawing.Point(670, 372);
            this.show_data.Name = "show_data";
            this.show_data.Size = new System.Drawing.Size(97, 23);
            this.show_data.TabIndex = 10;
            this.show_data.Text = "Show Data";
            this.show_data.UseVisualStyleBackColor = true;
            this.show_data.Click += new System.EventHandler(this.show_data_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.show_data);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Update__number);
            this.Controls.Add(this.Change__Price);
            this.Controls.Add(this.New_Number);
            this.Controls.Add(this.New_price);
            this.Controls.Add(this.Serial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.Text = "inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Serial;
        private System.Windows.Forms.TextBox New_price;
        private System.Windows.Forms.TextBox New_Number;
        private System.Windows.Forms.Button Change__Price;
        private System.Windows.Forms.Button Update__number;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button show_data;
    }
}