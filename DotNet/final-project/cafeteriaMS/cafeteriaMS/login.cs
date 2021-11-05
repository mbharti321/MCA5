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
    public partial class formLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mbhar\Desktop\MCA\dotNetProjects\cafeteriaMS\cafeteriaMS\Database2.mdf;Integrated Security=True");
        public formLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

            //a = Convert.ToInt32(num1.Text);
            //b = Convert.ToInt32(num2.Text);
            String userName, password;
            userName = txtUsername.Text;
            password = txtPassword.Text;
            if (userName == "manish" && password == "password")
            {
                MessageBox.Show("Login Successful!", "Login Dialoge", MessageBoxButtons.OK);
                formHome home = new formHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credential!!\nTry again!!!!!!!!!!", "Login Dialoge", MessageBoxButtons.OK);
            }

           /*  */
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userNameInput, passwordInput, password = "";
            userNameInput = txtUsername.Text;
            passwordInput = txtPassword.Text;

            con.Open();
            SqlCommand loginQuery = new SqlCommand("Select * From login where username = " + userNameInput + " ", con);


            SqlDataReader dataReader = loginQuery.ExecuteReader();
            while (dataReader.Read())
            {
                password = dataReader.GetValue(1).ToString();
            }
            if (passwordInput == password)
            {
                MessageBox.Show("Login Successful!", "Login Dialoge", MessageBoxButtons.OK);
                formHome home = new formHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credential!!\nTry again!!!!!!!!!!", "Login Dialoge", MessageBoxButtons.OK);
            }
            con.Close();
        }
    

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            formRegister register = new formRegister();
            register.Show();
            this.Hide();
        }
    }
}
