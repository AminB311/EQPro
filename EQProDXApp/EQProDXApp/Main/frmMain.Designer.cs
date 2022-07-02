namespace EQProDXApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnEnvParam = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dockPanel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Navy;
            this.pnlMain.Controls.Add(this.btnUsers);
            this.pnlMain.Controls.Add(this.btnEnvParam);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(242, 753);
            this.pnlMain.TabIndex = 14;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 166);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(242, 81);
            this.btnUsers.TabIndex = 14;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnEnvParam
            // 
            this.btnEnvParam.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnvParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnvParam.FlatAppearance.BorderSize = 0;
            this.btnEnvParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvParam.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvParam.ForeColor = System.Drawing.Color.White;
            this.btnEnvParam.Location = new System.Drawing.Point(0, 79);
            this.btnEnvParam.Name = "btnEnvParam";
            this.btnEnvParam.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnEnvParam.Size = new System.Drawing.Size(242, 87);
            this.btnEnvParam.TabIndex = 13;
            this.btnEnvParam.Text = "Environmental  Parameters";
            this.btnEnvParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvParam.UseVisualStyleBackColor = false;
            this.btnEnvParam.Click += new System.EventHandler(this.btnEnvParam_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 697);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(242, 56);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 79);
            this.panel2.TabIndex = 0;
            // 
            // centerPanel
            // 
            this.centerPanel.AllowDrop = true;
            this.centerPanel.Controls.Add(this.picMain);
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
            // picMain
            // 
            this.picMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMain.BackgroundImage")));
            this.picMain.Image = global::EQProDXApp.Properties.Resources.PlantImage;
            this.picMain.Location = new System.Drawing.Point(6, 84);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(1173, 669);
            this.picMain.TabIndex = 1;
            this.picMain.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 753);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.dockPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1442, 792);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EQ Pro Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.dockPanel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnEnvParam;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.PictureBox picMain;
    }
}