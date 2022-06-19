namespace EQProDXApp.EnvironmentalParameters
{
    partial class frmRoleAssignment
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
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblEnv = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbBoxSelLine = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblRoomNumber = new DevExpress.XtraEditors.LabelControl();
            this.flowPanelPrepearer = new System.Windows.Forms.FlowLayoutPanel();
            this.chkEditToPrep = new DevExpress.XtraEditors.CheckEdit();
            this.cmbBoxPrepearer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblStationName = new DevExpress.XtraEditors.LabelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbBoxReviewer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkEditToRev = new DevExpress.XtraEditors.CheckEdit();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbBoxApprover = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkEditToApp = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxSelLine.Properties)).BeginInit();
            this.flowPanelPrepearer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEditToPrep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxPrepearer.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxReviewer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEditToRev.Properties)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxApprover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEditToApp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAssign.BackColor = System.Drawing.Color.Navy;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(112, 752);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(140, 38);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.lblEnv.Size = new System.Drawing.Size(581, 50);
            this.lblEnv.TabIndex = 37;
            this.lblEnv.Text = "Role Assignments and E-Mail";
            this.lblEnv.Click += new System.EventHandler(this.lblEnv_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(389, 752);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 38);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbBoxSelLine
            // 
            this.cmbBoxSelLine.EditValue = "";
            this.cmbBoxSelLine.Location = new System.Drawing.Point(45, 686);
            this.cmbBoxSelLine.Name = "cmbBoxSelLine";
            this.cmbBoxSelLine.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbBoxSelLine.Properties.Appearance.Options.UseFont = true;
            this.cmbBoxSelLine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxSelLine.Size = new System.Drawing.Size(518, 26);
            this.cmbBoxSelLine.TabIndex = 2;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomNumber.Appearance.Options.UseFont = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(48, 644);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(2);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(244, 19);
            this.lblRoomNumber.TabIndex = 3;
            this.lblRoomNumber.Text = "E-Mail Subject Line Selections";
            // 
            // flowPanelPrepearer
            // 
            this.flowPanelPrepearer.Controls.Add(this.lblStationName);
            this.flowPanelPrepearer.Controls.Add(this.cmbBoxPrepearer);
            this.flowPanelPrepearer.Controls.Add(this.chkEditToPrep);
            this.flowPanelPrepearer.Location = new System.Drawing.Point(54, 250);
            this.flowPanelPrepearer.Name = "flowPanelPrepearer";
            this.flowPanelPrepearer.Size = new System.Drawing.Size(518, 96);
            this.flowPanelPrepearer.TabIndex = 0;
            // 
            // chkEditToPrep
            // 
            this.chkEditToPrep.Location = new System.Drawing.Point(315, 26);
            this.chkEditToPrep.Name = "chkEditToPrep";
            this.chkEditToPrep.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkEditToPrep.Properties.Appearance.Options.UseFont = true;
            this.chkEditToPrep.Properties.Caption = "Notify";
            this.chkEditToPrep.Size = new System.Drawing.Size(75, 23);
            this.chkEditToPrep.TabIndex = 56;
            // 
            // cmbBoxPrepearer
            // 
            this.cmbBoxPrepearer.EditValue = "";
            this.cmbBoxPrepearer.Location = new System.Drawing.Point(3, 26);
            this.cmbBoxPrepearer.Name = "cmbBoxPrepearer";
            this.cmbBoxPrepearer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbBoxPrepearer.Properties.Appearance.Options.UseFont = true;
            this.cmbBoxPrepearer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxPrepearer.Size = new System.Drawing.Size(306, 26);
            this.cmbBoxPrepearer.TabIndex = 54;
            // 
            // lblStationName
            // 
            this.lblStationName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblStationName.Appearance.Options.UseFont = true;
            this.lblStationName.Location = new System.Drawing.Point(2, 2);
            this.lblStationName.Margin = new System.Windows.Forms.Padding(2);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(244, 19);
            this.lblStationName.TabIndex = 55;
            this.lblStationName.Text = "Prepearer Notificaton Options";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelControl1);
            this.flowLayoutPanel1.Controls.Add(this.cmbBoxReviewer);
            this.flowLayoutPanel1.Controls.Add(this.chkEditToRev);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 378);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(518, 96);
            this.flowLayoutPanel1.TabIndex = 53;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(239, 19);
            this.labelControl1.TabIndex = 55;
            this.labelControl1.Text = "Reviewer Notificaton Options";
            // 
            // cmbBoxReviewer
            // 
            this.cmbBoxReviewer.EditValue = "";
            this.cmbBoxReviewer.Location = new System.Drawing.Point(3, 26);
            this.cmbBoxReviewer.Name = "cmbBoxReviewer";
            this.cmbBoxReviewer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbBoxReviewer.Properties.Appearance.Options.UseFont = true;
            this.cmbBoxReviewer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxReviewer.Size = new System.Drawing.Size(306, 26);
            this.cmbBoxReviewer.TabIndex = 54;
            // 
            // chkEditToRev
            // 
            this.chkEditToRev.Location = new System.Drawing.Point(315, 26);
            this.chkEditToRev.Name = "chkEditToRev";
            this.chkEditToRev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkEditToRev.Properties.Appearance.Options.UseFont = true;
            this.chkEditToRev.Properties.Caption = "Notify";
            this.chkEditToRev.Size = new System.Drawing.Size(75, 23);
            this.chkEditToRev.TabIndex = 56;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelControl2);
            this.flowLayoutPanel2.Controls.Add(this.cmbBoxApprover);
            this.flowLayoutPanel2.Controls.Add(this.chkEditToApp);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(48, 511);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(518, 96);
            this.flowLayoutPanel2.TabIndex = 54;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(2, 2);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(237, 19);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "Approver Notificaton Options";
            // 
            // cmbBoxApprover
            // 
            this.cmbBoxApprover.EditValue = "";
            this.cmbBoxApprover.Location = new System.Drawing.Point(3, 26);
            this.cmbBoxApprover.Name = "cmbBoxApprover";
            this.cmbBoxApprover.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbBoxApprover.Properties.Appearance.Options.UseFont = true;
            this.cmbBoxApprover.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxApprover.Size = new System.Drawing.Size(306, 26);
            this.cmbBoxApprover.TabIndex = 54;
            // 
            // chkEditToApp
            // 
            this.chkEditToApp.Location = new System.Drawing.Point(315, 26);
            this.chkEditToApp.Name = "chkEditToApp";
            this.chkEditToApp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkEditToApp.Properties.Appearance.Options.UseFont = true;
            this.chkEditToApp.Properties.Caption = "Notify";
            this.chkEditToApp.Size = new System.Drawing.Size(75, 23);
            this.chkEditToApp.TabIndex = 56;
            // 
            // frmRoleAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 967);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.cmbBoxSelLine);
            this.Controls.Add(this.flowPanelPrepearer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblEnv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRoleAssignment";
            this.Text = "Environmental Parameters Selection Screen";
            this.Load += new System.EventHandler(this.frmRoleAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxSelLine.Properties)).EndInit();
            this.flowPanelPrepearer.ResumeLayout(false);
            this.flowPanelPrepearer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEditToPrep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxPrepearer.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxReviewer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEditToRev.Properties)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxApprover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEditToApp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblEnv;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxSelLine;
        private DevExpress.XtraEditors.LabelControl lblRoomNumber;
        private System.Windows.Forms.FlowLayoutPanel flowPanelPrepearer;
        private DevExpress.XtraEditors.LabelControl lblStationName;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxPrepearer;
        private DevExpress.XtraEditors.CheckEdit chkEditToPrep;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxReviewer;
        private DevExpress.XtraEditors.CheckEdit chkEditToRev;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxApprover;
        private DevExpress.XtraEditors.CheckEdit chkEditToApp;
    }
}