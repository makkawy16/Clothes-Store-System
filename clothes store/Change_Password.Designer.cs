
namespace clothes_store
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Change_Pass = new System.Windows.Forms.Button();
            this.Re_Enter_pass = new System.Windows.Forms.TextBox();
            this.RE_enter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.New_password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // Change_Pass
            // 
            this.Change_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Change_Pass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Change_Pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change_Pass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Change_Pass.Location = new System.Drawing.Point(524, 261);
            this.Change_Pass.Name = "Change_Pass";
            this.Change_Pass.Size = new System.Drawing.Size(81, 28);
            this.Change_Pass.TabIndex = 23;
            this.Change_Pass.Text = "Change";
            this.Change_Pass.UseVisualStyleBackColor = false;
            this.Change_Pass.Click += new System.EventHandler(this.Change_Pass_Click);
            // 
            // Re_Enter_pass
            // 
            this.Re_Enter_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Re_Enter_pass.Location = new System.Drawing.Point(564, 173);
            this.Re_Enter_pass.Name = "Re_Enter_pass";
            this.Re_Enter_pass.PasswordChar = '*';
            this.Re_Enter_pass.Size = new System.Drawing.Size(140, 24);
            this.Re_Enter_pass.TabIndex = 22;
            // 
            // RE_enter
            // 
            this.RE_enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RE_enter.AutoSize = true;
            this.RE_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE_enter.Location = new System.Drawing.Point(392, 176);
            this.RE_enter.Name = "RE_enter";
            this.RE_enter.Size = new System.Drawing.Size(133, 17);
            this.RE_enter.TabIndex = 21;
            this.RE_enter.Text = "Re_Enter Password";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(561, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "At least 6 characters";
            // 
            // New_password
            // 
            this.New_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_password.Location = new System.Drawing.Point(564, 125);
            this.New_password.Name = "New_password";
            this.New_password.PasswordChar = '*';
            this.New_password.Size = new System.Drawing.Size(140, 24);
            this.New_password.TabIndex = 19;
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username.Location = new System.Drawing.Point(564, 83);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(140, 24);
            this.Username.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "New UserName";
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 385);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 24;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Change_Pass);
            this.Controls.Add(this.Re_Enter_pass);
            this.Controls.Add(this.RE_enter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.New_password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Change_Pass;
        private System.Windows.Forms.TextBox Re_Enter_pass;
        private System.Windows.Forms.Label RE_enter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox New_password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}