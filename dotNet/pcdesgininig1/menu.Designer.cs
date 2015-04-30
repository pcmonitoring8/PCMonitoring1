namespace pcdesgininig1
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diskSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturingScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appinfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frm_msgread = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.processToolStripMenuItem,
            this.applicationsToolStripMenuItem,
            this.frm_msgread});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            resources.ApplyResources(this.loginToolStripMenuItem, "loginToolStripMenuItem");
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            resources.ApplyResources(this.registrationToolStripMenuItem, "registrationToolStripMenuItem");
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processlistToolStripMenuItem,
            this.diskSpaceToolStripMenuItem,
            this.fileShareToolStripMenuItem,
            this.capturingScreenToolStripMenuItem,
            this.startToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            resources.ApplyResources(this.processToolStripMenuItem, "processToolStripMenuItem");
            // 
            // processlistToolStripMenuItem
            // 
            this.processlistToolStripMenuItem.Name = "processlistToolStripMenuItem";
            resources.ApplyResources(this.processlistToolStripMenuItem, "processlistToolStripMenuItem");
            this.processlistToolStripMenuItem.Click += new System.EventHandler(this.processlistToolStripMenuItem_Click);
            // 
            // diskSpaceToolStripMenuItem
            // 
            this.diskSpaceToolStripMenuItem.Name = "diskSpaceToolStripMenuItem";
            resources.ApplyResources(this.diskSpaceToolStripMenuItem, "diskSpaceToolStripMenuItem");
            this.diskSpaceToolStripMenuItem.Click += new System.EventHandler(this.diskSpaceToolStripMenuItem_Click);
            // 
            // fileShareToolStripMenuItem
            // 
            this.fileShareToolStripMenuItem.Name = "fileShareToolStripMenuItem";
            resources.ApplyResources(this.fileShareToolStripMenuItem, "fileShareToolStripMenuItem");
            this.fileShareToolStripMenuItem.Click += new System.EventHandler(this.fileShareToolStripMenuItem_Click);
            // 
            // capturingScreenToolStripMenuItem
            // 
            this.capturingScreenToolStripMenuItem.Name = "capturingScreenToolStripMenuItem";
            resources.ApplyResources(this.capturingScreenToolStripMenuItem, "capturingScreenToolStripMenuItem");
            this.capturingScreenToolStripMenuItem.Click += new System.EventHandler(this.capturingScreenToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appinfoToolStripMenuItem,
            this.pcInformationToolStripMenuItem});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            resources.ApplyResources(this.applicationsToolStripMenuItem, "applicationsToolStripMenuItem");
            // 
            // appinfoToolStripMenuItem
            // 
            this.appinfoToolStripMenuItem.Name = "appinfoToolStripMenuItem";
            resources.ApplyResources(this.appinfoToolStripMenuItem, "appinfoToolStripMenuItem");
            this.appinfoToolStripMenuItem.Click += new System.EventHandler(this.appinfoToolStripMenuItem_Click);
            // 
            // pcInformationToolStripMenuItem
            // 
            this.pcInformationToolStripMenuItem.Name = "pcInformationToolStripMenuItem";
            resources.ApplyResources(this.pcInformationToolStripMenuItem, "pcInformationToolStripMenuItem");
            this.pcInformationToolStripMenuItem.Click += new System.EventHandler(this.pcInformationToolStripMenuItem_Click);
            // 
            // frm_msgread
            // 
            this.frm_msgread.Name = "frm_msgread";
            resources.ApplyResources(this.frm_msgread, "frm_msgread");
            this.frm_msgread.Click += new System.EventHandler(this.msgread_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // frm_menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_menu";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diskSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileShareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturingScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appinfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pcInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frm_msgread;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}