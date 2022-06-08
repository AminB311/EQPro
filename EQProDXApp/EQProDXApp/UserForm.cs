using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQProDXApp
{
    public partial class UserForm : Form
    {
        ToolTip toolTip = new ToolTip();
        Class_PublicMethods methods = new Class_PublicMethods();
        DataTable dataTable = new DataTable();
        int userID;
        //Set it to false to see the Non-Admin Form
        bool isAdmin = true;
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                comboBoxID.Enabled = false;
                btnDelete.Visible = false;
            }
            textBoxUpdatedPassDate.Text = DateTime.Today.ToString();
            methods.Load_CmbBoxValues("SELECT UserID from UserMain", comboBoxID);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (btnAdd.Text.Equals("Add"))
                {
                    User user = readFormData();
                    user.InsertOrUpdateUser("INSERT INTO dbo.UserMain(EQProUserID, Password, FirstName, LastName, MiddleName, Prefix, Suffix, ESignature, DateChange, DateCurrent, CanCreateEQProID, CanCreateUserID, EQRole, UserRole, email, IsDeleted) VALUES(@EQProUserID, @Password, @FirstName, @LastName, @MiddleName, @Prefix, @Suffix, @ESignature, @DateChange, @DateCurrent, @CanCreateEQProID, @CanCreateUserID, @EQRole, @UserRole, @email, @IsDeleted)", user, "User Added Successfully!");
                    ResetForm();
                }
                else
                {
                    User user = readFormData();
                    user.InsertOrUpdateUser("UPDATE dbo.UserMain SET EQProUserID = @EQProUserID, Password = @Password, FirstName = @FirstName, LastName = @LastName, MiddleName = @MiddleName, Prefix = @Prefix, Suffix = @Suffix, ESignature = @ESignature, DateChange = @DateChange, DateCurrent = @DateCurrent, CanCreateEQProID = @CanCreateEQProID, CanCreateUserID = @CanCreateUserID, EQRole = @EQRole, UserRole = @UserRole, email = @email, IsDeleted = @IsDeleted WHERE UserID = " + userID, user, "User Updated Successfully!");
                }
            }
        }

        private User readFormData()
        {
            User newUser = new User();
            newUser.EQProUserID = textBoxEQProUserID.Text;
            newUser.Password = textBoxNewPass.Text;
            newUser.FirstName = textBoxFN.Text;
            newUser.MiddleName = textBoxMN.Text;
            newUser.LastName = textBoxLN.Text;
            newUser.Prefix = textBoxPrefix.Text;
            newUser.Suffix = textBoxSuffix.Text;
            newUser.ESignature = textBoxSignature.Text;
            newUser.CanCreateEQProID = false;
            newUser.CanCreateUserID = false;
            newUser.EQRole = comboBoxEQRole.SelectedItem.ToString();
            newUser.UserRole = comboBoxEQUserRole.SelectedItem.ToString();
            newUser.Email = textBoxEmail.Text;
            newUser.IsDeleted = false;

            return newUser;
        }

        private bool ValidateForm()
        {
            ErrorProvider errorProvider = new ErrorProvider();
            var phoneRegex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            var symbolRegex = new Regex(@"[@~#$%^&*]");
            if (textBoxNewPass.Text == "")
            {
                MessageBox.Show("Password Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(textBoxNewPass, "Empty Field");
                return false;
            }
            if (textBoxVerifyPass.Text == "")
            {
                MessageBox.Show("Verify Password Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(textBoxVerifyPass, "Empty Field");
                return false;
            }
            if (textBoxFN.Text == "")
            {
                MessageBox.Show("First Name Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(textBoxFN, "Empty Field");
                return false;
            }
            if (textBoxLN.Text == "")
            {
                MessageBox.Show("Last Name Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(textBoxLN, "Empty Field");
                return false;
            }
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Email Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(textBoxEmail, "Empty Field");
                return false;
            }
            if (textBoxSignature.Text == "")
            {
                MessageBox.Show("E-Signature Field Cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(textBoxSignature, "Empty Field");
                return false;
            }
            if (comboBoxEQRole.Text == "")
            {
                MessageBox.Show("Select EQ Role From ComboBox!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(comboBoxEQRole, "No Item Selected");
                return false;
            }
            if (comboBoxEQUserRole.Text == "")
            {
                MessageBox.Show("Select EQ User Role From ComboBox!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(comboBoxEQUserRole, "No Item Selected");
                return false;
            }
            if (textBoxNewPass.Text.Length < 8)
            {
                MessageBox.Show("Password should be 8 or more characters long!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!textBoxNewPass.Text.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one Upper Case Character!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!textBoxNewPass.Text.Any(char.IsLower))
            {
                MessageBox.Show("Password must contain at least one Lower Case Character!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!textBoxNewPass.Text.Any(char.IsNumber))
            {
                MessageBox.Show("Password must contain at least one Numeric Character!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!symbolRegex.IsMatch(textBoxNewPass.Text))
            {
                MessageBox.Show("Password must contain at least one Symbol (~ @ # $ % ^ & *)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (phoneRegex.IsMatch(textBoxNewPass.Text))
            {
                MessageBox.Show("Phone No. Cannot be set as Password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (textBoxNewPass.Text.Contains(textBoxFN.Text) || textBoxNewPass.Text.Contains(textBoxLN.Text))
            {
                if (!textBoxFN.Text.Equals("") || !textBoxLN.Text.Equals(""))
                {
                    MessageBox.Show("Password must not contain your name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return false;
            }
            if (!textBoxNewPass.Text.Equals(textBoxVerifyPass.Text))
            {
                MessageBox.Show("Password not matched, Try Again!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!Regex.IsMatch(textBoxEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Incorrect Email Address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (textBoxEQProUserID.Text.Equals("Click Here"))
            {
                MessageBox.Show("Click EQ Pro User ID Textbox to generate ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            errorProvider.Clear();
            return true;
        }

        private void ResetForm()
        {
            comboBoxID.Text = "";
            textBoxNewPass.Text = "";
            textBoxVerifyPass.Text = "";
            textBoxFN.Text = "";
            textBoxMN.Text = "";
            textBoxLN.Text = "";
            textBoxPrefix.Text = "";
            textBoxSuffix.Text = "";
            textBoxEmail.Text = "";
            textBoxSignature.Text = "";
            comboBoxEQRole.Text = "";
            comboBoxEQUserRole.Text = "";
            textBoxEQProUserID.Text = "Click Here";

            textBoxUpdatedPassDate.Text = DateTime.Now.ToString();
            btnAdd.Text = "Add";
        }

        private void textBoxNewPass_Enter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Password Criteria";
            toolTip.Show("8 Characters with at least one of these (A-Z, a-z, 0-9, ~ @ # $ % ^ & * )", textBoxNewPass);
        }

        private void textBoxEQProUserID_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(textBoxFN.Text) || !String.IsNullOrWhiteSpace(textBoxLN.Text))
            {
                textBoxEQProUserID.Text = textBoxFN.Text + "" + textBoxLN.Text;
            } else
            {
                MessageBox.Show("Please type First Name & Last Name to generate ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Email Criteria";
            toolTip.Show("abc@xyz.com", textBoxEmail);
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Update";
            dataTable = methods.Get_DataTable("SELECT * from dbo.UserMain Where UserID = " + int.Parse(comboBoxID.Text));
            userID = int.Parse(dataTable.Rows[0][0].ToString());
            textBoxEQProUserID.Text = dataTable.Rows[0][1].ToString();
            textBoxNewPass.Text = dataTable.Rows[0][2].ToString();
            textBoxVerifyPass.Text = dataTable.Rows[0][2].ToString();
            textBoxFN.Text = dataTable.Rows[0][3].ToString();
            textBoxLN.Text = dataTable.Rows[0][4].ToString();
            textBoxMN.Text = dataTable.Rows[0][5].ToString();
            textBoxPrefix.Text = dataTable.Rows[0][6].ToString();
            textBoxSuffix.Text = dataTable.Rows[0][7].ToString();
            textBoxSignature.Text = dataTable.Rows[0][8].ToString();
            textBoxUpdatedPassDate.Text = dataTable.Rows[0][9].ToString();
            comboBoxEQRole.Text = dataTable.Rows[0][13].ToString();
            comboBoxEQUserRole.Text = dataTable.Rows[0][14].ToString();
            textBoxEmail.Text = dataTable.Rows[0][15].ToString();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to Delete this User?", "Attention Required", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                methods.Delete_SelectedValues("Delete from dbo.UserMain Where UserID = " + userID);
                methods.Load_CmbBoxValues("SELECT UserID from UserMain", comboBoxID);
                ResetForm();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;   
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (btnAdd.Text.Equals("Add"))
                {
                    User user = readFormData();
                    user.InsertOrUpdateUser("INSERT INTO dbo.UserMain(EQProUserID, Password, FirstName, LastName, MiddleName, Prefix, Suffix, ESignature, DateChange, DateCurrent, CanCreateEQProID, CanCreateUserID, EQRole, UserRole, email, IsDeleted) VALUES(@EQProUserID, @Password, @FirstName, @LastName, @MiddleName, @Prefix, @Suffix, @ESignature, @DateChange, @DateCurrent, @CanCreateEQProID, @CanCreateUserID, @EQRole, @UserRole, @email, @IsDeleted)", user, "User Added Successfully!");
                    ResetForm();
                }
                else
                {
                    User user = readFormData();
                    user.InsertOrUpdateUser("UPDATE dbo.UserMain SET EQProUserID = @EQProUserID, Password = @Password, FirstName = @FirstName, LastName = @LastName, MiddleName = @MiddleName, Prefix = @Prefix, Suffix = @Suffix, ESignature = @ESignature, DateChange = @DateChange, DateCurrent = @DateCurrent, CanCreateEQProID = @CanCreateEQProID, CanCreateUserID = @CanCreateUserID, EQRole = @EQRole, UserRole = @UserRole, email = @email, IsDeleted = @IsDeleted WHERE UserID = " + userID, user, "User Updated Successfully!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to Delete this User?", "Attention Required", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                methods.Delete_SelectedValues("Delete from dbo.UserMain Where UserID = " + userID);
                methods.Load_CmbBoxValues("SELECT UserID from UserMain", comboBoxID);
                ResetForm();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form objOpenFrm = Application.OpenForms["UserForm"];
            if (objOpenFrm != null)
            {
                objOpenFrm.Close();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form objOpenFrm = Application.OpenForms["UserForm"];
            if (objOpenFrm != null)
            {
                objOpenFrm.Close();
                frmMain objFrmMain = new frmMain();
                objFrmMain.Show();
            }
        }
    }
}
