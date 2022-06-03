namespace EQProDXApp
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxVerifyPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSuffix = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSignature = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxEQRole = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxEQUserRole = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxUpdatedPassDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
 
            this.usersMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
   
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxEQProUserID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4Char = new System.Windows.Forms.TextBox();
            
            ((System.ComponentModel.ISupportInitialize)(this.usersMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID to Add/Change";
            // 
            // comboBoxID
            // 
            this.comboBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(79, 149);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(265, 37);
            this.comboBoxID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password";
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPass.Location = new System.Drawing.Point(398, 152);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(265, 34);
            this.textBoxNewPass.TabIndex = 3;
            this.textBoxNewPass.Enter += new System.EventHandler(this.textBoxNewPass_Enter);
            // 
            // textBoxVerifyPass
            // 
            this.textBoxVerifyPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxVerifyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVerifyPass.Location = new System.Drawing.Point(712, 152);
            this.textBoxVerifyPass.Name = "textBoxVerifyPass";
            this.textBoxVerifyPass.Size = new System.Drawing.Size(265, 34);
            this.textBoxVerifyPass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(707, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Verify Password";
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrefix.Location = new System.Drawing.Point(1001, 152);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(265, 34);
            this.textBoxPrefix.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(996, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prefix";
            // 
            // textBoxMN
            // 
            this.textBoxMN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMN.Location = new System.Drawing.Point(398, 255);
            this.textBoxMN.Name = "textBoxMN";
            this.textBoxMN.Size = new System.Drawing.Size(265, 34);
            this.textBoxMN.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Middle Name";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFN.Location = new System.Drawing.Point(79, 255);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(265, 34);
            this.textBoxFN.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "First Name";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(79, 355);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(265, 34);
            this.textBoxEmail.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Email";
            // 
            // textBoxSuffix
            // 
            this.textBoxSuffix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuffix.Location = new System.Drawing.Point(1001, 255);
            this.textBoxSuffix.Name = "textBoxSuffix";
            this.textBoxSuffix.Size = new System.Drawing.Size(265, 34);
            this.textBoxSuffix.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(996, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Suffix";
            // 
            // textBoxLN
            // 
            this.textBoxLN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLN.Location = new System.Drawing.Point(712, 255);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(265, 34);
            this.textBoxLN.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(707, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "Last Name";
            // 
            // textBoxSignature
            // 
            this.textBoxSignature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSignature.Location = new System.Drawing.Point(398, 355);
            this.textBoxSignature.Name = "textBoxSignature";
            this.textBoxSignature.Size = new System.Drawing.Size(265, 34);
            this.textBoxSignature.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "E Signature";
            // 
            // comboBoxEQRole
            // 
            this.comboBoxEQRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEQRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEQRole.FormattingEnabled = true;
            this.comboBoxEQRole.Items.AddRange(new object[] {
            "Preparer",
            "Viewer",
            "Approver"});
            this.comboBoxEQRole.Location = new System.Drawing.Point(712, 352);
            this.comboBoxEQRole.Name = "comboBoxEQRole";
            this.comboBoxEQRole.Size = new System.Drawing.Size(265, 37);
            this.comboBoxEQRole.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(707, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 27);
            this.label11.TabIndex = 20;
            this.label11.Text = "EQ Role";
            // 
            // comboBoxEQUserRole
            // 
            this.comboBoxEQUserRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEQUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEQUserRole.FormattingEnabled = true;
            this.comboBoxEQUserRole.Items.AddRange(new object[] {
            "Admin",
            "ReadOnly",
            "Edit",
            "Report"});
            this.comboBoxEQUserRole.Location = new System.Drawing.Point(1001, 352);
            this.comboBoxEQUserRole.Name = "comboBoxEQUserRole";
            this.comboBoxEQUserRole.Size = new System.Drawing.Size(265, 37);
            this.comboBoxEQUserRole.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(996, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 27);
            this.label12.TabIndex = 22;
            this.label12.Text = "EQ User Role";
            // 
            // textBoxUpdatedPassDate
            // 
            this.textBoxUpdatedPassDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUpdatedPassDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpdatedPassDate.Location = new System.Drawing.Point(79, 454);
            this.textBoxUpdatedPassDate.Name = "textBoxUpdatedPassDate";
            this.textBoxUpdatedPassDate.ReadOnly = true;
            this.textBoxUpdatedPassDate.Size = new System.Drawing.Size(265, 34);
            this.textBoxUpdatedPassDate.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(74, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(255, 27);
            this.label13.TabIndex = 24;
            this.label13.Text = "Password Updated Date";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.Navy;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(79, 529);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(187, 47);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.Navy;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(284, 529);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(187, 47);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignIn.BackColor = System.Drawing.Color.Navy;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.Location = new System.Drawing.Point(489, 529);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(187, 47);
            this.buttonSignIn.TabIndex = 28;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.BackColor = System.Drawing.Color.Navy;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(694, 529);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(187, 47);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "Exit App";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(67, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(270, 62);
            this.label14.TabIndex = 30;
            this.label14.Text = "User Form";
            // 
            // kCI_EQProDataSet
            // 
            // 
            // usersMainBindingSource
            // 
            this.usersMainBindingSource.DataMember = "UsersMain";
            
            // 
            // usersMainTableAdapter
            // 
            
            // 
            // toolTipPassword
            // 
            this.toolTipPassword.ToolTipTitle = "Password Criteria";
            // 
            // textBoxEQProUserID
            // 
            this.textBoxEQProUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEQProUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEQProUserID.Location = new System.Drawing.Point(398, 454);
            this.textBoxEQProUserID.Name = "textBoxEQProUserID";
            this.textBoxEQProUserID.ReadOnly = true;
            this.textBoxEQProUserID.Size = new System.Drawing.Size(184, 34);
            this.textBoxEQProUserID.TabIndex = 32;
            this.textBoxEQProUserID.Text = "Click Here";
            this.textBoxEQProUserID.Click += new System.EventHandler(this.textBoxEQProUserID_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(393, 417);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 27);
            this.label15.TabIndex = 31;
            this.label15.Text = "EQ Pro User ID";
            // 
            // textBox4Char
            // 
            this.textBox4Char.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4Char.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4Char.Location = new System.Drawing.Point(588, 454);
            this.textBox4Char.MaxLength = 4;
            this.textBox4Char.Name = "textBox4Char";
            this.textBox4Char.Size = new System.Drawing.Size(75, 34);
            this.textBox4Char.TabIndex = 33;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 639);
            this.Controls.Add(this.textBox4Char);
            this.Controls.Add(this.textBoxEQProUserID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxUpdatedPassDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxEQUserRole);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxEQRole);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxSignature);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSuffix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxMN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVerifyPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.usersMainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxVerifyPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSuffix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSignature;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxEQRole;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxEQUserRole;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxUpdatedPassDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label14;
        
        private System.Windows.Forms.BindingSource usersMainBindingSource;
        
        private System.Windows.Forms.ToolTip toolTipPassword;
        private System.Windows.Forms.TextBox textBoxEQProUserID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4Char;
    }
}