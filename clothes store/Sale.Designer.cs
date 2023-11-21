
namespace clothes_store
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Serial_in_sale = new System.Windows.Forms.Label();
            this.Serial = new System.Windows.Forms.TextBox();
            this.Add_item = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.DataGridView();
            this.Total_Price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Finish = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Items)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Serial_in_sale
            // 
            this.Serial_in_sale.BackColor = System.Drawing.Color.Linen;
            this.Serial_in_sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Serial_in_sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Serial_in_sale.Location = new System.Drawing.Point(12, 9);
            this.Serial_in_sale.Name = "Serial_in_sale";
            this.Serial_in_sale.Size = new System.Drawing.Size(98, 23);
            this.Serial_in_sale.TabIndex = 1;
            this.Serial_in_sale.Text = "Serial Number";
            this.Serial_in_sale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Serial
            // 
            this.Serial.Location = new System.Drawing.Point(138, 8);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(105, 24);
            this.Serial.TabIndex = 2;
            // 
            // Add_item
            // 
            this.Add_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_item.Location = new System.Drawing.Point(84, 59);
            this.Add_item.Name = "Add_item";
            this.Add_item.Size = new System.Drawing.Size(75, 23);
            this.Add_item.TabIndex = 3;
            this.Add_item.Text = "Add";
            this.Add_item.UseVisualStyleBackColor = true;
            this.Add_item.Click += new System.EventHandler(this.Add_item_Click);
            // 
            // Items
            // 
            this.Items.AllowUserToAddRows = false;
            this.Items.AllowUserToOrderColumns = true;
            this.Items.AllowUserToResizeColumns = false;
            this.Items.AllowUserToResizeRows = false;
            this.Items.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Items.BackgroundColor = System.Drawing.Color.Linen;
            this.Items.ColumnHeadersHeight = 20;
            this.Items.Cursor = System.Windows.Forms.Cursors.Default;
            this.Items.Location = new System.Drawing.Point(395, 9);
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.RowHeadersWidth = 30;
            this.Items.RowTemplate.Height = 26;
            this.Items.Size = new System.Drawing.Size(393, 231);
            this.Items.TabIndex = 4;
            // 
            // Total_Price
            // 
            this.Total_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Total_Price.BackColor = System.Drawing.Color.Linen;
            this.Total_Price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Total_Price.Location = new System.Drawing.Point(617, 254);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(93, 28);
            this.Total_Price.TabIndex = 5;
            this.Total_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Finish
            // 
            this.Finish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Finish.BackColor = System.Drawing.Color.Linen;
            this.Finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish.Location = new System.Drawing.Point(691, 405);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(97, 33);
            this.Finish.TabIndex = 7;
            this.Finish.Text = "Print Receipt";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // back
            // 
            this.back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back.BackColor = System.Drawing.Color.Linen;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(310, 405);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(88, 33);
            this.back.TabIndex = 8;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total_Price);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.Add_item);
            this.Controls.Add(this.Serial);
            this.Controls.Add(this.Serial_in_sale);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Serial_in_sale;
        private System.Windows.Forms.TextBox Serial;
        private System.Windows.Forms.Button Add_item;
        private System.Windows.Forms.DataGridView Items;
        private System.Windows.Forms.Label Total_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button back;
    }
}