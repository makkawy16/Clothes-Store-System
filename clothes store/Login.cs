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
using System.Data.Sql;
using System.Data.SqlTypes;


namespace clothes_store
{
    public partial class Login : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=MAKKAWY\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");

        SqlCommand cmd ,cmd1;



        public string username;
        public string password;
        private void ClearData()
        {
            name.Text = "";
            passcode.Text = "";
            
        }
        //public void check_adm_pass()
        //{
        //    cmd1 = new SqlCommand("select * from admin where ad_name = '" + name.Text + "' and ad_pass = '" + passcode.Text + "'", c);
        //    SqlParameter adm_us;
        //    adm_us = new SqlParameter("@ad_name", this.name.Text);
        //    SqlParameter adm_pass;
        //    adm_pass = new SqlParameter("@ad_pass", this.passcode.Text);
        //    cmd1.Parameters.Add(adm_us);
        //    cmd1.Parameters.Add(adm_pass);
        //    cmd1.Connection.Open();
        //    SqlDataReader dr1 = cmd1.ExecuteReader();
        //    if(dr1.HasRows)
        //        MessageBox.Show("valid");
        //    cmd1.Connection.Close();
        //}
        public void check_Password()
        {
            c.Open();
            cmd1 = new SqlCommand("select * from admin where ad_name = '" + name.Text + "' and ad_pass = '" + passcode.Text + "'", c);
            
            SqlParameter adm_us;
            adm_us = new SqlParameter("@ad_name", this.name.Text);
            SqlParameter adm_pass;
            adm_pass = new SqlParameter("@ad_pass", this.passcode.Text);
            cmd1.Parameters.Add(adm_us);
            cmd1.Parameters.Add(adm_pass);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.HasRows)
            {
                Welcome_Admin wa = new Welcome_Admin();
                wa.Show();
                //MessageBox.Show("valid");
                //w.Show();
               
                this.Hide();
            }
           
            else 
            {
                c.Close();
                //select username and password from table users
                 cmd = new SqlCommand("select * from users where u_Name = '" + name.Text + "' and pass_word = '" + passcode.Text + "'", c);
            
                 SqlParameter us  ;
            
                 us = new SqlParameter("@u_Name", this.name.Text);
            
                 SqlParameter pass  ;
                 pass = new SqlParameter("@pass_word", this.passcode.Text);
                
          
                 cmd.Parameters.Add(us);
                 cmd.Parameters.Add(pass);
                c.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                    Welcome_to_Store w = new Welcome_to_Store();
                    w.Show();
                        //MessageBox.Show("valid");
                         this.Hide();

                     }
                 else if (name.Text == "" && passcode.Text=="")
                 {
                      MessageBox.Show("Please Enter UserName & Password", "Missing UserName And Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                 }
                else if (name.Text == "" )
                 {
                      MessageBox.Show("Please Enter UserName", "Missing UserName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 else if (passcode.Text == "")
                 {
                     MessageBox.Show("Please Enter Password", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                   else  
                   {
                        MessageBox.Show(" Please Enter Correct UserName And Password", "Inalid Login" ,MessageBoxButtons.OK ,MessageBoxIcon.Error );
                   }
            }
            c.Close();

        }

        public Login()
        {
            InitializeComponent();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   check_adm_pass();
            check_Password();
           


           
        }

        //private void create_user_Click(object sender, EventArgs e)
        //{
        //    Create_User cu = new Create_User();
        //    cu.Show();
        //    this.Hide();
        //}
    }
}
