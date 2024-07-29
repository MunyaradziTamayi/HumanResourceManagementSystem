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
namespace LOGIIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3ST950F;Initial Catalog=LoogIInDb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fname.Text == "" || Lname.Text == "" || Email.Text == "" || Role.Text == "" ||Password.Text == "" || CPassword.Text== "" ||ID.Text == "" )
                {
                    MessageBox.Show("Misssing Information");
                }
                if (Fname.Text != "" && Lname.Text != "" && Email.Text != "" && Role.Text != "" && Password.Text != "" && CPassword.Text != "" && ID.Text != "")
                {
                    if (Password.Text == CPassword.Text)
                    {
                        int v = check(Email.Text);
                        if (v != 1)
                        {
                            conn.Open();
                            SqlCommand command = new SqlCommand("insert into SignUp values (@ID,@FName,@LName,@Email,@Role,@Password)", conn);
                            command.Parameters.AddWithValue("@ID", ID.Text);
                            command.Parameters.AddWithValue("@FName", Fname.Text);
                            command.Parameters.AddWithValue("@LName", Lname.Text);
                            command.Parameters.AddWithValue("@Email", Email.Text);
                            command.Parameters.AddWithValue("@Role", Role.Text);
                            command.Parameters.AddWithValue("@Password", Password.Text);
                            
                            command.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("SignUp Successful");
                            ID.Text = "";
                            Fname.Text = "";
                            Lname.Text = "";
                            Email.Text = "";
                            Role.Text = "";
                            Password.Text = "";
                           CPassword.Text = "";
                            this.Hide();
                            llogin llogin = new llogin();
                            llogin.Show();
                        }
                        else
                        {
                            MessageBox.Show("You are already registered!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the blanks");
                }
              
                

        

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        int check(string email)
        {
            conn.Open();
            string query = "select count(*) from SignUp where email = '"+email+"'";
            SqlCommand command= new SqlCommand(query, conn);
            int v = (int)command.ExecuteScalar();
            conn.Close();
            return v;

        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpass.Checked)
            {
                Password.UseSystemPasswordChar = false;
                CPassword.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
                CPassword.UseSystemPasswordChar = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            llogin llogin = new llogin();
            llogin.Show();
        }
    }
}
