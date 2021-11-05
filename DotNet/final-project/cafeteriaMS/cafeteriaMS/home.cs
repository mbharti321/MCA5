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
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLblOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formOrder order = new formOrder();
            order.Show();
            this.Hide();
        }

        private void linkLblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHome home = new formHome();
            home.Show();
            this.Hide();
        }

        private void linkLblMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMenu menu = new formMenu();
            menu.Show();
            this.Hide();
        }
    }
}
