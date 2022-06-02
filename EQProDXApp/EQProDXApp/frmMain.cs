using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQProDXApp
{
    public partial class frmMain : Form
    {
       
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {
            //    this.Close();
            //    this.Hide();

            frmEnvironment objFrmEnvirt = new frmEnvironment();
            objFrmEnvirt.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.Hide();

            frmUsers objFrmUsers = new frmUsers();
            objFrmUsers.Show();
         
        }
    }
}
