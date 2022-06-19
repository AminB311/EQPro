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
    public partial class frmEnvParam : Form
    {
        //frmMain objfrmMain;
        public frmEnvParam()
        {
            InitializeComponent();
        }

        private void frmEnvParam_Load(object sender, EventArgs e)
        {

        }

        private void closeAllForms()
        {
            //if (objUserForm != null)
            //{
            //    objUserForm.Close();
            //}

            //if (objFrmEnvirt != null)
            //{
            //    objFrmEnvirt.Close();
            //}
        }
       
        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmCreateRoom objFrmEnvirt = new frmCreateRoom();
            objFrmEnvirt.TopLevel = false;
            this.centerPanel.Controls.Add(objFrmEnvirt);
            objFrmEnvirt.Dock = DockStyle.Fill;
            objFrmEnvirt.Show();
        }
             
        //Close Frm
        private void btnClose_Click(object sender, EventArgs e)
        {
            //System.Environment.Exit(-1);
            //Form objfrmMain = Application.OpenForms["frmMain"];
            Form objOpenFrm = Application.OpenForms["frmEnvParam"];
            if (objOpenFrm != null)
            {
                pnlEnvParam.Hide();
                //objOpenFrm.Close();
                objOpenFrm.TopLevel = false;
                //objOpenFrm.Hide();
                //Form objFrmMain = Application.OpenForms["frmMain"];
                frmMain objfrmMain = new frmMain();
                objfrmMain.TopLevel = false;
                this.centerPanel.Controls.Add(objfrmMain);
                objfrmMain.Dock = DockStyle.Fill;
                objfrmMain.Show();
            }
        }

        private void btnEnvParam_Click(object sender, EventArgs e)
        {
            //frmEnvParamSelScreen objFrmEnvirt = new frmEnvParamSelScreen();
            //objFrmEnvirt.TopLevel = false;
            //this.centerPanel.Controls.Add(objFrmEnvirt);
            //objFrmEnvirt.Dock = DockStyle.Fill;
            //objFrmEnvirt.Show();
        }

        private void btnRevision_Click(object sender, EventArgs e)
        {

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

     
    }
}
