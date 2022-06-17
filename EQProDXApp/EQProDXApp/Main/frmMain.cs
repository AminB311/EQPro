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
        UserForm objUserForm;
        frmCreateRoom objFrmEnvirt;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        { 
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
            Form objOpenFrm = Application.OpenForms["UserForm"];
            closeAllForms();
            UserForm objFrmUsers = new UserForm();
            objFrmUsers.TopLevel = false;
            this.centerPanel.Controls.Add(objFrmUsers);
            objFrmUsers.Dock = DockStyle.Fill;
            objFrmUsers.Show();
            //if (objOpenFrm != null)
            //{
            //    objOpenFrm.Close();
            //    closeAllForms();
            //    UserForm objFrmUsers = new UserForm();
            //    objFrmUsers.TopLevel = false;
            //    this.centerPanel.Controls.Add(objFrmUsers);
            //    objFrmUsers.Dock = DockStyle.Fill;
            //    objFrmUsers.Show();
            //}
            //else
            //{
            //    closeAllForms();
            //    UserForm objFrmUsers = new UserForm();
            //    objFrmUsers.TopLevel = false;
            //    this.centerPanel.Controls.Add(objFrmUsers);
            //    objFrmUsers.Dock = DockStyle.Fill;
            //    objFrmUsers.Show();
            //}
        }
        private void btnEnvParam_Click(object sender, EventArgs e)
        {
            Form objOpenFrm = Application.OpenForms["frmEnvParam"];
            closeAllForms();
            pnlMain.Hide();
            frmEnvParam objFrm = new frmEnvParam();
            objFrm.TopLevel = false;
            this.centerPanel.Controls.Add(objFrm);
            objFrm.Dock = DockStyle.Fill;
            objFrm.Show();
            //if (objOpenFrm != null)
            //{
            //    objOpenFrm.Close();
            //    closeAllForms();
            //    frmEnvParam objFrmEnvirt = new frmEnvParam();
            //    objFrmEnvirt.TopLevel = false;
            //    this.centerPanel.Controls.Add(objFrmEnvirt);
            //    objFrmEnvirt.Dock = DockStyle.Fill;
            //    objFrmEnvirt.Show();
            //}
            //else
            //{   
            //    closeAllForms();
            //    pnlMain.Hide();
            //    frmEnvParam objFrmEnvirt = new frmEnvParam();
            //    objFrmEnvirt.TopLevel = false;
            //    this.centerPanel.Controls.Add(objFrmEnvirt);
            //    objFrmEnvirt.Dock = DockStyle.Fill;
            //    objFrmEnvirt.Show();
            //}

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
    }
}
