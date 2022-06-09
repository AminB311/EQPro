namespace EQProDXApp
{
    partial class frmCreateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateRoom));
            this.lblPlant = new DevExpress.XtraEditors.LabelControl();
            this.lblZoneID = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPlanRev = new DevExpress.XtraEditors.LabelControl();
            this.tBoxDescrip = new DevExpress.XtraEditors.TextEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEnv = new System.Windows.Forms.Label();
            this.lblCrtRoom = new System.Windows.Forms.Label();
            this.tBoxRoomNo = new DevExpress.XtraEditors.TextEdit();
            this.cmbStationName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxDescrip.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxRoomNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlant
            // 
            this.lblPlant.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlant.Appearance.Options.UseFont = true;
            this.lblPlant.Location = new System.Drawing.Point(144, 303);
            this.lblPlant.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlant.Name = "lblPlant";
            this.lblPlant.Size = new System.Drawing.Size(234, 19);
            this.lblPlant.TabIndex = 1;
            this.lblPlant.Text = "Select/Enter a Station Name";
            // 
            // lblZoneID
            // 
            this.lblZoneID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblZoneID.Appearance.Options.UseFont = true;
            this.lblZoneID.Location = new System.Drawing.Point(144, 353);
            this.lblZoneID.Margin = new System.Windows.Forms.Padding(2);
            this.lblZoneID.Name = "lblZoneID";
            this.lblZoneID.Size = new System.Drawing.Size(116, 19);
            this.lblZoneID.TabIndex = 3;
            this.lblZoneID.Text = "Room Number";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Navy;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(2, 2);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(146, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPlanRev
            // 
            this.lblPlanRev.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlanRev.Appearance.Options.UseFont = true;
            this.lblPlanRev.Location = new System.Drawing.Point(147, 400);
            this.lblPlanRev.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlanRev.Name = "lblPlanRev";
            this.lblPlanRev.Size = new System.Drawing.Size(92, 19);
            this.lblPlanRev.TabIndex = 9;
            this.lblPlanRev.Text = "Description";
            // 
            // tBoxDescrip
            // 
            this.tBoxDescrip.Location = new System.Drawing.Point(423, 397);
            this.tBoxDescrip.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxDescrip.Name = "tBoxDescrip";
            this.tBoxDescrip.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxDescrip.Properties.Appearance.Options.UseFont = true;
            this.tBoxDescrip.Size = new System.Drawing.Size(162, 26);
            this.tBoxDescrip.TabIndex = 3;
            this.tBoxDescrip.EditValueChanged += new System.EventHandler(this.tBoxPlanRev_EditValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(142, 535);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(538, 89);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // lblEnv
            // 
            this.lblEnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnv.AutoSize = true;
            this.lblEnv.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnv.ForeColor = System.Drawing.Color.Navy;
            this.lblEnv.Location = new System.Drawing.Point(135, 151);
            this.lblEnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnv.Name = "lblEnv";
            this.lblEnv.Size = new System.Drawing.Size(411, 50);
            this.lblEnv.TabIndex = 37;
            this.lblEnv.Text = "Environmental Form";
            this.lblEnv.Click += new System.EventHandler(this.lblEnv_Click);
            // 
            // lblCrtRoom
            // 
            this.lblCrtRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCrtRoom.AutoSize = true;
            this.lblCrtRoom.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrtRoom.ForeColor = System.Drawing.Color.Navy;
            this.lblCrtRoom.Location = new System.Drawing.Point(138, 222);
            this.lblCrtRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrtRoom.Name = "lblCrtRoom";
            this.lblCrtRoom.Size = new System.Drawing.Size(242, 45);
            this.lblCrtRoom.TabIndex = 38;
            this.lblCrtRoom.Text = "Create Room";
            // 
            // tBoxRoomNo
            // 
            this.tBoxRoomNo.Location = new System.Drawing.Point(423, 350);
            this.tBoxRoomNo.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxRoomNo.Name = "tBoxRoomNo";
            this.tBoxRoomNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxRoomNo.Properties.Appearance.Options.UseFont = true;
            this.tBoxRoomNo.Size = new System.Drawing.Size(162, 26);
            this.tBoxRoomNo.TabIndex = 2;
            // 
            // cmbStationName
            // 
            this.cmbStationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStationName.FormattingEnabled = true;
            this.cmbStationName.Location = new System.Drawing.Point(423, 298);
            this.cmbStationName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStationName.Name = "cmbStationName";
            this.cmbStationName.Size = new System.Drawing.Size(162, 30);
            this.cmbStationName.TabIndex = 1;
            // 
            // frmCreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 679);
            this.Controls.Add(this.tBoxRoomNo);
            this.Controls.Add(this.cmbStationName);
            this.Controls.Add(this.lblCrtRoom);
            this.Controls.Add(this.lblEnv);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tBoxDescrip);
            this.Controls.Add(this.lblPlanRev);
            this.Controls.Add(this.lblZoneID);
            this.Controls.Add(this.lblPlant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCreateRoom";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.frmEnvironment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBoxDescrip.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBoxRoomNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblPlant;
        private DevExpress.XtraEditors.LabelControl lblZoneID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraEditors.LabelControl lblPlanRev;
        private DevExpress.XtraEditors.TextEdit tBoxDescrip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblEnv;
        private System.Windows.Forms.Label lblCrtRoom;
        private System.Windows.Forms.ComboBox cmbStationName;
        private DevExpress.XtraEditors.TextEdit tBoxRoomNo;
    }
}

