namespace EQProDXApp
{
    partial class frmEnvParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvParam));
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.pnlEnvParam = new System.Windows.Forms.Panel();
            this.btnRevision = new System.Windows.Forms.Button();
            this.btnEnvParam = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dockPanel1.SuspendLayout();
            this.pnlEnvParam.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 421);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("3774a8e5-5e12-406e-a461-51dd062522ff");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 450);
            this.dockPanel1.Text = "dockPanel1";
            // 
            // pnlEnvParam
            // 
            this.pnlEnvParam.BackColor = System.Drawing.Color.Navy;
            this.pnlEnvParam.Controls.Add(this.btnRevision);
            this.pnlEnvParam.Controls.Add(this.btnEnvParam);
            this.pnlEnvParam.Controls.Add(this.btnRoom);
            this.pnlEnvParam.Controls.Add(this.btnClose);
            this.pnlEnvParam.Controls.Add(this.panel2);
            this.pnlEnvParam.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEnvParam.Location = new System.Drawing.Point(0, 0);
            this.pnlEnvParam.Name = "pnlEnvParam";
            this.pnlEnvParam.Size = new System.Drawing.Size(242, 753);
            this.pnlEnvParam.TabIndex = 14;
            this.pnlEnvParam.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnRevision
            // 
            this.btnRevision.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRevision.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevision.FlatAppearance.BorderSize = 0;
            this.btnRevision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevision.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevision.ForeColor = System.Drawing.Color.White;
            this.btnRevision.Location = new System.Drawing.Point(0, 247);
            this.btnRevision.Name = "btnRevision";
            this.btnRevision.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnRevision.Size = new System.Drawing.Size(242, 81);
            this.btnRevision.TabIndex = 15;
            this.btnRevision.Text = "Create Revision";
            this.btnRevision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevision.UseVisualStyleBackColor = false;
            this.btnRevision.Click += new System.EventHandler(this.btnRevision_Click);
            // 
            // btnEnvParam
            // 
            this.btnEnvParam.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnvParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnvParam.FlatAppearance.BorderSize = 0;
            this.btnEnvParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvParam.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvParam.ForeColor = System.Drawing.Color.White;
            this.btnEnvParam.Location = new System.Drawing.Point(0, 166);
            this.btnEnvParam.Name = "btnEnvParam";
            this.btnEnvParam.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnEnvParam.Size = new System.Drawing.Size(242, 81);
            this.btnEnvParam.TabIndex = 14;
            this.btnEnvParam.Text = "Open Env. Parameters";
            this.btnEnvParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvParam.UseVisualStyleBackColor = false;
            this.btnEnvParam.Click += new System.EventHandler(this.btnEnvParam_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Location = new System.Drawing.Point(0, 79);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnRoom.Size = new System.Drawing.Size(242, 87);
            this.btnRoom.TabIndex = 13;
            this.btnRoom.Text = "Create New Room";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 697);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(242, 56);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 79);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // centerPanel
            // 
            this.centerPanel.AllowDrop = true;
            this.centerPanel.Controls.Add(this.panel3);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(242, 0);
            this.centerPanel.MinimumSize = new System.Drawing.Size(1442, 792);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1442, 792);
            this.centerPanel.TabIndex = 15;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.centerPanel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1442, 79);
            this.panel3.TabIndex = 0;
            // 
            // frmEnvParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 753);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.pnlEnvParam);
            this.Controls.Add(this.dockPanel1);
            this.MinimumSize = new System.Drawing.Size(1442, 792);
            this.Name = "frmEnvParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Environmental Parameters";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEnvParam_Load);
            this.dockPanel1.ResumeLayout(false);
            this.pnlEnvParam.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEnvParam;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnvParam;
        private System.Windows.Forms.Button btnRevision;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}