﻿namespace EQProDXApp
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
            this.lblStationName = new DevExpress.XtraEditors.LabelControl();
            this.lblRoomNumber = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtBoxDescription = new DevExpress.XtraEditors.TextEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEnv = new System.Windows.Forms.Label();
            this.txtBoxRoomNo = new DevExpress.XtraEditors.TextEdit();
            this.cmbboxStation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDescription.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxRoomNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStationName
            // 
            this.lblStationName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblStationName.Appearance.Options.UseFont = true;
            this.lblStationName.Location = new System.Drawing.Point(300, 350);
            this.lblStationName.Margin = new System.Windows.Forms.Padding(2);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(126, 38);
            this.lblStationName.TabIndex = 1;
            this.lblStationName.Text = "Select/Enter\r\na Station Name";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomNumber.Appearance.Options.UseFont = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(300, 400);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(2);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(116, 19);
            this.lblRoomNumber.TabIndex = 3;
            this.lblRoomNumber.Text = "Room Number";
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
            this.btnAdd.Text = "Add Room";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(290, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Appearance.Options.UseFont = true;
            this.lblDescription.Location = new System.Drawing.Point(300, 450);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(92, 19);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(500, 456);
            this.txtBoxDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBoxDescription.Properties.Appearance.Options.UseFont = true;
            this.txtBoxDescription.Size = new System.Drawing.Size(264, 26);
            this.txtBoxDescription.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(125, 521);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 47);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Navy;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(146, 2);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEnv
            // 
            this.lblEnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnv.AutoSize = true;
            this.lblEnv.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnv.ForeColor = System.Drawing.Color.Navy;
            this.lblEnv.Location = new System.Drawing.Point(57, 217);
            this.lblEnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnv.Name = "lblEnv";
            this.lblEnv.Size = new System.Drawing.Size(271, 50);
            this.lblEnv.TabIndex = 37;
            this.lblEnv.Text = "Create Room";
            // 
            // txtBoxRoomNo
            // 
            this.txtBoxRoomNo.Location = new System.Drawing.Point(500, 400);
            this.txtBoxRoomNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBoxRoomNo.Name = "txtBoxRoomNo";
            this.txtBoxRoomNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBoxRoomNo.Properties.Appearance.Options.UseFont = true;
            this.txtBoxRoomNo.Size = new System.Drawing.Size(264, 26);
            this.txtBoxRoomNo.TabIndex = 2;
            // 
            // cmbboxStation
            // 
            this.cmbboxStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbboxStation.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxStation.FormattingEnabled = true;
            this.cmbboxStation.Location = new System.Drawing.Point(500, 350);
            this.cmbboxStation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbboxStation.Name = "cmbboxStation";
            this.cmbboxStation.Size = new System.Drawing.Size(264, 31);
            this.cmbboxStation.TabIndex = 1;
            this.cmbboxStation.SelectedIndexChanged += new System.EventHandler(this.cmbboxStation_SelectedIndexChanged);
            // 
            // frmCreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 967);
            this.Controls.Add(this.cmbboxStation);
            this.Controls.Add(this.txtBoxRoomNo);
            this.Controls.Add(this.lblEnv);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblStationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCreateRoom";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.frmCreateRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxDescription.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxRoomNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblStationName;
        private DevExpress.XtraEditors.LabelControl lblRoomNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.TextEdit txtBoxDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblEnv;
        private DevExpress.XtraEditors.TextEdit txtBoxRoomNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbboxStation;
    }
}

