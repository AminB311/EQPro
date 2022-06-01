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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMianPg = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblPlanRev = new DevExpress.XtraEditors.LabelControl();
            this.tBoxPlanRev = new DevExpress.XtraEditors.TextEdit();
            this.tBoxPlantSearched = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxtxtPlant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxZoneID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPlanRev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPlantSearched.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxtxtPlant
            // 
            this.cmbBoxtxtPlant.Location = new System.Drawing.Point(251, 24);
            this.cmbBoxtxtPlant.Name = "cmbBoxtxtPlant";
            this.cmbBoxtxtPlant.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbBoxtxtPlant.Properties.Appearance.Options.UseFont = true;
            this.cmbBoxtxtPlant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxtxtPlant.Size = new System.Drawing.Size(216, 26);
            this.cmbBoxtxtPlant.TabIndex = 0;
            this.cmbBoxtxtPlant.SelectedIndexChanged += new System.EventHandler(this.cmbBoxtxtPlant_SelectedIndexChanged);
            // 
            // lblPlant
            // 
            this.lblPlant.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlant.Appearance.Options.UseFont = true;
            this.lblPlant.Location = new System.Drawing.Point(91, 27);
            this.lblPlant.Name = "lblPlant";
            this.lblPlant.Size = new System.Drawing.Size(43, 19);
            this.lblPlant.TabIndex = 1;
            this.lblPlant.Text = "Plant";
            // 
            // tBoxZoneID
            // 
            this.tBoxZoneID.Location = new System.Drawing.Point(251, 78);
            this.tBoxZoneID.Name = "tBoxZoneID";
            this.tBoxZoneID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxZoneID.Properties.Appearance.Options.UseFont = true;
            this.tBoxZoneID.Size = new System.Drawing.Size(216, 26);
            this.tBoxZoneID.TabIndex = 2;
            // 
            // lblZoneID
            // 
            this.lblZoneID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblZoneID.Appearance.Options.UseFont = true;
            this.lblZoneID.Location = new System.Drawing.Point(91, 88);
            this.lblZoneID.Name = "lblZoneID";
            this.lblZoneID.Size = new System.Drawing.Size(64, 19);
            this.lblZoneID.TabIndex = 3;
            this.lblZoneID.Text = "Zone ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(75, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(398, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(235, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 41);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMianPg
            // 
            this.btnMianPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMianPg.Location = new System.Drawing.Point(583, 281);
            this.btnMianPg.Name = "btnMianPg";
            this.btnMianPg.Size = new System.Drawing.Size(122, 41);
            this.btnMianPg.TabIndex = 7;
            this.btnMianPg.Text = "Main Page";
            this.btnMianPg.UseVisualStyleBackColor = true;
            this.btnMianPg.Click += new System.EventHandler(this.btnMianPg_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(91, 212);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(123, 19);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Plant Searched";
            // 
            // lblPlanRev
            // 
            this.lblPlanRev.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlanRev.Appearance.Options.UseFont = true;
            this.lblPlanRev.Location = new System.Drawing.Point(91, 147);
            this.lblPlanRev.Name = "lblPlanRev";
            this.lblPlanRev.Size = new System.Drawing.Size(72, 19);
            this.lblPlanRev.TabIndex = 9;
            this.lblPlanRev.Text = "Plan Rev";
            // 
            // tBoxPlanRev
            // 
            this.tBoxPlanRev.Location = new System.Drawing.Point(251, 141);
            this.tBoxPlanRev.Name = "tBoxPlanRev";
            this.tBoxPlanRev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxPlanRev.Properties.Appearance.Options.UseFont = true;
            this.tBoxPlanRev.Size = new System.Drawing.Size(216, 26);
            this.tBoxPlanRev.TabIndex = 10;
            // 
            // tBoxPlantSearched
            // 
            this.tBoxPlantSearched.Location = new System.Drawing.Point(251, 202);
            this.tBoxPlantSearched.Name = "tBoxPlantSearched";
            this.tBoxPlantSearched.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tBoxPlantSearched.Properties.Appearance.Options.UseFont = true;
            this.tBoxPlantSearched.Size = new System.Drawing.Size(216, 26);
            this.tBoxPlantSearched.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(492, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tBoxPlantSearched);
            this.Controls.Add(this.tBoxPlanRev);
            this.Controls.Add(this.lblPlanRev);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnMianPg);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblZoneID);
            this.Controls.Add(this.tBoxZoneID);
            this.Controls.Add(this.lblPlant);
            this.Controls.Add(this.cmbBoxtxtPlant);
            this.Name = "frmEnvironment";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEnvironment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxtxtPlant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxZoneID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPlanRev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxPlantSearched.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxtxtPlant;
        private DevExpress.XtraEditors.LabelControl lblPlant;
        private DevExpress.XtraEditors.TextEdit tBoxZoneID;
        private DevExpress.XtraEditors.LabelControl lblZoneID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMianPg;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblPlanRev;
        private DevExpress.XtraEditors.TextEdit tBoxPlanRev;
        private DevExpress.XtraEditors.TextEdit tBoxPlantSearched;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

