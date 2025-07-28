using System.Windows.Forms;

namespace BMC2021
{
    partial class MainDash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDash));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn_Profile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_POS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Inventory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Finance = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Orders = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MainFeatures = new System.Windows.Forms.ToolStrip();
            this.uSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITBMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToINVENTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToSALESMONITORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_admin = new System.Windows.Forms.Label();
            this.lb_current_fullname = new System.Windows.Forms.Label();
            this.lb_designation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.MainFeatures.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip1_ItemClicked);
            // 
            // Btn_Profile
            // 
            this.Btn_Profile.AutoToolTip = false;
            resources.ApplyResources(this.Btn_Profile, "Btn_Profile");
            this.Btn_Profile.Name = "Btn_Profile";
            this.Btn_Profile.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Profile.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Btn_Profile.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // Btn_POS
            // 
            resources.ApplyResources(this.Btn_POS, "Btn_POS");
            this.Btn_POS.Name = "Btn_POS";
            this.Btn_POS.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_POS.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Btn_POS.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // Btn_Inventory
            // 
            resources.ApplyResources(this.Btn_Inventory, "Btn_Inventory");
            this.Btn_Inventory.Name = "Btn_Inventory";
            this.Btn_Inventory.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Inventory.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Btn_Inventory.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripButton4
            // 
            resources.ApplyResources(this.toolStripButton4, "toolStripButton4");
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButton4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // Btn_Finance
            // 
            resources.ApplyResources(this.Btn_Finance, "Btn_Finance");
            this.Btn_Finance.Name = "Btn_Finance";
            this.Btn_Finance.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Finance.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Btn_Finance.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // Btn_Orders
            // 
            resources.ApplyResources(this.Btn_Orders, "Btn_Orders");
            this.Btn_Orders.Name = "Btn_Orders";
            this.Btn_Orders.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Orders.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Btn_Orders.Click += new System.EventHandler(this.ToolStripButton6_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // MainFeatures
            // 
            this.MainFeatures.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.MainFeatures, "MainFeatures");
            this.MainFeatures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Profile,
            this.toolStripSeparator1,
            this.Btn_POS,
            this.toolStripSeparator2,
            this.Btn_Inventory,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.Btn_Finance,
            this.toolStripSeparator5,
            this.Btn_Orders,
            this.toolStripSeparator6});
            this.MainFeatures.Name = "MainFeatures";
            this.MainFeatures.ShowItemToolTips = false;
            // 
            // uSERToolStripMenuItem
            // 
            this.uSERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.eXITBMCToolStripMenuItem});
            this.uSERToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.uSERToolStripMenuItem, "uSERToolStripMenuItem");
            this.uSERToolStripMenuItem.Name = "uSERToolStripMenuItem";
            this.uSERToolStripMenuItem.Click += new System.EventHandler(this.USERToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // eXITBMCToolStripMenuItem
            // 
            this.eXITBMCToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.eXITBMCToolStripMenuItem, "eXITBMCToolStripMenuItem");
            this.eXITBMCToolStripMenuItem.Name = "eXITBMCToolStripMenuItem";
            this.eXITBMCToolStripMenuItem.Click += new System.EventHandler(this.eXITBMCToolStripMenuItem_Click);
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminControlToolStripMenuItem,
            this.importCSVToolStripMenuItem});
            this.aDMINToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            resources.ApplyResources(this.aDMINToolStripMenuItem, "aDMINToolStripMenuItem");
            this.aDMINToolStripMenuItem.Click += new System.EventHandler(this.ADMINToolStripMenuItem_Click);
            // 
            // adminControlToolStripMenuItem
            // 
            resources.ApplyResources(this.adminControlToolStripMenuItem, "adminControlToolStripMenuItem");
            this.adminControlToolStripMenuItem.Name = "adminControlToolStripMenuItem";
            this.adminControlToolStripMenuItem.Click += new System.EventHandler(this.adminControlToolStripMenuItem_Click);
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToINVENTORYToolStripMenuItem,
            this.importToSALESMONITORToolStripMenuItem});
            resources.ApplyResources(this.importCSVToolStripMenuItem, "importCSVToolStripMenuItem");
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Click += new System.EventHandler(this.importCSVToolStripMenuItem_Click);
            // 
            // importToINVENTORYToolStripMenuItem
            // 
            this.importToINVENTORYToolStripMenuItem.Name = "importToINVENTORYToolStripMenuItem";
            resources.ApplyResources(this.importToINVENTORYToolStripMenuItem, "importToINVENTORYToolStripMenuItem");
            this.importToINVENTORYToolStripMenuItem.Click += new System.EventHandler(this.importToINVENTORYToolStripMenuItem_Click);
            // 
            // importToSALESMONITORToolStripMenuItem
            // 
            this.importToSALESMONITORToolStripMenuItem.Name = "importToSALESMONITORToolStripMenuItem";
            resources.ApplyResources(this.importToSALESMONITORToolStripMenuItem, "importToSALESMONITORToolStripMenuItem");
            this.importToSALESMONITORToolStripMenuItem.Click += new System.EventHandler(this.importToSALESMONITORToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            resources.ApplyResources(this.hELPToolStripMenuItem, "hELPToolStripMenuItem");
            this.hELPToolStripMenuItem.Click += new System.EventHandler(this.HELPToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERToolStripMenuItem,
            this.aDMINToolStripMenuItem,
            this.hELPToolStripMenuItem,
            this.aBOUTToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBMCToolStripMenuItem,
            this.contactDeveloperToolStripMenuItem});
            this.aBOUTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            resources.ApplyResources(this.aBOUTToolStripMenuItem, "aBOUTToolStripMenuItem");
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.aBOUTToolStripMenuItem_Click);
            // 
            // aboutBMCToolStripMenuItem
            // 
            this.aboutBMCToolStripMenuItem.Name = "aboutBMCToolStripMenuItem";
            resources.ApplyResources(this.aboutBMCToolStripMenuItem, "aboutBMCToolStripMenuItem");
            this.aboutBMCToolStripMenuItem.Click += new System.EventHandler(this.aboutBMCToolStripMenuItem_Click);
            // 
            // contactDeveloperToolStripMenuItem
            // 
            this.contactDeveloperToolStripMenuItem.Name = "contactDeveloperToolStripMenuItem";
            resources.ApplyResources(this.contactDeveloperToolStripMenuItem, "contactDeveloperToolStripMenuItem");
            this.contactDeveloperToolStripMenuItem.Click += new System.EventHandler(this.contactDeveloperToolStripMenuItem_Click);
            // 
            // lb_admin
            // 
            resources.ApplyResources(this.lb_admin, "lb_admin");
            this.lb_admin.Name = "lb_admin";
            // 
            // lb_current_fullname
            // 
            resources.ApplyResources(this.lb_current_fullname, "lb_current_fullname");
            this.lb_current_fullname.Name = "lb_current_fullname";
            this.lb_current_fullname.Click += new System.EventHandler(this.lb_current_fullname_Click);
            // 
            // lb_designation
            // 
            resources.ApplyResources(this.lb_designation, "lb_designation");
            this.lb_designation.Name = "lb_designation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_admin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_designation);
            this.groupBox1.Controls.Add(this.lb_current_fullname);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // MainDash
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainFeatures);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "MainDash";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MainFeatures.ResumeLayout(false);
            this.MainFeatures.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Btn_POS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Btn_Inventory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Btn_Finance;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Btn_Orders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStrip MainFeatures;
        private System.Windows.Forms.ToolStripMenuItem uSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITBMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Profile;
        private Label lb_admin;
        private Label lb_current_fullname;
        private Label lb_designation;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panel2;
        private ToolStripMenuItem aBOUTToolStripMenuItem;
        private ToolStripMenuItem aboutBMCToolStripMenuItem;
        private ToolStripMenuItem contactDeveloperToolStripMenuItem;
        private ToolStripMenuItem adminControlToolStripMenuItem;
        private ToolStripMenuItem importCSVToolStripMenuItem;
        private ToolStripMenuItem importToINVENTORYToolStripMenuItem;
        private ToolStripMenuItem importToSALESMONITORToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}


