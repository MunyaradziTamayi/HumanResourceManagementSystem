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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainmenu1 dashboard = new mainmenu1();
            this.Hide();
            dashboard.Show();
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

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already in EMPLOYEES Form");
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

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            promotions promote = new promotions();
            this.Hide();
            promote.Show();

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

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            attendancereport report = new attendancereport();
            this.Hide();
            report.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaSwitch1_CheckedChanged(object sender, EventArgs e)
        {

            {
                if (sideMenuPanel.Visible == true)
                    sideMenuPanel.Visible = false;
                else
                    sideMenuPanel.Visible = true;
            }
        }

        private void employee_Load(object sender, EventArgs e)
        {
         
            timer1.Start();
            timer1.Enabled = true;
            gunaDateTimePicker1.Enabled = true;
            iDTextBox.Focus();
            
            // TODO: This line of code loads data into the 'hrmanagementDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hrmanagementDataSet.employee);

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            iDTextBox.Clear();
            nAMETextBox.Clear();
            aDDRESSTextBox.Clear();
            pHONETextBox.Clear();
            sALARYTextBox.Clear();
            dEPARTMENTTextBox.Clear();
            iDTextBox.Focus();
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            employeeBindingSource.AddNew();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            employeeBindingSource.EndEdit();
            employeeTableAdapter.Update(hrmanagementDataSet.employee);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            employeeBindingSource.RemoveCurrent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        Bitmap bmp;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int height = gunaDataGridView1.Height;
            gunaDataGridView1.Height = gunaDataGridView1.RowCount * gunaDataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(gunaDataGridView1.Width, gunaDataGridView1.Height);
            gunaDataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, gunaDataGridView1.Width, gunaDataGridView1.Height));
            gunaDataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
           

         
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
