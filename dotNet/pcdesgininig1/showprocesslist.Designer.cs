namespace pcdesgininig1
{
    partial class frm_showprocesslist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_showprocesslist));
            this.lst_showprocesslist = new System.Windows.Forms.ListBox();
            this.btn_showprocesslist = new System.Windows.Forms.Button();
            this.cmb_selectmachine = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_showprocesslist
            // 
            this.lst_showprocesslist.FormattingEnabled = true;
            this.lst_showprocesslist.Location = new System.Drawing.Point(91, 59);
            this.lst_showprocesslist.Name = "lst_showprocesslist";
            this.lst_showprocesslist.Size = new System.Drawing.Size(597, 459);
            this.lst_showprocesslist.TabIndex = 5;
            this.lst_showprocesslist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_showprocesslist
            // 
            this.btn_showprocesslist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showprocesslist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_showprocesslist.Location = new System.Drawing.Point(335, 10);
            this.btn_showprocesslist.Name = "btn_showprocesslist";
            this.btn_showprocesslist.Size = new System.Drawing.Size(75, 38);
            this.btn_showprocesslist.TabIndex = 4;
            this.btn_showprocesslist.Text = "show";
            this.btn_showprocesslist.UseVisualStyleBackColor = true;
            this.btn_showprocesslist.Click += new System.EventHandler(this.show_Click);
            // 
            // cmb_selectmachine
            // 
            this.cmb_selectmachine.FormattingEnabled = true;
            this.cmb_selectmachine.Location = new System.Drawing.Point(91, 21);
            this.cmb_selectmachine.Name = "cmb_selectmachine";
            this.cmb_selectmachine.Size = new System.Drawing.Size(212, 21);
            this.cmb_selectmachine.TabIndex = 3;
            this.cmb_selectmachine.SelectedIndexChanged += new System.EventHandler(this.cmb_selectmachine_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::pcdesgininig1.Properties.Resources._53;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lst_showprocesslist);
            this.panel1.Controls.Add(this.btn_showprocesslist);
            this.panel1.Controls.Add(this.cmb_selectmachine);
            this.panel1.Location = new System.Drawing.Point(26, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 533);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frm_showprocesslist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 550);
            this.Controls.Add(this.panel1);
            this.Name = "frm_showprocesslist";
            this.Text = "showprocesslist";
            this.Load += new System.EventHandler(this.showprocesslist_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_showprocesslist;
        private System.Windows.Forms.Button btn_showprocesslist;
        private System.Windows.Forms.ComboBox cmb_selectmachine;
        private System.Windows.Forms.Panel panel1;
    }
}