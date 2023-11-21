
namespace clothes_store
{
    partial class Receipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.sold_Items = new System.Windows.Forms.DataGridView();
            this.serianoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new clothes_store.storeDataSet();
            this.receiptTableAdapter = new clothes_store.storeDataSetTableAdapters.receiptTableAdapter();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Total_Price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delete_Serial = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sold_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sold_Items
            // 
            this.sold_Items.AllowUserToAddRows = false;
            this.sold_Items.AllowUserToOrderColumns = true;
            this.sold_Items.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sold_Items.AutoGenerateColumns = false;
            this.sold_Items.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sold_Items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sold_Items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.sold_Items.ColumnHeadersHeight = 25;
            this.sold_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serianoDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.itemtypeDataGridViewTextBoxColumn});
            this.sold_Items.DataSource = this.receiptBindingSource;
            this.sold_Items.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sold_Items.Location = new System.Drawing.Point(3, 160);
            this.sold_Items.Name = "sold_Items";
            this.sold_Items.ReadOnly = true;
            this.sold_Items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sold_Items.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sold_Items.RowHeadersWidth = 22;
            this.sold_Items.RowTemplate.Height = 26;
            this.sold_Items.Size = new System.Drawing.Size(384, 261);
            this.sold_Items.TabIndex = 0;
            // 
            // serianoDataGridViewTextBoxColumn
            // 
            this.serianoDataGridViewTextBoxColumn.DataPropertyName = "Seria_no";
            this.serianoDataGridViewTextBoxColumn.HeaderText = "Seria_no";
            this.serianoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serianoDataGridViewTextBoxColumn.Name = "serianoDataGridViewTextBoxColumn";
            this.serianoDataGridViewTextBoxColumn.ReadOnly = true;
            this.serianoDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // itemtypeDataGridViewTextBoxColumn
            // 
            this.itemtypeDataGridViewTextBoxColumn.DataPropertyName = "item_type";
            this.itemtypeDataGridViewTextBoxColumn.HeaderText = "item_type";
            this.itemtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemtypeDataGridViewTextBoxColumn.Name = "itemtypeDataGridViewTextBoxColumn";
            this.itemtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemtypeDataGridViewTextBoxColumn.Width = 70;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "receipt";
            this.receiptBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(46, 45);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(40, 17);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date";
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(46, 13);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(41, 17);
            this.Time.TabIndex = 2;
            this.Time.Text = "Time";
            // 
            // Print
            // 
            this.Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Print.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Print.Location = new System.Drawing.Point(624, 483);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(94, 30);
            this.Print.TabIndex = 3;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 483);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 30);
            this.back.TabIndex = 4;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Price";
            // 
            // Total_Price
            // 
            this.Total_Price.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Total_Price.AutoSize = true;
            this.Total_Price.Location = new System.Drawing.Point(176, 458);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(0, 17);
            this.Total_Price.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.Total_Price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.sold_Items);
            this.panel1.Location = new System.Drawing.Point(158, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 521);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 545);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Delete_Serial
            // 
            this.Delete_Serial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_Serial.Location = new System.Drawing.Point(594, 34);
            this.Delete_Serial.Name = "Delete_Serial";
            this.Delete_Serial.Size = new System.Drawing.Size(100, 24);
            this.Delete_Serial.TabIndex = 9;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Location = new System.Drawing.Point(604, 64);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(730, 545);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Delete_Serial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sold_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sold_Items;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private storeDataSetTableAdapters.receiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serianoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total_Price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Delete_Serial;
        private System.Windows.Forms.Button Delete;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}