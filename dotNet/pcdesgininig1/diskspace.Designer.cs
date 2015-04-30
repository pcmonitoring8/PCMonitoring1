namespace pcdesgininig1
{
    partial class frm_diskspace
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
            this.lbl_freesize = new System.Windows.Forms.Label();
            this.lbl_totalsize = new System.Windows.Forms.Label();
            this.lbl_freespace = new System.Windows.Forms.Label();
            this.lbl_totalspace = new System.Windows.Forms.Label();
            this.cmb_selectdisk = new System.Windows.Forms.ComboBox();
            this.btn_showdisk = new System.Windows.Forms.Button();
            this.cmb_selectmachine = new System.Windows.Forms.ComboBox();
            this.lbl_selectdisk = new System.Windows.Forms.Label();
            this.lbl_selectmachine = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::pcdesgininig1.Properties.Resources._57;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_freesize);
            this.panel1.Controls.Add(this.lbl_totalsize);
            this.panel1.Controls.Add(this.lbl_freespace);
            this.panel1.Controls.Add(this.lbl_totalspace);
            this.panel1.Controls.Add(this.cmb_selectdisk);
            this.panel1.Controls.Add(this.btn_showdisk);
            this.panel1.Controls.Add(this.cmb_selectmachine);
            this.panel1.Controls.Add(this.lbl_selectdisk);
            this.panel1.Controls.Add(this.lbl_selectmachine);
            this.panel1.Location = new System.Drawing.Point(155, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 376);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_freesize
            // 
            this.lbl_freesize.AutoSize = true;
            this.lbl_freesize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_freesize.Location = new System.Drawing.Point(297, 220);
            this.lbl_freesize.Name = "lbl_freesize";
            this.lbl_freesize.Size = new System.Drawing.Size(13, 19);
            this.lbl_freesize.TabIndex = 8;
            this.lbl_freesize.Text = ".";
            // 
            // lbl_totalsize
            // 
            this.lbl_totalsize.AutoSize = true;
            this.lbl_totalsize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalsize.Location = new System.Drawing.Point(67, 220);
            this.lbl_totalsize.Name = "lbl_totalsize";
            this.lbl_totalsize.Size = new System.Drawing.Size(13, 19);
            this.lbl_totalsize.TabIndex = 7;
            this.lbl_totalsize.Text = ".";
            // 
            // lbl_freespace
            // 
            this.lbl_freespace.AutoSize = true;
            this.lbl_freespace.Location = new System.Drawing.Point(246, 209);
            this.lbl_freespace.Name = "lbl_freespace";
            this.lbl_freespace.Size = new System.Drawing.Size(0, 13);
            this.lbl_freespace.TabIndex = 6;
            // 
            // lbl_totalspace
            // 
            this.lbl_totalspace.AutoSize = true;
            this.lbl_totalspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalspace.Location = new System.Drawing.Point(112, 209);
            this.lbl_totalspace.Name = "lbl_totalspace";
            this.lbl_totalspace.Size = new System.Drawing.Size(0, 25);
            this.lbl_totalspace.TabIndex = 5;
            // 
            // cmb_selectdisk
            // 
            this.cmb_selectdisk.FormattingEnabled = true;
            this.cmb_selectdisk.Items.AddRange(new object[] {
            "All",
            "C:",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:",
            "I:"});
            this.cmb_selectdisk.Location = new System.Drawing.Point(258, 123);
            this.cmb_selectdisk.Name = "cmb_selectdisk";
            this.cmb_selectdisk.Size = new System.Drawing.Size(121, 21);
            this.cmb_selectdisk.TabIndex = 4;
            // 
            // btn_showdisk
            // 
            this.btn_showdisk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showdisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_showdisk.Location = new System.Drawing.Point(149, 282);
            this.btn_showdisk.Name = "btn_showdisk";
            this.btn_showdisk.Size = new System.Drawing.Size(121, 28);
            this.btn_showdisk.TabIndex = 3;
            this.btn_showdisk.Text = "Show";
            this.btn_showdisk.UseVisualStyleBackColor = true;
            this.btn_showdisk.Click += new System.EventHandler(this.btn_showdisk_Click);
            // 
            // cmb_selectmachine
            // 
            this.cmb_selectmachine.FormattingEnabled = true;
            this.cmb_selectmachine.Location = new System.Drawing.Point(258, 73);
            this.cmb_selectmachine.Name = "cmb_selectmachine";
            this.cmb_selectmachine.Size = new System.Drawing.Size(121, 21);
            this.cmb_selectmachine.TabIndex = 2;
            // 
            // lbl_selectdisk
            // 
            this.lbl_selectdisk.AutoSize = true;
            this.lbl_selectdisk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectdisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_selectdisk.Location = new System.Drawing.Point(47, 122);
            this.lbl_selectdisk.Name = "lbl_selectdisk";
            this.lbl_selectdisk.Size = new System.Drawing.Size(100, 19);
            this.lbl_selectdisk.TabIndex = 1;
            this.lbl_selectdisk.Text = "Select Disk :-";
            // 
            // lbl_selectmachine
            // 
            this.lbl_selectmachine.AutoSize = true;
            this.lbl_selectmachine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectmachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_selectmachine.Location = new System.Drawing.Point(47, 73);
            this.lbl_selectmachine.Name = "lbl_selectmachine";
            this.lbl_selectmachine.Size = new System.Drawing.Size(127, 19);
            this.lbl_selectmachine.TabIndex = 0;
            this.lbl_selectmachine.Text = "Select Machine :-";
            // 
            // frm_diskspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pcdesgininig1.Properties.Resources._128;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 454);
            this.Controls.Add(this.panel1);
            this.Name = "frm_diskspace";
            this.Text = "diskspace";
            this.Load += new System.EventHandler(this.frm_diskspace_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_selectdisk;
        private System.Windows.Forms.Button btn_showdisk;
        private System.Windows.Forms.ComboBox cmb_selectmachine;
        private System.Windows.Forms.Label lbl_selectdisk;
        private System.Windows.Forms.Label lbl_selectmachine;
        private System.Windows.Forms.Label lbl_freespace;
        private System.Windows.Forms.Label lbl_totalspace;
        private System.Windows.Forms.Label lbl_freesize;
        private System.Windows.Forms.Label lbl_totalsize;
    }
}