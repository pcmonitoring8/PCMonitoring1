namespace pcdesgininig1
{
    partial class frm_shutdown
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_shutdown = new System.Windows.Forms.Button();
            this.cmb_selectmachine = new System.Windows.Forms.ComboBox();
            this.lbl_selectmachine = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::pcdesgininig1.Properties.Resources._52;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_restart);
            this.panel1.Controls.Add(this.btn_shutdown);
            this.panel1.Controls.Add(this.cmb_selectmachine);
            this.panel1.Controls.Add(this.lbl_selectmachine);
            this.panel1.Location = new System.Drawing.Point(56, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 282);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_restart.Location = new System.Drawing.Point(305, 166);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(98, 29);
            this.btn_restart.TabIndex = 18;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_shutdown
            // 
            this.btn_shutdown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_shutdown.Location = new System.Drawing.Point(156, 166);
            this.btn_shutdown.Name = "btn_shutdown";
            this.btn_shutdown.Size = new System.Drawing.Size(110, 29);
            this.btn_shutdown.TabIndex = 17;
            this.btn_shutdown.Text = "Shut down";
            this.btn_shutdown.UseVisualStyleBackColor = true;
            this.btn_shutdown.Click += new System.EventHandler(this.btn_shutdown_Click_1);
            // 
            // cmb_selectmachine
            // 
            this.cmb_selectmachine.FormattingEnabled = true;
            this.cmb_selectmachine.Location = new System.Drawing.Point(305, 54);
            this.cmb_selectmachine.Name = "cmb_selectmachine";
            this.cmb_selectmachine.Size = new System.Drawing.Size(121, 21);
            this.cmb_selectmachine.TabIndex = 13;
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
            // frm_shutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 447);
            this.Controls.Add(this.panel1);
            this.Name = "frm_shutdown";
            this.Text = "shutdown";
            this.Load += new System.EventHandler(this.shutdown_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_shutdown;
        internal System.Windows.Forms.ComboBox cmb_selectmachine;
        internal System.Windows.Forms.Label lbl_selectmachine;
    }
}