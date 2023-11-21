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
    public partial class Create_User : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=MAKKAWY\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        SqlCommand cmd;
        public Create_User()
        {
            InitializeComponent();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (New_password.Text.Length < 6)
            {
                MessageBox.Show("The Password Must Be At least 6 Crachters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (Re_Enter_pass.Text == New_password.Text && New_Username.Text != "")
                {
                    c.Open();
                    cmd = new SqlCommand("insert into users values ('" + New_Username.Text + "','" + New_password.Text + "')", c);
                    cmd.ExecuteNonQuery();
                    c.Close();
                    MessageBox.Show("Data added successfuly");
                    Login l = new Login();
                    l.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Re_enter password!", "Error" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Re_Enter_pass.Text = "";
                }
            }
        }

        private void Create_User_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_Admin w = new Welcome_Admin();
            w.Show();
        }

        private void Create_ADM_Click(object sender, EventArgs e)
        {
            if (New_password.Text.Length < 6)
            {
                MessageBox.Show("The Password Must Be At least 6 Crachters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (Re_Enter_pass.Text == New_password.Text && New_Username.Text != "")
                {
                    c.Open();
                    cmd = new SqlCommand("insert into admin values ('" + New_Username.Text + "','" + New_password.Text + "')", c);
                    cmd.ExecuteNonQuery();
                    c.Close();
                    MessageBox.Show("Data added successfuly");
                    Login l = new Login();
                    l.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Re_enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Re_Enter_pass.Text = "";
                }
            }
        }
    }
}
