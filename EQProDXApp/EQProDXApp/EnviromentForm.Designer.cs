namespace EQProDXApp
{
    partial class EnviromentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPlantID = new System.Windows.Forms.ComboBox();
            this.usersMainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);

            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZoneID = new System.Windows.Forms.TextBox();
            this.textBoxPlanRev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPlantSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.testTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.usersMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            ((System.ComponentModel.ISupportInitialize)(this.usersMainBindingSource1)).BeginInit();
 
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plant ID";
            // 
            // comboBoxPlantID
            // 
            this.comboBoxPlantID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPlantID.DataSource = this.usersMainBindingSource1;
            this.comboBoxPlantID.DisplayMember = "UserID";
            this.comboBoxPlantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlantID.FormattingEnabled = true;
            this.comboBoxPlantID.Location = new System.Drawing.Point(79, 149);
            this.comboBoxPlantID.Name = "comboBoxPlantID";
            this.comboBoxPlantID.Size = new System.Drawing.Size(265, 37);
            this.comboBoxPlantID.TabIndex = 1;
            // 
            // usersMainBindingSource1
            // 
            this.usersMainBindingSource1.DataMember = "UsersMain";

            // 
            // kCI_EQProDataSet
            // 
         
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zone ID";
            // 
            // textBoxZoneID
            // 
            this.textBoxZoneID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxZoneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZoneID.Location = new System.Drawing.Point(398, 152);
            this.textBoxZoneID.Name = "textBoxZoneID";
            this.textBoxZoneID.Size = new System.Drawing.Size(265, 34);
            this.textBoxZoneID.TabIndex = 3;
            // 
            // textBoxPlanRev
            // 
            this.textBoxPlanRev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPlanRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlanRev.Location = new System.Drawing.Point(712, 152);
            this.textBoxPlanRev.Name = "textBoxPlanRev";
            this.textBoxPlanRev.Size = new System.Drawing.Size(265, 34);
            this.textBoxPlanRev.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(707, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Plan Rev";
            // 
            // textBoxPlantSearch
            // 
            this.textBoxPlantSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPlantSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlantSearch.Location = new System.Drawing.Point(1001, 152);
            this.textBoxPlantSearch.Name = "textBoxPlantSearch";
            this.textBoxPlantSearch.Size = new System.Drawing.Size(265, 34);
            this.textBoxPlantSearch.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(996, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Plant Search";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.Navy;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(78, 247);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(187, 47);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.Navy;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(283, 247);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(187, 47);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignIn.BackColor = System.Drawing.Color.Navy;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.Location = new System.Drawing.Point(488, 247);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(187, 47);
            this.buttonSignIn.TabIndex = 28;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.BackColor = System.Drawing.Color.Navy;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(693, 247);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(187, 47);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "Exit App";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(67, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(446, 64);
            this.label14.TabIndex = 30;
            this.label14.Text = "Enviroment Form";
            // 
            // testTableBindingSource
            // 
            this.testTableBindingSource.DataMember = "TestTable";
 
            // 
            // testTableTableAdapter
            // 
         
            // 
            // usersMainBindingSource
            // 
            this.usersMainBindingSource.DataMember = "UsersMain";
           
            // 
            // usersMainTableAdapter
            // 
     
            // 
            // EnviromentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 639);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPlantSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPlanRev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxZoneID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPlantID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnviromentForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersMainBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersMainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPlantID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZoneID;
        private System.Windows.Forms.TextBox textBoxPlanRev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPlantSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label14;
        
        private System.Windows.Forms.BindingSource testTableBindingSource;
        
        private System.Windows.Forms.BindingSource usersMainBindingSource;
        
        private System.Windows.Forms.BindingSource usersMainBindingSource1;
    }
}