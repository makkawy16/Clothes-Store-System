
namespace clothes_store
{
    partial class Show_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Data));
            this.My_items = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.My_items)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // My_items
            // 
            this.My_items.AllowUserToAddRows = false;
            this.My_items.AllowUserToDeleteRows = false;
            this.My_items.AllowUserToOrderColumns = true;
            this.My_items.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.My_items.ColumnHeadersHeight = 24;
            this.My_items.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.My_items.Location = new System.Drawing.Point(-1, -1);
            this.My_items.Name = "My_items";
            this.My_items.ReadOnly = true;
            this.My_items.RowHeadersWidth = 25;
            this.My_items.RowTemplate.Height = 26;
            this.My_items.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.My_items.Size = new System.Drawing.Size(483, 421);
            this.My_items.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.back);
            this.panel1.Location = new System.Drawing.Point(-1, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 27);
            this.panel1.TabIndex = 1;
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(1, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "Close";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Show_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.My_items);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Show_Data";
            this.Text = "Show_Data";
            this.Load += new System.EventHandler(this.Show_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.My_items)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView My_items;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}