using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainmenu
{
    public partial class MANAGESALARIES : Form
    {
        public MANAGESALARIES()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already in MANAGE SALARIES Form");

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            attendancereport report = new attendancereport();
            
            report.Show();
           
        }

      

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            employee employees = new employee();
            
            employees.Show();
          
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            payroll pay = new payroll();
            
            pay.Show();
            
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            promotions promote = new promotions();
            
            promote.Show();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (employeepanel.Visible == false && payrollpanel.Visible == true)
            {
                payrollpanel.Visible = false;
                employeepanel.Visible = true;
            }
            else if (employeepanel.Visible == false)

                employeepanel.Visible = true;
            else
                employeepanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (employeepanel.Visible == true && payrollpanel.Visible == false)
            {
                payrollpanel.Visible = true;
                employeepanel.Visible = false;
            }
            else if (payrollpanel.Visible == false)

                payrollpanel.Visible = true;
            else
                payrollpanel.Visible = false;
        }

        private void gunaSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (sideMenuPanel.Visible == true)
                sideMenuPanel.Visible = false;
            else
                sideMenuPanel.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);

            label3.ForeColor = Color.FromArgb(one, two, three, four);
            label4.ForeColor = Color.FromArgb(one, two, three, four);
            label6.ForeColor = Color.FromArgb(one, two, three, four);

        }

        private void MANAGESALARIES_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            gunaDateTimePicker1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            department dept = new department();
            this.Hide();
            dept.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accounts acc = new accounts();
            this.Hide();
            acc.Show();
        }

        private void sideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
