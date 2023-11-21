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
    public partial class Prouducts : Form
    {
        int SerialNumber;
        Double Price;
        int Num_of_Items;
        string Item_Tybe;
        
        SqlConnection c = new SqlConnection(@"Data Source=MAKKAWY\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        SqlCommand cmd;
        public Prouducts()
        {
            InitializeComponent();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
        public void Cleardata()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Prouducts_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_product_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                c.Open();

                cmd = new SqlCommand("insert into products values ('" + textBox1.Text + "','" + textBox2.Text + "' ,'" + textBox3.Text + "' ,'" + textBox4.Text + "')", c);               
                cmd.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Item Added Succssefully","Done");
                Cleardata();

            }
            else
            {
                MessageBox.Show("Please Enter All data", "Missing Data", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void delete_product_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                c.Open();

                cmd = new SqlCommand("delete products where Serial_Number = '"+textBox1.Text+"'", c);
                cmd.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Item Deleted succsefully","Done");

            }
            else
            {
                MessageBox.Show("Please Enter The Serial you Want To Delete" , "Messing Serial Number" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome_Admin w = new Welcome_Admin();
           w.Show();
            this.Hide();
        }

        private void show_data_Click(object sender, EventArgs e)
        {
            Show_Data sd = new Show_Data();
            sd.Show();
        }
    }
}
