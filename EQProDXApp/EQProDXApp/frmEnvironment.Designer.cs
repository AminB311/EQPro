namespace EQProDXApp
{
    partial class frmEnvironment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvironment));
            this.cmbBoxtxtPlant = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPlant = new DevExpress.XtraEditors.LabelControl();
            this.tBoxZoneID = new DevExpress.XtraEditors.TextEdit();
            this.lblZoneID = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMianPg = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblPlanRev = new DevExpress.XtraEditors.LabelControl();
            this.tBoxPlanRev = new DevExpress.XtraEditors.TextEdit();
            this.tBoxPlantSearched = new DevExpress.XtraEditors.TextEdit();
            this.btnClear = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEnv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxtxtPlant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxZoneID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPlanRev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPlantSearched.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBoxtxtPlant
            // 
            //this.cmbBoxtxtPlant.Location = new System.Drawing.Point(462, 112);
            //this.cmbBoxtxtPlant.Margin = new System.Windows.Forms.Padding(2);
            //this.cmbBoxtxtPlant.Name = "cmbBoxtxtPlant";
            //this.cmbBoxtxtPlant.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            //this.cmbBoxtxtPlant.Properties.Appearance.Options.UseFont = true;
            //this.cmbBoxtxtPlant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            //new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            //this.cmbBoxtxtPlant.Size = new System.Drawing.Size(162, 26);
            //this.cmbBoxtxtPlant.TabIndex = 0;

            this.cmbBoxtxtPlant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxtxtPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.cmbBoxtxtPlant.FormattingEnabled = true;
            this.cmbBoxtxtPlant.Location = new System.Drawing.Point(462, 112);
            this.cmbBoxtxtPlant.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxtxtPlant.Name = "cmbBoxtxtPlant";
            this.cmbBoxtxtPlant.Size = new System.Drawing.Size(125, 30);
            this.cmbBoxtxtPlant.TabIndex = 1;

            this.cmbBoxtxtPlant.SelectedIndexChanged += new System.EventHandler(this.cmbBoxtxtPlant_SelectedIndexChanged);
            // 
            // lblPlant
            // 
            this.lblPlant.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlant.Appearance.Options.UseFont = true;
            this.lblPlant.Location = new System.Drawing.Point(268, 115);
            this.lblPlant.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlant.Name = "lblPlant";
            this.lblPlant.Size = new System.Drawing.Size(43, 19);
            this.lblPlant.TabIndex = 1;
            this.lblPlant.Text = "Plant";
            // 
            // tBoxZoneID
            // 
            this.tBoxZoneID.Location = new System.Drawing.Point(462, 155);
            this.tBoxZoneID.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxZoneID.Name = "tBoxZoneID";
            this.tBoxZoneID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxZoneID.Properties.Appearance.Options.UseFont = true;
            this.tBoxZoneID.Size = new System.Drawing.Size(162, 26);
            this.tBoxZoneID.TabIndex = 2;
            // 
            // lblZoneID
            // 
            this.lblZoneID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblZoneID.Appearance.Options.UseFont = true;
            this.lblZoneID.Location = new System.Drawing.Point(268, 165);
            this.lblZoneID.Margin = new System.Windows.Forms.Padding(2);
            this.lblZoneID.Name = "lblZoneID";
            this.lblZoneID.Size = new System.Drawing.Size(64, 19);
            this.lblZoneID.TabIndex = 3;
            this.lblZoneID.Text = "Zone ID";
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
            this.btnClose.Location = new System.Drawing.Point(434, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Navy;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(146, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMianPg
            // 
            this.btnMianPg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMianPg.BackColor = System.Drawing.Color.Navy;
            this.btnMianPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMianPg.ForeColor = System.Drawing.Color.White;
            this.btnMianPg.Location = new System.Drawing.Point(290, 2);
            this.btnMianPg.Margin = new System.Windows.Forms.Padding(2);
            this.btnMianPg.Name = "btnMianPg";
            this.btnMianPg.Size = new System.Drawing.Size(140, 38);
            this.btnMianPg.TabIndex = 7;
            this.btnMianPg.Text = "Main Page";
            this.btnMianPg.UseVisualStyleBackColor = false;
            this.btnMianPg.Click += new System.EventHandler(this.btnMianPg_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(268, 265);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(123, 19);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Plant Searched";
            // 
            // lblPlanRev
            // 
            this.lblPlanRev.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlanRev.Appearance.Options.UseFont = true;
            this.lblPlanRev.Location = new System.Drawing.Point(268, 212);
            this.lblPlanRev.Margin = new System.Windows.Forms.Padding(2);
            this.lblPlanRev.Name = "lblPlanRev";
            this.lblPlanRev.Size = new System.Drawing.Size(72, 19);
            this.lblPlanRev.TabIndex = 9;
            this.lblPlanRev.Text = "Plan Rev";
            // 
            // tBoxPlanRev
            // 
            this.tBoxPlanRev.Location = new System.Drawing.Point(462, 207);
            this.tBoxPlanRev.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPlanRev.Name = "tBoxPlanRev";
            this.tBoxPlanRev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxPlanRev.Properties.Appearance.Options.UseFont = true;
            this.tBoxPlanRev.Size = new System.Drawing.Size(162, 26);
            this.tBoxPlanRev.TabIndex = 10;
            // 
            // tBoxPlantSearched
            // 
            this.tBoxPlantSearched.Location = new System.Drawing.Point(462, 256);
            this.tBoxPlantSearched.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPlantSearched.Name = "tBoxPlantSearched";
            this.tBoxPlantSearched.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxPlantSearched.Properties.Appearance.Options.UseFont = true;
            this.tBoxPlantSearched.Size = new System.Drawing.Size(162, 26);
            this.tBoxPlantSearched.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.SlateGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(650, 110);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 30);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnMianPg);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(57, 351);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(892, 89);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // lblEnv
            // 
            this.lblEnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnv.AutoSize = true;
            this.lblEnv.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnv.ForeColor = System.Drawing.Color.Navy;
            this.lblEnv.Location = new System.Drawing.Point(48, 21);
            this.lblEnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnv.Name = "lblEnv";
            this.lblEnv.Size = new System.Drawing.Size(411, 50);
            this.lblEnv.TabIndex = 37;
            this.lblEnv.Text = "Environmental Form";
            // 
            // frmEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 519);
            this.Controls.Add(this.lblEnv);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tBoxPlantSearched);
            this.Controls.Add(this.tBoxPlanRev);
            this.Controls.Add(this.lblPlanRev);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblZoneID);
            this.Controls.Add(this.tBoxZoneID);
            this.Controls.Add(this.lblPlant);
            this.Controls.Add(this.cmbBoxtxtPlant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEnvironment";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.frmEnvironment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxtxtPlant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxZoneID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPlanRev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPlantSearched.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxtxtPlant;
        private DevExpress.XtraEditors.LabelControl lblPlant;
        private DevExpress.XtraEditors.TextEdit tBoxZoneID;
        private DevExpress.XtraEditors.LabelControl lblZoneID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMianPg;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblPlanRev;
        private DevExpress.XtraEditors.TextEdit tBoxPlanRev;
        private DevExpress.XtraEditors.TextEdit tBoxPlantSearched;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblEnv;
    }
}

