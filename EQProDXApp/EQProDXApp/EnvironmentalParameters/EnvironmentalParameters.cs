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
            Form objOpenFrm = Application.OpenForms["frmEnvParam"];
            if (objOpenFrm != null)
            {
                closeAllForms();
                frmCreateRoom objFrmEnvirt = new frmCreateRoom();
                objFrmEnvirt.TopLevel = false;
                this.centerPanel.Controls.Add(objFrmEnvirt);
                objFrmEnvirt.Dock = DockStyle.Fill;
                objFrmEnvirt.Show();
            }
            else
            {
                closeAllForms();
                frmCreateRoom objFrmEnvirt = new frmCreateRoom();
                objFrmEnvirt.TopLevel = false;
                this.centerPanel.Controls.Add(objFrmEnvirt);
                objFrmEnvirt.Dock = DockStyle.Fill;
                objFrmEnvirt.Show();


            }

        }

        private void btnEnvParam_Click(object sender, EventArgs e)
        {

        }

        private void btnRevision_Click(object sender, EventArgs e)
        {

        }

        //Close Frm
        private void btnClose_Click(object sender, EventArgs e)
        {
            //System.Environment.Exit(-1);
            pnlEnvParam.Hide(); 
            closeAllForms();
            frmMain objFrm = new frmMain();
            objFrm.TopLevel = false;
            this.centerPanel.Controls.Add(objFrm);
            objFrm.Dock = DockStyle.Fill;
            objFrm.Show();
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
