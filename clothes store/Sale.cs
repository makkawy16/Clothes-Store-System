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
    public partial class Sale : Form
    {

        SqlConnection c = new SqlConnection(@"Data Source=MAKKAWY\SQLEXPRESS;Initial Catalog=Store;Integrated Security=True");
        SqlDataAdapter ad  ;
        DataTable dt = new DataTable();
        
        SqlCommand cmd , cmd1;

        public Sale()
        {
            InitializeComponent();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
        private void displadata()
        {
            c.Open();
            ad = new SqlDataAdapter("select Serial_Number , Price , Number_of_items from products where Serial_Number = '" + Serial.Text+"';", c);
            ad.Fill(dt);
            Items.DataSource = dt;
            c.Close();

        }
        private void calculate_Total()
        {
            Total_Price.Text = "0";
            for (int i = 0; i < Items.Rows.Count; i++)
            {
                Total_Price.Text = Convert.ToString(float.Parse(Total_Price.Text) + float.Parse(Items.Rows[i].Cells[1].Value.ToString()));
            }
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_item_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new SqlCommand("update products set Number_of_items = Number_of_items - 1 where Serial_Number = '" + Serial.Text + "'", c);
            cmd1 = new SqlCommand("insert into receipt select Serial_Number , Price , Item_Type from products where Serial_Number = '"+Serial.Text+"'", c);
            cmd1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            c.Close();
            displadata();

            calculate_Total();
           
            Serial.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        { 
            Welcome_to_Store w = new Welcome_to_Store();
            w.Show();
            //Welcome_Admin w = new Welcome_Admin();
            //w.Show();
            this.Hide();
        }

        private void Sale_Load(object sender, EventArgs e)
        {

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            Receipt r = new Receipt();
            r.Show();
            this.Hide();
        }
    }
}
