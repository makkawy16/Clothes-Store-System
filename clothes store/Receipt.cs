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
using System.Drawing.Printing;

namespace clothes_store
{
  
    public partial class Receipt : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=MAKKAWY\SQLEXPRESS;Initial Catalog=store;Integrated Security=True");
        SqlCommand cmd , cmd1;
        SqlDataAdapter ad;
        DataTable dt = new DataTable();

        PrintPreviewDialog ppd = new PrintPreviewDialog();
        PrintDocument prd = new PrintDocument();

        private void displaydata()
        {
            c.Open();
            ad = new SqlDataAdapter("select * from receipt", c);
            ad.Fill(dt);
            sold_Items.DataSource = dt;
            c.Close();

        }

        public Receipt()
        {
            InitializeComponent();
            
        }
        private void calculate_Total()
        {
            Total_Price.Text = "0";
            for (int i = 0; i < sold_Items.Rows.Count; i++)
            {
                Total_Price.Text = Convert.ToString(float.Parse(Total_Price.Text) + float.Parse(sold_Items.Rows[i].Cells[1].Value.ToString()));
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.storeDataSet.receipt);
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
            displaydata();
            calculate_Total();
        }
        //Bitmap bmp;
        private void Print_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new SqlCommand("delete  from receipt", c);
            cmd.ExecuteNonQuery();
            c.Close();
            Sale s = new Sale();
            s.Show();
            this.Hide();

            //Graphics g= this.CreateGraphics();
            //bmp
            //= new Bitmap(this.Size.Width, this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();

            print(this.panel1);

        }
        public void print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            ppd.Document = prd;
            prd.PrintPage += new PrintPageEventHandler(prd_printpage);
            ppd.ShowDialog();
        }
        public void prd_printpage(object sender , PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(bmp, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);

        }
        Bitmap bmp;
        public void getprintarea(Panel pnl)
        {
            bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void back_Click(object sender, EventArgs e)
        {
            Sale s = new Sale();
            s.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          //  e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            c.Open();
            cmd = new SqlCommand("delete  from receipt where Seria_no = '"+Delete_Serial.Text+"' ", c);
            cmd1 = new SqlCommand("update products set Number_of_items = Number_of_items + 1 where Serial_Number = '"+Delete_Serial.Text+"'", c);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            c.Close();
            dt.Rows.Clear();
            displaydata();
            calculate_Total();
        }

        
    }
}
