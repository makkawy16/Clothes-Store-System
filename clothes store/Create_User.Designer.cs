
namespace clothes_store
{
    partial class Create_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_User));
            this.label3 = new System.Windows.Forms.Label();
            this.New_password = new System.Windows.Forms.TextBox();
            this.New_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RE_enter = new System.Windows.Forms.Label();
            this.Re_Enter_pass = new System.Windows.Forms.TextBox();
            this.Create_U = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Create_ADM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(551, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "At least 6 characters";
            // 
            // New_password
            // 
            this.New_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_password.Location = new System.Drawing.Point(554, 124);
            this.New_password.Name = "New_password";
            this.New_password.PasswordChar = '*';
            this.New_password.Size = new System.Drawing.Size(140, 24);
            this.New_password.TabIndex = 10;
            // 
            // New_Username
            // 
            this.New_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_Username.Location = new System.Drawing.Point(554, 82);
            this.New_Username.Name = "New_Username";
            this.New_Username.Size = new System.Drawing.Size(140, 24);
            this.New_Username.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "New UserName";
            // 
            // RE_enter
            // 
            this.RE_enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RE_enter.AutoSize = true;
            this.RE_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE_enter.Location = new System.Drawing.Point(382, 175);
            this.RE_enter.Name = "RE_enter";
            this.RE_enter.Size = new System.Drawing.Size(133, 17);
            this.RE_enter.TabIndex = 13;
            this.RE_enter.Text = "Re_Enter Password";
            // 
            // Re_Enter_pass
            // 
            this.Re_Enter_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Re_Enter_pass.Location = new System.Drawing.Point(554, 172);
            this.Re_Enter_pass.Name = "Re_Enter_pass";
            this.Re_Enter_pass.PasswordChar = '*';
            this.Re_Enter_pass.Size = new System.Drawing.Size(140, 24);
            this.Re_Enter_pass.TabIndex = 14;
            this.Re_Enter_pass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Create_U
            // 
            this.Create_U.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Create_U.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Create_U.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_U.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Create_U.Location = new System.Drawing.Point(385, 261);
            this.Create_U.Name = "Create_U";
            this.Create_U.Size = new System.Drawing.Size(122, 28);
            this.Create_U.TabIndex = 15;
            this.Create_U.Text = "Create as user";
            this.Create_U.UseVisualStyleBackColor = false;
            this.Create_U.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 382);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 16;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
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
            // Create_ADM
            // 
            this.Create_ADM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Create_ADM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Create_ADM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_ADM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Create_ADM.Location = new System.Drawing.Point(554, 261);
            this.Create_ADM.Name = "Create_ADM";
            this.Create_ADM.Size = new System.Drawing.Size(117, 28);
            this.Create_ADM.TabIndex = 17;
            this.Create_ADM.Text = "Create as Admin";
            this.Create_ADM.UseVisualStyleBackColor = false;
            this.Create_ADM.Click += new System.EventHandler(this.Create_ADM_Click);
            // 
            // Create_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Create_ADM);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Create_U);
            this.Controls.Add(this.Re_Enter_pass);
            this.Controls.Add(this.RE_enter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.New_password);
            this.Controls.Add(this.New_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Create_User";
            this.Text = "Create_User";
            this.Load += new System.EventHandler(this.Create_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox New_password;
        private System.Windows.Forms.TextBox New_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RE_enter;
        private System.Windows.Forms.TextBox Re_Enter_pass;
        private System.Windows.Forms.Button Create_U;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Create_ADM;
    }
}