using EQProDXApp.Entities;
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


            textBoxUpdatedPassDate.Text = DateTime.Today.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                User newUser = new User();
                newUser.EQProUserID = textBoxEQProUserID.Text + textBox4Char.Text;
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

                newUser.insertUser(newUser);

                ResetForm();
            }
        }

        private bool ValidateForm()
        {
            var phoneRegex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            var symbolRegex = new Regex(@"[@~#$%^&*]");
            if (textBoxNewPass.Text == "" || textBoxVerifyPass.Text == "" || textBoxFN.Text == "" || textBoxLN.Text == "" || textBoxEmail.Text == "" || textBoxSignature.Text == "" || comboBoxEQRole.Text == "" || comboBoxEQUserRole.Text == "" || textBoxUpdatedPassDate.Text == "" || textBox4Char.Text == "Click Here")
            {
                MessageBox.Show("Please Fill all the empty fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if(textBoxNewPass.Text.Contains(textBoxFN.Text) || textBoxNewPass.Text.Contains(textBoxLN.Text))
            {
                if(!textBoxFN.Text.Equals("") || !textBoxLN.Text.Equals(""))
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
            if(!Regex.IsMatch(textBoxEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Incorrect Email Address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (textBoxEQProUserID.Text.Equals("Click Here"))
            {
                MessageBox.Show("Click EQ Pro User ID Textbox to generate ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }            
            return true;
        }

        private void ResetForm()
        {
            //comboBoxID.SelectedIndex = 0;
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
            textBox4Char.Text = "";
            textBoxUpdatedPassDate.Text = DateTime.Now.ToString();
        }

        private void textBoxNewPass_Enter(object sender, EventArgs e)
        {
            toolTipPassword.Show("8 Characters with at least one of these (A-Z, a-z, 0-9, ~ @ # $ % ^ & * )", textBoxNewPass);
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
    }
}
