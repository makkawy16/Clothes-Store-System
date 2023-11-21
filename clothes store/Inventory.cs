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

    public partial class Inventory : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=MAKKAWY\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        SqlCommand cmd;
        public Inventory()
        {
            InitializeComponent();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void Change__Price_Click(object sender, EventArgs e)
        {
            if (Serial.Text != "" )
            {
                c.Open();

                cmd = new SqlCommand("update products set Price = '"+New_price.Text+"' where Serial_Number = '"+Serial.Text+"'", c);
                cmd.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Price Updated Succsesfully");
                New_price.Text = "New Price";

            }
        }

        private void Update__number_Click(object sender, EventArgs e)
        {
            if (Serial.Text != "")
            {
                c.Open();
                cmd = new SqlCommand("update products set Number_of_items = '" + New_Number.Text + "' where Serial_Number = '" + Serial.Text + "';", c);
                cmd.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Number Updated Succssefully");
                New_Number.Text = " Item's Number";

            }
        }

        private void back_Click(object sender, EventArgs e)
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

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
