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
    public partial class MainForm : Form
    {
        //Home homeForm;
        UserForm userForm;
        EnviromentForm envForm;
        //Patient patientForm;
        //Doctor doctorForm;
        //Department departmentForm;
        //Appointment appointmentForm;
        //Staff staffForm;        

        public MainForm()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    manageRole();
        //    showHomeForm();
        //}      

        //private void showHomeForm()
        //{
        //    closeAllForms();
        //    homeForm = new Home();
        //    homeForm.TopLevel = false;
        //    this.centerPanel.Controls.Add(homeForm);
        //    homeForm.Dock = DockStyle.Fill;
        //    homeForm.Show();
        //}

        private void showUserForm()
        {
            closeAllForms();
            userForm = new UserForm();
            userForm.TopLevel = false;
            this.centerPanel.Controls.Add(userForm);
            userForm.Dock = DockStyle.Fill;
            userForm.Show();
        }

        private void showEnviromentForm()
        {
            closeAllForms();
            envForm = new EnviromentForm();
            envForm.TopLevel = false;
            this.centerPanel.Controls.Add(envForm);
            envForm.Dock = DockStyle.Fill;
            envForm.Show();
        }

        //private void showDepartmentForm()
        //{
        //    closeAllForms();
        //    departmentForm = new Department();
        //    departmentForm.TopLevel = false;
        //    this.centerPanel.Controls.Add(departmentForm);
        //    departmentForm.Dock = DockStyle.Fill;
        //    departmentForm.Show();
        //}

        //private void showAppointmentForm()
        //{
        //    closeAllForms();
        //    appointmentForm = new Appointment();
        //    appointmentForm.TopLevel = false;
        //    this.centerPanel.Controls.Add(appointmentForm);
        //    appointmentForm.Dock = DockStyle.Fill;
        //    appointmentForm.Show();
        //}

        //private void showStaffForm()
        //{
        //    closeAllForms();
        //    staffForm = new Staff();
        //    staffForm.TopLevel = false;
        //    this.centerPanel.Controls.Add(staffForm);
        //    staffForm.Dock = DockStyle.Fill;
        //    staffForm.Show();
        //}

        //private void buttonPatient_Click(object sender, EventArgs e)
        //{
        //    showPatientForm();
        //}

        //private void buttonHome_Click(object sender, EventArgs e)
        //{
        //    showHomeForm();
        //}

        //Close all Forms
        private void closeAllForms()
        {
            if (userForm != null)
            {
                userForm.Close();
            }
            if (envForm != null)
            {
                envForm.Close();
            }
            //if (doctorForm != null)
            //{
            //    doctorForm.Close();
            //}
            //if (departmentForm != null)
            //{
            //    departmentForm.Close();
            //}
            //if (appointmentForm != null)
            //{
            //    appointmentForm.Close();
            //}
            //if (staffForm != null)
            //{
            //    staffForm.Close();
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            showUserForm();
        }

        private void buttonEnviroment_Click(object sender, EventArgs e)
        {
            showEnviromentForm();
        }

        //private void manageRole()
        //{
        //    NpgsqlConnection con = new NpgsqlConnection(Utilis.CONNECTION_STRING);
        //    string query = $"SELECT * FROM role WHERE id = {Utilis.ROLE_ID};";
        //    try
        //    {
        //        con.Open();
        //        NpgsqlCommand cmd = new NpgsqlCommand(query, con);
        //        NpgsqlDataReader row;
        //        row = cmd.ExecuteReader();

        //        if (row.HasRows)
        //        {
        //            while (row.Read())
        //            {                        
        //                Utilis.ROLE_TYPE = row["role_type"].ToString();                     
        //            }
        //            if (Utilis.ROLE_TYPE.Equals("employee"))
        //            {
        //                buttonDepartment.Visible = false;
        //                buttonDoctors.Visible = false;
        //                buttonStaff.Visible = false;
        //            }
        //        }                
        //        con.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void buttonDoctors_Click(object sender, EventArgs e)
        //{
        //    showDoctorForm();
        //}

        //private void buttonDepartment_Click(object sender, EventArgs e)
        //{
        //    showDepartmentForm();
        //}

        //private void buttonAppointment_Click(object sender, EventArgs e)
        //{
        //    showAppointmentForm();
        //}

        //private void buttonStaff_Click(object sender, EventArgs e)
        //{
        //    showStaffForm();
        //}

        //private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    if (System.Windows.Forms.Application.OpenForms["Login"] != null)
        //    {
        //        (System.Windows.Forms.Application.OpenForms["Login"] as Login).Show();
        //    }
        //}
    }
}
