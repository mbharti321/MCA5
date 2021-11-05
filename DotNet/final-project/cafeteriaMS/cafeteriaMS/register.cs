using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cafeteriaMS
{
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG (*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Image file = Image.FromFile(f.FileName);
                pictureBox1.Image = file;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnRegister.Visible = true;
            }
            else
            {
                btnRegister.Visible = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mbhar\Desktop\MCA\dotNetProjects\cafeteriaMS\cafeteriaMS\Database2.mdf;Integrated Security=True");
            sc.Open();
            com.Connection = sc;
            String insetrtQuery = "INSERT INTO login(username, password) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "');";
            com.CommandText = (insetrtQuery);
            com.ExecuteNonQuery();
            sc.Close();

           
            MessageBox.Show("Registration Successful!\n Please Login~~", "Login Dialoge", MessageBoxButtons.OK);
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }
    }
}
