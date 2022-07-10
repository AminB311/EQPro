namespace EQProDXApp.EnvironmentalParameters
{
    partial class frmEnvParamSelScreen
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblEnv = new System.Windows.Forms.Label();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbBoxStationName = new System.Windows.Forms.ComboBox();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataGridRoom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxPrpBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDatePrp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxRevBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDateRev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxAppBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDateApp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStationName
            // 
            this.lblStationName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblStationName.Appearance.Options.UseFont = true;
            this.lblStationName.Location = new System.Drawing.Point(69, 179);
            this.lblStationName.Margin = new System.Windows.Forms.Padding(2);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(121, 19);
            this.lblStationName.TabIndex = 1;
            this.lblStationName.Text = "Station Details";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilter.BackColor = System.Drawing.Color.Navy;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(806, 657);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(140, 38);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEnv
            // 
            this.lblEnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnv.AutoSize = true;
            this.lblEnv.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnv.ForeColor = System.Drawing.Color.Navy;
            this.lblEnv.Location = new System.Drawing.Point(60, 90);
            this.lblEnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnv.Name = "lblEnv";
            this.lblEnv.Size = new System.Drawing.Size(854, 50);
            this.lblEnv.TabIndex = 37;
            this.lblEnv.Text = "Environmental Parameters Selection Screen";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(576, 666);
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
            this.labelControl4.Location = new System.Drawing.Point(67, 666);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 19);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Prepeared By";
            // 
            // txtBoxPrpBy
            // 
            this.txtBoxPrpBy.Enabled = false;
            this.txtBoxPrpBy.Location = new System.Drawing.Point(198, 663);
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
            this.txtBoxDatePrp.Location = new System.Drawing.Point(631, 663);
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
            this.labelControl5.Location = new System.Drawing.Point(576, 733);
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
            this.labelControl6.Location = new System.Drawing.Point(67, 733);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(105, 19);
            this.labelControl6.TabIndex = 46;
            this.labelControl6.Text = "Reviewed By";
            // 
            // txtBoxRevBy
            // 
            this.txtBoxRevBy.Enabled = false;
            this.txtBoxRevBy.Location = new System.Drawing.Point(198, 730);
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
            this.txtBoxDateRev.Location = new System.Drawing.Point(631, 730);
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
            this.labelControl7.Location = new System.Drawing.Point(576, 812);
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
            this.labelControl8.Location = new System.Drawing.Point(67, 812);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(103, 19);
            this.labelControl8.TabIndex = 50;
            this.labelControl8.Text = "Approved By";
            // 
            // txtBoxAppBy
            // 
            this.txtBoxAppBy.Enabled = false;
            this.txtBoxAppBy.Location = new System.Drawing.Point(198, 809);
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
            this.txtBoxDateApp.Location = new System.Drawing.Point(631, 809);
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
            this.btnRoleAsg.Location = new System.Drawing.Point(806, 724);
            this.btnRoleAsg.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoleAsg.Name = "btnRoleAsg";
            this.btnRoleAsg.Size = new System.Drawing.Size(140, 38);
            this.btnRoleAsg.TabIndex = 52;
            this.btnRoleAsg.Text = "Role Assg";
            this.btnRoleAsg.UseVisualStyleBackColor = false;
            this.btnRoleAsg.Click += new System.EventHandler(this.btnRoleAsg_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(806, 803);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 38);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbBoxStationName
            // 
            this.cmbBoxStationName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxStationName.FormattingEnabled = true;
            this.cmbBoxStationName.Location = new System.Drawing.Point(232, 171);
            this.cmbBoxStationName.Name = "cmbBoxStationName";
            this.cmbBoxStationName.Size = new System.Drawing.Size(666, 27);
            this.cmbBoxStationName.TabIndex = 63;
            this.cmbBoxStationName.SelectedIndexChanged += new System.EventHandler(this.cmBoxRoomNo_SelectedIndexChanged);
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(221, 309);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.gridLookUpEdit1.TabIndex = 65;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // dataGridRoom
            // 
            this.dataGridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoom.Location = new System.Drawing.Point(67, 237);
            this.dataGridRoom.Name = "dataGridRoom";
            this.dataGridRoom.Size = new System.Drawing.Size(831, 380);
            this.dataGridRoom.TabIndex = 66;
            // 
            // frmEnvParamSelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 967);
            this.Controls.Add(this.dataGridRoom);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.cmbBoxStationName);
            this.Controls.Add(this.btnClose);
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
            this.Controls.Add(this.lblEnv);
            this.Controls.Add(this.lblStationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEnvParamSelScreen";
            this.Text = "Environmental Parameters Selection Screen";
            this.Load += new System.EventHandler(this.frmEnvParamSelScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxPrpBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDatePrp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxRevBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDateRev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxAppBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDateApp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblStationName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblEnv;
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbBoxStationName;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.DataGridView dataGridRoom;
    }
}