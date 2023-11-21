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
    public partial class Show_Data : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=MAKKAWY\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter ad;
        DataTable dt = new DataTable();
        public Show_Data()
        {
            InitializeComponent();
           
        }
        private void displaydata()
        {
            c.Open();
            ad = new SqlDataAdapter("select * from products", c);
            ad.Fill(dt);
            My_items.DataSource = dt;
            c.Close();

        }

        private void Show_Data_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
