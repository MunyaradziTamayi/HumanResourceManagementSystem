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
    public partial class payroll : Form
    {
        public payroll()
        {
            InitializeComponent();
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
            MessageBox.Show("You are already in PAYROLL Form");

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            promotions promote = new promotions();
            this.Hide();
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

        private void payroll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'humanresourcesDataSet.salaries' table. You can move, or remove it, as needed.
            this.salariesTableAdapter.Fill(this.humanresourcesDataSet.salaries);
            timer1.Start();
            timer1.Enabled = true;
            gunaDateTimePicker1.Enabled = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            sALARYIDTextBox.Clear();
            eMPLOYEENAMETextBox.Clear();
            pERIODTextBox.Clear();
            sALARYTextBox.Clear();
            tAXESTextBox.Clear();
            sALARYIDTextBox.Focus();
            
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
            salariesBindingSource.AddNew();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            salariesBindingSource.EndEdit();
            salariesTableAdapter.Update(humanresourcesDataSet.salaries);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            salariesBindingSource.RemoveCurrent();
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
    }
}
