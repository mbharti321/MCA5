using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeteriaMS
{
    public partial class formOrder : Form
    {
        public formOrder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHome home = new formHome();
            home.Show();
            this.Hide();
        }

        private void linkLblOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formOrder order = new formOrder();
            order.Show();
            this.Hide();
        }

        private void linkLblMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMenu menu = new formMenu();
            menu.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order placed Succefully!!!!!!!!!!", "Order Dialoge", MessageBoxButtons.OK);
        }
    }
}
