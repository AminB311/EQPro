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
        frmEnvironment objFrmEnvirt;

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
            Form objOpenFrm = Application.OpenForms["frmEnvironment"];
            if (objOpenFrm != null)
            {
                objOpenFrm.Close();
                closeAllForms();
                UserForm objFrmUsers = new UserForm();
                objFrmUsers.TopLevel = false;
                this.centerPanel.Controls.Add(objFrmUsers);
                objFrmUsers.Dock = DockStyle.Fill;
                objFrmUsers.Show();
            }
            else
            {
                closeAllForms();
                UserForm objFrmUsers = new UserForm();
                objFrmUsers.TopLevel = false;
                this.centerPanel.Controls.Add(objFrmUsers);
                objFrmUsers.Dock = DockStyle.Fill;
                objFrmUsers.Show();
            }
        }
        private void btnEnvParam_Click(object sender, EventArgs e)
        {
            Form objOpenFrm = Application.OpenForms["UserForm"];
            if (objOpenFrm != null)
            {
                objOpenFrm.Close();
                closeAllForms();
                frmEnvironment objFrmEnvirt = new frmEnvironment();
                objFrmEnvirt.TopLevel = false;
                this.centerPanel.Controls.Add(objFrmEnvirt);
                objFrmEnvirt.Dock = DockStyle.Fill;
                objFrmEnvirt.Show();
            }
            else
            {   
                closeAllForms();
                frmEnvironment objFrmEnvirt = new frmEnvironment();
                objFrmEnvirt.TopLevel = false;
                this.centerPanel.Controls.Add(objFrmEnvirt);
                objFrmEnvirt.Dock = DockStyle.Fill;
                objFrmEnvirt.Show();
            }

        }

        //Exit App
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(-1);
        }
    }
}
