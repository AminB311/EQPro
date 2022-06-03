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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel_UserAccount = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.dockPanel_EnvParam = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel_EquipList = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel_Utilities = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.dockPanel_UserAccount.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.dockPanel_EnvParam.SuspendLayout();
            this.dockPanel_EquipList.SuspendLayout();
            this.dockPanel_Utilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hideContainerLeft.Controls.Add(this.dockPanel_UserAccount);
            this.hideContainerLeft.Controls.Add(this.dockPanel_EnvParam);
            this.hideContainerLeft.Controls.Add(this.dockPanel_EquipList);
            this.hideContainerLeft.Controls.Add(this.dockPanel_Utilities);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(21, 999);
            // 
            // dockPanel_UserAccount
            // 
            this.dockPanel_UserAccount.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dockPanel_UserAccount.Appearance.Options.UseBackColor = true;
            this.dockPanel_UserAccount.Controls.Add(this.dockPanel1_Container);
            this.dockPanel_UserAccount.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel_UserAccount.ID = new System.Guid("10f75dec-5f08-4b28-ba6e-0c3932d79f88");
            this.dockPanel_UserAccount.Location = new System.Drawing.Point(0, 0);
            this.dockPanel_UserAccount.Name = "dockPanel_UserAccount";
            this.dockPanel_UserAccount.OriginalSize = new System.Drawing.Size(293, 200);
            this.dockPanel_UserAccount.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel_UserAccount.SavedIndex = 0;
            this.dockPanel_UserAccount.Size = new System.Drawing.Size(293, 999);
            this.dockPanel_UserAccount.Text = "User Account";
            this.dockPanel_UserAccount.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            this.dockPanel_UserAccount.Click += new System.EventHandler(this.dockPanel1_Click);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.picBoxUser);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(286, 970);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackgroundImage = global::EQProDXApp.Properties.Resources.HandShakeBusiness_Depositphotos_5;
            this.picBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxUser.Location = new System.Drawing.Point(53, 52);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(139, 98);
            this.picBoxUser.TabIndex = 0;
            this.picBoxUser.TabStop = false;
            this.picBoxUser.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dockPanel_EnvParam
            // 
            this.dockPanel_EnvParam.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dockPanel_EnvParam.Appearance.Options.UseBackColor = true;
            this.dockPanel_EnvParam.Controls.Add(this.dockPanel2_Container);
            this.dockPanel_EnvParam.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel_EnvParam.ID = new System.Guid("0c700e13-cddd-47bf-95b0-448b3d70bd60");
            this.dockPanel_EnvParam.Location = new System.Drawing.Point(0, 0);
            this.dockPanel_EnvParam.Name = "dockPanel_EnvParam";
            this.dockPanel_EnvParam.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel_EnvParam.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel_EnvParam.SavedIndex = 0;
            this.dockPanel_EnvParam.Size = new System.Drawing.Size(200, 999);
            this.dockPanel_EnvParam.Text = "Environmental Parameters";
            this.dockPanel_EnvParam.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(193, 970);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanel_EquipList
            // 
            this.dockPanel_EquipList.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dockPanel_EquipList.Appearance.Options.UseBackColor = true;
            this.dockPanel_EquipList.Controls.Add(this.dockPanel4_Container);
            this.dockPanel_EquipList.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel_EquipList.ID = new System.Guid("3503b550-e2bd-4a08-a566-88b1a2414604");
            this.dockPanel_EquipList.Location = new System.Drawing.Point(-200, 0);
            this.dockPanel_EquipList.Name = "dockPanel_EquipList";
            this.dockPanel_EquipList.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel_EquipList.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel_EquipList.SavedIndex = 1;
            this.dockPanel_EquipList.Size = new System.Drawing.Size(200, 999);
            this.dockPanel_EquipList.Text = "EQ Equipment List";
            this.dockPanel_EquipList.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(193, 970);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // dockPanel_Utilities
            // 
            this.dockPanel_Utilities.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dockPanel_Utilities.Appearance.Options.UseBackColor = true;
            this.dockPanel_Utilities.Controls.Add(this.controlContainer1);
            this.dockPanel_Utilities.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel_Utilities.ID = new System.Guid("96e07f2f-8216-47f0-9276-564f1fc1a57b");
            this.dockPanel_Utilities.Location = new System.Drawing.Point(0, 0);
            this.dockPanel_Utilities.Name = "dockPanel_Utilities";
            this.dockPanel_Utilities.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel_Utilities.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel_Utilities.SavedIndex = 0;
            this.dockPanel_Utilities.Size = new System.Drawing.Size(200, 999);
            this.dockPanel_Utilities.Text = "Utilities";
            this.dockPanel_Utilities.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // controlContainer1
            // 
            this.controlContainer1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.controlContainer1.Location = new System.Drawing.Point(3, 26);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(193, 970);
            this.controlContainer1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1584, 999);
            this.Controls.Add(this.hideContainerLeft);
            this.MaximumSize = new System.Drawing.Size(1600, 1038);
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.dockPanel_UserAccount.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.dockPanel_EnvParam.ResumeLayout(false);
            this.dockPanel_EquipList.ResumeLayout(false);
            this.dockPanel_Utilities.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel_EquipList;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel_EnvParam;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel_UserAccount;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel_Utilities;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private System.Windows.Forms.PictureBox picBoxUser;
    }
}