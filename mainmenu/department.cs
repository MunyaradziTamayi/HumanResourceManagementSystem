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
    public partial class department : Form
    {
        public department()
        {
            InitializeComponent();
        }

        private void department_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            // TODO: This line of code loads data into the 'hrmanagementDataSet2.departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.hrmanagementDataSet2.departments);
            // TODO: This line of code loads data into the 'hrmanagementDataSet1.department' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.hrmanagementDataSet2.departments);

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            dEPTIDTextBox.Clear();
            dEPTNAMETextBox.Clear();
            dESCRIPTIONTextBox.Clear();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            departmentsBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already in Departments Form");
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            departmentsBindingSource.EndEdit();
            departmentsTableAdapter.Update(hrmanagementDataSet2.departments);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            departmentsBindingSource.RemoveCurrent();
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

        private void button7_Click(object sender, EventArgs e)
        {
            mainmenu1 dashboard = new mainmenu1();

            this.Hide();

            dashboard.Show();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            employee employees = new employee();
            this.Hide();
            employees.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MANAGESALARIES attend = new MANAGESALARIES();
            this.Hide();
            attend.Show();

        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            payroll pay = new payroll();
            this.Hide();
            pay.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            attendancereport report = new attendancereport();
            this.Hide();
            report.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
          
        }
        Bitmap bmp;
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            int height = gunaDataGridView1.Height;
            gunaDataGridView1.Height = gunaDataGridView1.RowCount * gunaDataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(gunaDataGridView1.Width, gunaDataGridView1.Height);
            gunaDataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, gunaDataGridView1.Width, gunaDataGridView1.Height));
            gunaDataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
