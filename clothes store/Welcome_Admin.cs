﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothes_store
{
    public partial class Welcome_Admin : Form
    {
        public Welcome_Admin()
        {
            InitializeComponent();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void Manage_products_Click(object sender, EventArgs e)
        {
            Prouducts p = new Prouducts();
            p.Show();
            this.Hide();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            i.Show();
            this.Hide();
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            Sale s = new Sale();
            s.Show();
            this.Hide();
        }

        private void Logut_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Change_Password_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password();
            cp.Show();
            this.Hide();
        }

        private void show_data_Click(object sender, EventArgs e)
        {
            Show_Data sd = new Show_Data();
            sd.Show();
        }

        private void create_Acc_Click(object sender, EventArgs e)
        {
            Create_User cu = new Create_User();
            cu.Show();
            this.Hide();
        }
    }
}
