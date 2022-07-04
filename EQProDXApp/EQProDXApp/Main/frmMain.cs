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
        frmUser objUserForm;
        frmCreateRoom objFrmEnvirt;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            centerPanel.Visible = true; 
            
        }

        private void closeAllForms()
        {
            if (objUserForm != null)
            {
                objUserForm.Close();
            }

            if (objFrmEnvirt != null)
            {
                objFrmEnvirt.Close();
            }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            //Form objOpenFrm = Application.OpenForms["UserForm"];
            frmUser objFrmUser = new frmUser ();
            if (objFrmUser != null)
            {
                objFrmUser.TopLevel = false;
               
                this.centerPanel.Controls.Add(objFrmUser);
                objFrmUser.Dock = DockStyle.Fill;
                objFrmUser.Show();
            }
        }

        private void btnEnvParam_Click(object sender, EventArgs e)
        {
            Form objOpenFrmMain = Application.OpenForms["frmMain"];
            if (objOpenFrmMain != null)
            {                
                //objOpenFrmMain.Hide();
                //closeAllForms();
                pnlMain.Hide();
                frmEnvParam objFrmEnvirt = new frmEnvParam();
                objFrmEnvirt.TopLevel = false;
                this.centerPanel.Controls.Add(objFrmEnvirt);
                objFrmEnvirt.Dock = DockStyle.Fill;
                objFrmEnvirt.Show();
                //objOpenFrmMain.Close();
            }
        }

        //Exit App
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(-1);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            Visible = true;
        }

        private void pnlEnvironmental_Paint(object sender, PaintEventArgs e)
        {
            Visible = false;
        }

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picMain_Click(object sender, EventArgs e)
        {

        }
    }
}
