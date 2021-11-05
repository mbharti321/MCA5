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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void linkLblMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMenu menu = new formMenu();
            menu.Show();
            this.Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Food Added to the menu!!!!!!!!!!", "Menu Dialoge", MessageBoxButtons.OK);
        }


        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextDescription.Font;
            fontDialog1.Color = richTextDescription.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextDescription.Font = fontDialog1.Font;
                richTextDescription.ForeColor = fontDialog1.Color;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG (*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Image file = Image.FromFile(f.FileName);
                pictureNewFood.Image = file;
            }
        }
    }
}
