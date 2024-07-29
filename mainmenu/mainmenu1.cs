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
    public partial class mainmenu1 : Form
    {
        public mainmenu1()
        {
            InitializeComponent();
           
        }
       
        
       


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hrmanagementDataSet4.absents' table. You can move, or remove it, as needed.
            this.absentsTableAdapter.Fill(this.hrmanagementDataSet4.absents);
            // TODO: This line of code loads data into the 'hrmanagementDataSet3.attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.hrmanagementDataSet3.attendance);
            // TODO: This line of code loads data into the 'hrmanagementDataSet3.attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.hrmanagementDataSet3.attendance);
            // TODO: This line of code loads data into the 'hrmanagementDataSet3.attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.hrmanagementDataSet3.attendance);
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Start();
            timer1.Enabled = true;
            gunaDateTimePicker1.Enabled = true;
             
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (employeepanel.Visible == false && payrollpanel.Visible == true) {
                payrollpanel.Visible = false;
                employeepanel.Visible = true;
                    }
            else if (employeepanel.Visible == false)
               
            employeepanel.Visible = true;
            else
                employeepanel.Visible = false;

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            accounts acc = new accounts();
            this.Hide();
            acc.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
          
        }

        private void button22_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
           
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            if (sideMenuPanel.Visible == true)
                sideMenuPanel.Visible = false;
            else
                sideMenuPanel.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (sideMenuPanel.Visible == true)
                sideMenuPanel.Visible = false;
            else
                sideMenuPanel.Visible = true;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("YOU ARE ALREADY IN THE DASHBOARD FORM");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void sideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            attendancereport report = new attendancereport();
            this.Hide();
            report.Show();
           
        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
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

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            promotions promote = new promotions();
            this.Hide();
            promote.Show();
            
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            payroll pay = new payroll();
            this.Hide();
            pay.Show();
            
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            department dept = new department();
            this.Hide();
            dept.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            chart1.Series["PRESENT"].XValueMember = "DEPARTMENT";
            chart2.Series["ABSENT"].XValueMember = "DEPARTMENT";
            chart1.Series["PRESENT"].YValueMembers = "NUMBEROFEMPLOYEES";
            chart2.Series["ABSENT"].YValueMembers = "NUMBEROFEMPLOYEES";
            chart1.DataSource = hrmanagementDataSet3.attendance;
            chart2.DataSource = hrmanagementDataSet4.absents;
            chart1.DataBind();
            chart2.DataBind();
        }

        private void attendanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrmanagementDataSet3);

        }

        private void attendanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            attendanceBindingSource.EndEdit();
            attendanceTableAdapter.Update(hrmanagementDataSet3.attendance);
            MessageBox.Show("successfully updated");
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            attendanceBindingSource.AddNew();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if( dataGridView1.Visible==false &&  ADD.Visible == false && update.Visible==false && delete.Visible==false)
            {
                dataGridView1.Visible = true;
               
                ADD.Visible = true;
                update.Visible = true;
                    delete.Visible = true;
               

            }
            else
            {
                dataGridView1.Visible =false;
               
                ADD.Visible = false;
                update.Visible = false;
                delete.Visible = false;
            }

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            attendanceBindingSource.RemoveCurrent();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
