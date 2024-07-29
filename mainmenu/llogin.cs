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

namespace LOGIIN
{
    public partial class llogin : Form
    {
        public llogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3ST950F;Initial Catalog=LoogIInDb;Integrated Security=True");
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if(Username.Text != "" && Password.Text != "")
            {
                string query = "select count(*) from SignUp where email ='" + Username.Text + "' and + password ='"+Password.Text+"'";
                conn.Open();
                SqlCommand command = new SqlCommand(query,conn);
                int v = (int)command.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("Error username or Password");
                }
                else
                {
                    MessageBox.Show("Welcome");
                    Username.Text = "";
                    Password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fill in missing Information!!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
                this.Hide();
           form1.Show();
        }
    }
}
