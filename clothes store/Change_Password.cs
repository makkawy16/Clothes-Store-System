using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace clothes_store
{
    public partial class Change_Password : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=MAKKAWY\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        SqlCommand cmd;
        public Change_Password()
        {
            InitializeComponent();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void Change_Pass_Click(object sender, EventArgs e)
        {
            if (New_password.Text.Length<6)
            {
                MessageBox.Show("The Password Must Be At least 6 Crachters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (New_password.Text != Re_Enter_pass.Text)
            {
                MessageBox.Show("Wrong Re_enter Password", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {

            if (Username.Text != "" && New_password.Text != "" && RE_enter.Text != "" )
                {
                    

                        c.Open();
                        cmd = new SqlCommand("update users set pass_word = '" + New_password.Text + "' where u_Name = '" + Username.Text + "'", c);
                        cmd.ExecuteNonQuery();
                        c.Close();
                    MessageBox.Show("Password Updated successfuly");
                    Login l = new Login();
                    l.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Please Enter UserName And Password");
                }
            
            }
            
        }

        private void back_Click(object sender, EventArgs e)
        {
             this.Hide();
           Welcome_Admin w = new Welcome_Admin();
           w.Show();
        }
    }
}
