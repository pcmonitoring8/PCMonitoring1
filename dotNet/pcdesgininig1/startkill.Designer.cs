namespace pcdesgininig1
{
    partial class frm_startkill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_startkill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_kill = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.cmb_selectapp = new System.Windows.Forms.ComboBox();
            this.cmb_selectmachine = new System.Windows.Forms.ComboBox();
            this.lbl_selectapp = new System.Windows.Forms.Label();
            this.lbl_selectmachine = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::pcdesgininig1.Properties.Resources._52;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_kill);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.cmb_selectapp);
            this.panel1.Controls.Add(this.cmb_selectmachine);
            this.panel1.Controls.Add(this.lbl_selectapp);
            this.panel1.Controls.Add(this.lbl_selectmachine);
            this.panel1.Location = new System.Drawing.Point(84, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 329);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_kill
            // 
            this.btn_kill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_kill.Location = new System.Drawing.Point(319, 212);
            this.btn_kill.Name = "btn_kill";
            this.btn_kill.Size = new System.Drawing.Size(75, 29);
            this.btn_kill.TabIndex = 18;
            this.btn_kill.Text = "Kill";
            this.btn_kill.UseVisualStyleBackColor = true;
            this.btn_kill.Click += new System.EventHandler(this.btn_kill_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_start.Location = new System.Drawing.Point(180, 212);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 29);
            this.btn_start.TabIndex = 17;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // cmb_selectapp
            // 
            this.cmb_selectapp.FormattingEnabled = true;
            this.cmb_selectapp.Items.AddRange(new object[] {
            "Notepad",
            "Mspaint",
            "MSACCESS",
            "MSWORD",
            "MSEXCEL",
            "MSPOWERPOINT",
            "Calculator",
            "Remote Desktop",
            "Command Prompt"});
            this.cmb_selectapp.Location = new System.Drawing.Point(305, 124);
            this.cmb_selectapp.Name = "cmb_selectapp";
            this.cmb_selectapp.Size = new System.Drawing.Size(121, 21);
            this.cmb_selectapp.TabIndex = 16;
            // 
            // cmb_selectmachine
            // 
            this.cmb_selectmachine.FormattingEnabled = true;
            this.cmb_selectmachine.Location = new System.Drawing.Point(305, 54);
            this.cmb_selectmachine.Name = "cmb_selectmachine";
            this.cmb_selectmachine.Size = new System.Drawing.Size(121, 21);
            this.cmb_selectmachine.TabIndex = 13;
            // 
            // lbl_selectapp
            // 
            this.lbl_selectapp.AutoSize = true;
            this.lbl_selectapp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectapp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_selectapp.Location = new System.Drawing.Point(112, 126);
            this.lbl_selectapp.Name = "lbl_selectapp";
            this.lbl_selectapp.Size = new System.Drawing.Size(142, 19);
            this.lbl_selectapp.TabIndex = 12;
            this.lbl_selectapp.Text = "Select Application :-";
            // 
            // lbl_selectmachine
            // 
            this.lbl_selectmachine.AutoSize = true;
            this.lbl_selectmachine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectmachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_selectmachine.Location = new System.Drawing.Point(112, 54);
            this.lbl_selectmachine.Name = "lbl_selectmachine";
            this.lbl_selectmachine.Size = new System.Drawing.Size(127, 19);
            this.lbl_selectmachine.TabIndex = 11;
            this.lbl_selectmachine.Text = "Select Machine :-";
            // 
            // frm_startkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 454);
            this.Controls.Add(this.panel1);
            this.Name = "frm_startkill";
            this.Text = "start and kill process";
            this.Load += new System.EventHandler(this.frm_startkill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_kill;
        private System.Windows.Forms.Button btn_start;
        internal System.Windows.Forms.ComboBox cmb_selectapp;
        internal System.Windows.Forms.ComboBox cmb_selectmachine;
        internal System.Windows.Forms.Label lbl_selectapp;
        internal System.Windows.Forms.Label lbl_selectmachine;
    }
}