namespace EQProDXApp.EnvironmentalParameters
{
    partial class EnvParamSelScreen
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
            this.lblStationName = new DevExpress.XtraEditors.LabelControl();
            this.lblRoomNumber = new DevExpress.XtraEditors.LabelControl();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtBoxStatus = new DevExpress.XtraEditors.TextEdit();
            this.lblEnv = new System.Windows.Forms.Label();
            this.txtBoxStation = new DevExpress.XtraEditors.TextEdit();
            this.cmbboxStation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbboxRevStation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtBoxPrpBy = new DevExpress.XtraEditors.TextEdit();
            this.txtBoxDatePrp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtBoxRevBy = new DevExpress.XtraEditors.TextEdit();
            this.txtBoxDateRev = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtBoxAppBy = new DevExpress.XtraEditors.TextEdit();
            this.txtBoxDateApp = new DevExpress.XtraEditors.TextEdit();
            this.btnRoleAsg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxStation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbboxStation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbboxRevStation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxPrpBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDatePrp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxRevBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDateRev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxAppBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDateApp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStationName
            // 
            this.lblStationName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblStationName.Appearance.Options.UseFont = true;
            this.lblStationName.Location = new System.Drawing.Point(77, 276);
            this.lblStationName.Margin = new System.Windows.Forms.Padding(2);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(64, 19);
            this.lblStationName.TabIndex = 1;
            this.lblStationName.Text = "Station ";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomNumber.Appearance.Options.UseFont = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(445, 276);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(2);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(93, 19);
            this.lblRoomNumber.TabIndex = 3;
            this.lblRoomNumber.Text = "Rev. Status";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilter.BackColor = System.Drawing.Color.Navy;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(806, 300);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(140, 38);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.Location = new System.Drawing.Point(178, 425);
            this.txtBoxStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBoxStatus.Properties.Appearance.Options.UseFont = true;
            this.txtBoxStatus.Size = new System.Drawing.Size(162, 26);
            this.txtBoxStatus.TabIndex = 4;
            this.txtBoxStatus.EditValueChanged += new System.EventHandler(this.tBoxPlanRev_EditValueChanged);
            // 
            // lblEnv
            // 
            this.lblEnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnv.AutoSize = true;
            this.lblEnv.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnv.ForeColor = System.Drawing.Color.Navy;
            this.lblEnv.Location = new System.Drawing.Point(20, 164);
            this.lblEnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnv.Name = "lblEnv";
            this.lblEnv.Size = new System.Drawing.Size(854, 50);
            this.lblEnv.TabIndex = 37;
            this.lblEnv.Text = "Environmental Parameters Selection Screen";
            this.lblEnv.Click += new System.EventHandler(this.lblEnv_Click);
            // 
            // txtBoxStation
            // 
            this.txtBoxStation.Location = new System.Drawing.Point(178, 372);
            this.txtBoxStation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxStation.Name = "txtBoxStation";
            this.txtBoxStation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBoxStation.Properties.Appearance.Options.UseFont = true;
            this.txtBoxStation.Size = new System.Drawing.Size(326, 26);
            this.txtBoxStation.TabIndex = 3;
            this.txtBoxStation.EditValueChanged += new System.EventHandler(this.tBoxRoomNo_EditValueChanged);
            // 
            // cmbboxStation
            // 
            this.cmbboxStation.EditValue = "";
            this.cmbboxStation.Location = new System.Drawing.Point(77, 312);
            this.cmbboxStation.Name = "cmbboxStation";
            this.cmbboxStation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbboxStation.Properties.Appearance.Options.UseFont = true;
            this.cmbboxStation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbboxStation.Size = new System.Drawing.Size(306, 26);
            this.cmbboxStation.TabIndex = 1;
            this.cmbboxStation.SelectedIndexChanged += new System.EventHandler(this.cmbboxStation_SelectedIndexChanged);
            // 
            // cmbboxRevStation
            // 
            this.cmbboxRevStation.EditValue = "";
            this.cmbboxRevStation.Location = new System.Drawing.Point(432, 312);
            this.cmbboxRevStation.Name = "cmbboxRevStation";
            this.cmbboxRevStation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbboxRevStation.Properties.Appearance.Options.UseFont = true;
            this.cmbboxRevStation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbboxRevStation.Size = new System.Drawing.Size(306, 26);
            this.cmbboxRevStation.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(77, 375);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 19);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Station ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(77, 428);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 19);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Status";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(586, 527);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 19);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "Date";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(77, 527);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 19);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Prepeared By";
            // 
            // txtBoxPrpBy
            // 
            this.txtBoxPrpBy.Enabled = false;
            this.txtBoxPrpBy.Location = new System.Drawing.Point(208, 524);
            this.txtBoxPrpBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxPrpBy.Name = "txtBoxPrpBy";
            this.txtBoxPrpBy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBoxPrpBy.Properties.Appearance.Options.UseFont = true;
            this.txtBoxPrpBy.Size = new System.Drawing.Size(326, 26);
            this.txtBoxPrpBy.TabIndex = 40;
            // 
            // txtBoxDatePrp
            // 
            this.txtBoxDatePrp.Enabled = false;
            this.txtBoxDatePrp.Location = new System.Drawing.Point(641, 524);
            this.txtBoxDatePrp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxDatePrp.Name = "txtBoxDatePrp";
            this.txtBoxDatePrp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBoxDatePrp.Properties.Appearance.Options.UseFont = true;
            this.txtBoxDatePrp.Size = new System.Drawing.Size(162, 26);
            this.txtBoxDatePrp.TabIndex = 41;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(586, 594);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 19);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "Date";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(77, 594);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(105, 19);
            this.labelControl6.TabIndex = 46;
            this.labelControl6.Text = "Reviewed By";
            // 
            // txtBoxRevBy
            // 
            this.txtBoxRevBy.Enabled = false;
            this.txtBoxRevBy.Location = new System.Drawing.Point(208, 591);
            this.txtBoxRevBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxRevBy.Name = "txtBoxRevBy";
            this.txtBoxRevBy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBoxRevBy.Properties.Appearance.Options.UseFont = true;
            this.txtBoxRevBy.Size = new System.Drawing.Size(326, 26);
            this.txtBoxRevBy.TabIndex = 44;
            // 
            // txtBoxDateRev
            // 
            this.txtBoxDateRev.Enabled = false;
            this.txtBoxDateRev.Location = new System.Drawing.Point(641, 591);
            this.txtBoxDateRev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxDateRev.Name = "txtBoxDateRev";
            this.txtBoxDateRev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBoxDateRev.Properties.Appearance.Options.UseFont = true;
            this.txtBoxDateRev.Size = new System.Drawing.Size(162, 26);
            this.txtBoxDateRev.TabIndex = 45;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(586, 673);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 19);
            this.labelControl7.TabIndex = 51;
            this.labelControl7.Text = "Date";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(77, 673);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(103, 19);
            this.labelControl8.TabIndex = 50;
            this.labelControl8.Text = "Approved By";
            // 
            // txtBoxAppBy
            // 
            this.txtBoxAppBy.Enabled = false;
            this.txtBoxAppBy.Location = new System.Drawing.Point(208, 670);
            this.txtBoxAppBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxAppBy.Name = "txtBoxAppBy";
            this.txtBoxAppBy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBoxAppBy.Properties.Appearance.Options.UseFont = true;
            this.txtBoxAppBy.Size = new System.Drawing.Size(326, 26);
            this.txtBoxAppBy.TabIndex = 48;
            // 
            // txtBoxDateApp
            // 
            this.txtBoxDateApp.Enabled = false;
            this.txtBoxDateApp.Location = new System.Drawing.Point(641, 670);
            this.txtBoxDateApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxDateApp.Name = "txtBoxDateApp";
            this.txtBoxDateApp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBoxDateApp.Properties.Appearance.Options.UseFont = true;
            this.txtBoxDateApp.Size = new System.Drawing.Size(162, 26);
            this.txtBoxDateApp.TabIndex = 49;
            // 
            // btnRoleAsg
            // 
            this.btnRoleAsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoleAsg.BackColor = System.Drawing.Color.Navy;
            this.btnRoleAsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleAsg.ForeColor = System.Drawing.Color.White;
            this.btnRoleAsg.Location = new System.Drawing.Point(806, 375);
            this.btnRoleAsg.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoleAsg.Name = "btnRoleAsg";
            this.btnRoleAsg.Size = new System.Drawing.Size(140, 38);
            this.btnRoleAsg.TabIndex = 52;
            this.btnRoleAsg.Text = "Role Assg";
            this.btnRoleAsg.UseVisualStyleBackColor = false;
            this.btnRoleAsg.Click += new System.EventHandler(this.btnRoleAsg_Click);
            // 
            // EnvParamSelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 967);
            this.Controls.Add(this.btnRoleAsg);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtBoxAppBy);
            this.Controls.Add(this.txtBoxDateApp);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtBoxRevBy);
            this.Controls.Add(this.txtBoxDateRev);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtBoxPrpBy);
            this.Controls.Add(this.txtBoxDatePrp);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbboxRevStation);
            this.Controls.Add(this.cmbboxStation);
            this.Controls.Add(this.txtBoxStation);
            this.Controls.Add(this.lblEnv);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblStationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EnvParamSelScreen";
            this.Text = "Environmental Parameters Selection Screen";
            this.Load += new System.EventHandler(this.frmCreateRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxStation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbboxStation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbboxRevStation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxPrpBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDatePrp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxRevBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDateRev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxAppBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDateApp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblStationName;
        private DevExpress.XtraEditors.LabelControl lblRoomNumber;
        private System.Windows.Forms.Button btnFilter;
        private DevExpress.XtraEditors.TextEdit txtBoxStatus;
        private System.Windows.Forms.Label lblEnv;
        private DevExpress.XtraEditors.TextEdit txtBoxStation;
        private DevExpress.XtraEditors.ComboBoxEdit cmbboxStation;
        private DevExpress.XtraEditors.ComboBoxEdit cmbboxRevStation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtBoxPrpBy;
        private DevExpress.XtraEditors.TextEdit txtBoxDatePrp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtBoxRevBy;
        private DevExpress.XtraEditors.TextEdit txtBoxDateRev;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtBoxAppBy;
        private DevExpress.XtraEditors.TextEdit txtBoxDateApp;
        private System.Windows.Forms.Button btnRoleAsg;
    }
}