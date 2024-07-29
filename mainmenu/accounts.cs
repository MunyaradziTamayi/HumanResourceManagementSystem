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
    public partial class accounts : Form
    {
        public accounts()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

           
            if (changeaccountpanel.Visible == false)

                changeaccountpanel.Visible = true;
            else
                changeaccountpanel.Visible = false;
        }
    }
}
