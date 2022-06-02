namespace EQProDXApp
{
    partial class frmUsers
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
            this.cmbBoxUserID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.tBoxNewPwd = new DevExpress.XtraEditors.TextEdit();
            this.lblNewPwd = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.labelPrefix = new DevExpress.XtraEditors.LabelControl();
            this.lblPwdVerify = new DevExpress.XtraEditors.LabelControl();
            this.tBoxPwdVerify = new DevExpress.XtraEditors.TextEdit();
            this.tBoxPrefix = new DevExpress.XtraEditors.TextEdit();
            this.textFirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelFirstName = new DevExpress.XtraEditors.LabelControl();
            this.textMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.labelMName = new DevExpress.XtraEditors.LabelControl();
            this.textLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelLName = new DevExpress.XtraEditors.LabelControl();
            this.textSuffix = new DevExpress.XtraEditors.TextEdit();
            this.labelSuffix = new DevExpress.XtraEditors.LabelControl();
            this.labelLastPwdChng = new DevExpress.XtraEditors.LabelControl();
            this.cmbBoxEQRepRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textESignature = new DevExpress.XtraEditors.TextEdit();
            this.labelESignature = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbBoxEQAppRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDatePwdUpdtd = new DevExpress.XtraEditors.TextEdit();
            this.textEMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxNewPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPwdVerify.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPrefix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSuffix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxEQRepRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textESignature.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxEQAppRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatePwdUpdtd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxUserID
            // 
            this.cmbBoxUserID.Location = new System.Drawing.Point(371, 30);
            this.cmbBoxUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxUserID.Name = "cmbBoxUserID";
            // 
            // 
            // 
            this.cmbBoxUserID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbBoxUserID.Properties.Appearance.Options.UseFont = true;
            this.cmbBoxUserID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxUserID.Size = new System.Drawing.Size(288, 30);
            this.cmbBoxUserID.TabIndex = 0;
            this.cmbBoxUserID.SelectedIndexChanged += new System.EventHandler(this.cmbBoxtxtPlant_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblId.Appearance.Options.UseFont = true;
            this.lblId.Location = new System.Drawing.Point(121, 33);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(185, 24);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID to Add/Change";
            // 
            // tBoxNewPwd
            // 
            this.tBoxNewPwd.Location = new System.Drawing.Point(372, 79);
            this.tBoxNewPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxNewPwd.Name = "tBoxNewPwd";
            // 
            // 
            // 
            this.tBoxNewPwd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxNewPwd.Properties.Appearance.Options.UseFont = true;
            this.tBoxNewPwd.Size = new System.Drawing.Size(288, 30);
            this.tBoxNewPwd.TabIndex = 2;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNewPwd.Appearance.Options.UseFont = true;
            this.lblNewPwd.Location = new System.Drawing.Point(121, 82);
            this.lblNewPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(148, 24);
            this.lblNewPwd.TabIndex = 3;
            this.lblNewPwd.Text = "New Password";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(117, 775);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(548, 775);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(163, 50);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(331, 775);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 50);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApp.Location = new System.Drawing.Point(788, 775);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(163, 50);
            this.btnExitApp.TabIndex = 7;
            this.btnExitApp.Text = "Exit App";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnMianPg_Click);
            // 
            // labelPrefix
            // 
            this.labelPrefix.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelPrefix.Appearance.Options.UseFont = true;
            this.labelPrefix.Location = new System.Drawing.Point(121, 197);
            this.labelPrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(61, 24);
            this.labelPrefix.TabIndex = 8;
            this.labelPrefix.Text = "Prefix";
            // 
            // lblPwdVerify
            // 
            this.lblPwdVerify.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPwdVerify.Appearance.Options.UseFont = true;
            this.lblPwdVerify.Location = new System.Drawing.Point(121, 143);
            this.lblPwdVerify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPwdVerify.Name = "lblPwdVerify";
            this.lblPwdVerify.Size = new System.Drawing.Size(164, 24);
            this.lblPwdVerify.TabIndex = 9;
            this.lblPwdVerify.Text = "Verify Password";
            // 
            // tBoxPwdVerify
            // 
            this.tBoxPwdVerify.Location = new System.Drawing.Point(372, 135);
            this.tBoxPwdVerify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxPwdVerify.Name = "tBoxPwdVerify";
            // 
            // 
            // 
            this.tBoxPwdVerify.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxPwdVerify.Properties.Appearance.Options.UseFont = true;
            this.tBoxPwdVerify.Size = new System.Drawing.Size(288, 30);
            this.tBoxPwdVerify.TabIndex = 10;
            // 
            // tBoxPrefix
            // 
            this.tBoxPrefix.Location = new System.Drawing.Point(372, 190);
            this.tBoxPrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxPrefix.Name = "tBoxPrefix";
            // 
            // 
            // 
            this.tBoxPrefix.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxPrefix.Properties.Appearance.Options.UseFont = true;
            this.tBoxPrefix.Size = new System.Drawing.Size(288, 30);
            this.tBoxPrefix.TabIndex = 11;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(372, 244);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFirstName.Name = "textFirstName";
            // 
            // 
            // 
            this.textFirstName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textFirstName.Properties.Appearance.Options.UseFont = true;
            this.textFirstName.Size = new System.Drawing.Size(288, 30);
            this.textFirstName.TabIndex = 13;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelFirstName.Appearance.Options.UseFont = true;
            this.labelFirstName.Location = new System.Drawing.Point(121, 250);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(109, 24);
            this.labelFirstName.TabIndex = 12;
            this.labelFirstName.Text = "First Name";
            // 
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(372, 303);
            this.textMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textMiddleName.Name = "textMiddleName";
            // 
            // 
            // 
            this.textMiddleName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textMiddleName.Properties.Appearance.Options.UseFont = true;
            this.textMiddleName.Size = new System.Drawing.Size(288, 30);
            this.textMiddleName.TabIndex = 15;
            // 
            // labelMName
            // 
            this.labelMName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelMName.Appearance.Options.UseFont = true;
            this.labelMName.Location = new System.Drawing.Point(121, 309);
            this.labelMName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(125, 24);
            this.labelMName.TabIndex = 14;
            this.labelMName.Text = "Midlle Name";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(372, 358);
            this.textLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLastName.Name = "textLastName";
            // 
            // 
            // 
            this.textLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textLastName.Properties.Appearance.Options.UseFont = true;
            this.textLastName.Size = new System.Drawing.Size(288, 30);
            this.textLastName.TabIndex = 17;
            // 
            // labelLName
            // 
            this.labelLName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelLName.Appearance.Options.UseFont = true;
            this.labelLName.Location = new System.Drawing.Point(121, 366);
            this.labelLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(105, 24);
            this.labelLName.TabIndex = 16;
            this.labelLName.Text = "Last Name";
            // 
            // textSuffix
            // 
            this.textSuffix.Location = new System.Drawing.Point(372, 411);
            this.textSuffix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSuffix.Name = "textSuffix";
            // 
            // 
            // 
            this.textSuffix.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textSuffix.Properties.Appearance.Options.UseFont = true;
            this.textSuffix.Size = new System.Drawing.Size(288, 30);
            this.textSuffix.TabIndex = 19;
            // 
            // labelSuffix
            // 
            this.labelSuffix.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelSuffix.Appearance.Options.UseFont = true;
            this.labelSuffix.Location = new System.Drawing.Point(121, 418);
            this.labelSuffix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(61, 24);
            this.labelSuffix.TabIndex = 18;
            this.labelSuffix.Text = "Suffix";
            // 
            // labelLastPwdChng
            // 
            this.labelLastPwdChng.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelLastPwdChng.Appearance.Options.UseFont = true;
            this.labelLastPwdChng.Appearance.Options.UseTextOptions = true;
            this.labelLastPwdChng.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelLastPwdChng.AppearanceDisabled.Options.UseTextOptions = true;
            this.labelLastPwdChng.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelLastPwdChng.AppearanceHovered.Options.UseTextOptions = true;
            this.labelLastPwdChng.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelLastPwdChng.AppearancePressed.Options.UseTextOptions = true;
            this.labelLastPwdChng.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelLastPwdChng.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelLastPwdChng.Location = new System.Drawing.Point(121, 582);
            this.labelLastPwdChng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelLastPwdChng.Name = "labelLastPwdChng";
            this.labelLastPwdChng.Size = new System.Drawing.Size(117, 23);
            this.labelLastPwdChng.TabIndex = 23;
            this.labelLastPwdChng.Text = "EQ Report Role";
            // 
            // cmbBoxEQRepRole
            // 
            this.cmbBoxEQRepRole.Location = new System.Drawing.Point(372, 578);
            this.cmbBoxEQRepRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxEQRepRole.Name = "cmbBoxEQRepRole";
            // 
            // 
            // 
            this.cmbBoxEQRepRole.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxEQRepRole.Properties.Appearance.Options.UseFont = true;
            this.cmbBoxEQRepRole.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxEQRepRole.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.cmbBoxEQRepRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxEQRepRole.Properties.Items.AddRange(new object[] {
            "Prepearer",
            "Viewer",
            "Assigner"});
            this.cmbBoxEQRepRole.Size = new System.Drawing.Size(288, 30);
            this.cmbBoxEQRepRole.TabIndex = 22;
            this.cmbBoxEQRepRole.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEQRepRole_SelectedIndexChanged);
            // 
            // textESignature
            // 
            this.textESignature.Location = new System.Drawing.Point(372, 517);
            this.textESignature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textESignature.Name = "textESignature";
            // 
            // 
            // 
            this.textESignature.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textESignature.Properties.Appearance.Options.UseFont = true;
            this.textESignature.Size = new System.Drawing.Size(288, 30);
            this.textESignature.TabIndex = 27;
            // 
            // labelESignature
            // 
            this.labelESignature.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelESignature.Appearance.Options.UseFont = true;
            this.labelESignature.Location = new System.Drawing.Point(121, 524);
            this.labelESignature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelESignature.Name = "labelESignature";
            this.labelESignature.Size = new System.Drawing.Size(117, 24);
            this.labelESignature.TabIndex = 26;
            this.labelESignature.Text = "E Signature";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AppearanceDisabled.Options.UseTextOptions = true;
            this.labelControl1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AppearanceHovered.Options.UseTextOptions = true;
            this.labelControl1.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl1.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(117, 697);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(289, 23);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Date of Password Updated";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AppearanceDisabled.Options.UseTextOptions = true;
            this.labelControl2.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AppearanceHovered.Options.UseTextOptions = true;
            this.labelControl2.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl2.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(121, 640);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 23);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "EQ App Role";
            // 
            // cmbBoxEQAppRole
            // 
            this.cmbBoxEQAppRole.Location = new System.Drawing.Point(372, 636);
            this.cmbBoxEQAppRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBoxEQAppRole.Name = "cmbBoxEQAppRole";
            // 
            // 
            // 
            this.cmbBoxEQAppRole.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxEQAppRole.Properties.Appearance.Options.UseFont = true;
            this.cmbBoxEQAppRole.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxEQAppRole.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.cmbBoxEQAppRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxEQAppRole.Properties.Items.AddRange(new object[] {
            "Admin",
            "Reader",
            "Modifier",
            "Report"});
            this.cmbBoxEQAppRole.Size = new System.Drawing.Size(288, 30);
            this.cmbBoxEQAppRole.TabIndex = 29;
            this.cmbBoxEQAppRole.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEQAppRole_SelectedIndexChanged);
            // 
            // txtDatePwdUpdtd
            // 
            this.txtDatePwdUpdtd.Location = new System.Drawing.Point(423, 688);
            this.txtDatePwdUpdtd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatePwdUpdtd.Name = "txtDatePwdUpdtd";
            // 
            // 
            // 
            this.txtDatePwdUpdtd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDatePwdUpdtd.Properties.Appearance.Options.UseFont = true;
            this.txtDatePwdUpdtd.Size = new System.Drawing.Size(288, 30);
            this.txtDatePwdUpdtd.TabIndex = 31;
            // 
            // textEMail
            // 
            this.textEMail.Location = new System.Drawing.Point(372, 462);
            this.textEMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEMail.Name = "textEMail";
            // 
            // 
            // 
            this.textEMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEMail.Properties.Appearance.Options.UseFont = true;
            this.textEMail.Size = new System.Drawing.Size(288, 30);
            this.textEMail.TabIndex = 33;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(121, 469);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 24);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "E-Mail";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 859);
            this.Controls.Add(this.tBoxPwdVerify);
            this.Controls.Add(this.tBoxNewPwd);
            this.Controls.Add(this.cmbBoxUserID);
            this.Controls.Add(this.textEMail);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDatePwdUpdtd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbBoxEQAppRole);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textESignature);
            this.Controls.Add(this.labelESignature);
            this.Controls.Add(this.labelLastPwdChng);
            this.Controls.Add(this.cmbBoxEQRepRole);
            this.Controls.Add(this.textSuffix);
            this.Controls.Add(this.labelSuffix);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.textMiddleName);
            this.Controls.Add(this.labelMName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.tBoxPrefix);
            this.Controls.Add(this.lblPwdVerify);
            this.Controls.Add(this.labelPrefix);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEnvironment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxNewPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPwdVerify.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPrefix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSuffix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxEQRepRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textESignature.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxEQAppRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatePwdUpdtd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEMail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxUserID;
        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.XtraEditors.TextEdit tBoxNewPwd;
        private DevExpress.XtraEditors.LabelControl lblNewPwd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExitApp;
        private DevExpress.XtraEditors.LabelControl labelPrefix;
        private DevExpress.XtraEditors.LabelControl lblPwdVerify;
        private DevExpress.XtraEditors.TextEdit tBoxPwdVerify;
        private DevExpress.XtraEditors.TextEdit tBoxPrefix;
        private DevExpress.XtraEditors.TextEdit textFirstName;
        private DevExpress.XtraEditors.LabelControl labelFirstName;
        private DevExpress.XtraEditors.TextEdit textMiddleName;
        private DevExpress.XtraEditors.LabelControl labelMName;
        private DevExpress.XtraEditors.TextEdit textLastName;
        private DevExpress.XtraEditors.LabelControl labelLName;
        private DevExpress.XtraEditors.TextEdit textSuffix;
        private DevExpress.XtraEditors.LabelControl labelSuffix;
        private DevExpress.XtraEditors.LabelControl labelLastPwdChng;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxEQRepRole;
        private DevExpress.XtraEditors.TextEdit textESignature;
        private DevExpress.XtraEditors.LabelControl labelESignature;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxEQAppRole;
        private DevExpress.XtraEditors.TextEdit txtDatePwdUpdtd;
        private DevExpress.XtraEditors.TextEdit textEMail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}

