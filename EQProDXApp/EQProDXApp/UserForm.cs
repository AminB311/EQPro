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
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kCI_EQProDataSet.UsersMain' table. You can move, or remove it, as needed.
            this.usersMainTableAdapter.Fill(this.kCI_EQProDataSet.UsersMain);

            textBoxUpdatedPassDate.Text = DateTime.Today.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {

            }
        }

        private bool ValidateForm()
        {
            var phoneRegex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            var symbolRegex = new Regex(@"[@~#$%^&*]");
            //if (comboBoxID.Text == "" || textBoxNewPass.Text == "" || textBoxVerifyPass.Text == "" || textBoxFN.Text == "" || textBoxLN.Text == "" || textBoxEmail.Text == "" || textBoxSignature.Text == "" || comboBoxEQReport.Text == "" || comboBoxEQAppRole.Text == "" || textBoxUpdatedPassDate.Text == "" || textBoxEQProUserID.Text == "Click Here")
            //{
            //    MessageBox.Show("Please Fill all the empty fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return false;
            //}
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
            if(textBoxNewPass.Text.Contains(textBoxFN.Text) || textBoxNewPass.Text.Contains(textBoxLN.Text) || textBoxNewPass.Text.Contains(textBoxMN.Text))
            {
                if(!textBoxFN.Text.Equals("") || !textBoxMN.Text.Equals("") || !textBoxLN.Text.Equals(""))
                {
                    MessageBox.Show("Password must not contain your name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            if (!textBoxNewPass.Text.Equals(textBoxVerifyPass.Text))
            {
                MessageBox.Show("Password not matched, Try Again!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if(!Regex.IsMatch(textBoxEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Incorrect Email Address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void ResetForm()
        {
            comboBoxID.SelectedIndex = 0;
            textBoxNewPass.Text = "";
            textBoxVerifyPass.Text = "";
            textBoxFN.Text = "";
            textBoxMN.Text = "";
            textBoxLN.Text = "";
            textBoxPrefix.Text = "";
            textBoxSuffix.Text = "";
            textBoxEmail.Text = "";
            textBoxSignature.Text = "";
            comboBoxEQRole.SelectedIndex = 0;
            comboBoxEQUserRole.SelectedIndex = 0;
            textBoxUpdatedPassDate.Text = "";
        }

        private void textBoxNewPass_Enter(object sender, EventArgs e)
        {
            toolTipPassword.Show("8 Characters with at least one of these (A-Z, a-z, 0-9, ~ @ # $ % ^ & * )", textBoxNewPass);
        }

        private void textBoxEQProUserID_Click(object sender, EventArgs e)
        {
            
            textBoxEQProUserID.Text = textBoxFN.Text + "" + textBoxLN.Text;
        }
    }
}
