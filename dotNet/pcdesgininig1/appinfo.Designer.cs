namespace pcdesgininig1
{
    partial class frm_appinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_appinfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_appnumber = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.lbl_path = new System.Windows.Forms.Label();
            this.txt_appname = new System.Windows.Forms.TextBox();
            this.txt_appnumber = new System.Windows.Forms.TextBox();
            this.lbl_appname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::pcdesgininig1.Properties.Resources._5;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_appnumber);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.btn_browse);
            this.panel1.Controls.Add(this.txt_path);
            this.panel1.Controls.Add(this.lbl_path);
            this.panel1.Controls.Add(this.txt_appname);
            this.panel1.Controls.Add(this.txt_appnumber);
            this.panel1.Controls.Add(this.lbl_appname);
            this.panel1.Location = new System.Drawing.Point(56, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 337);
            this.panel1.TabIndex = 9;
            // 
            // lbl_appnumber
            // 
            this.lbl_appnumber.AutoSize = true;
            this.lbl_appnumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_appnumber.Location = new System.Drawing.Point(99, 54);
            this.lbl_appnumber.Name = "lbl_appnumber";
            this.lbl_appnumber.Size = new System.Drawing.Size(156, 19);
            this.lbl_appnumber.TabIndex = 9;
            this.lbl_appnumber.Text = "Application Number :-";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.Location = new System.Drawing.Point(284, 259);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            //this.btn_cancel.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_submit.Location = new System.Drawing.Point(162, 259);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 29);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(494, 181);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 6;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(311, 181);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(159, 20);
            this.txt_path.TabIndex = 5;
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_path.Location = new System.Drawing.Point(95, 181);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(53, 19);
            this.lbl_path.TabIndex = 4;
            this.lbl_path.Text = "Path :-";
            // 
            // txt_appname
            // 
            this.txt_appname.Location = new System.Drawing.Point(311, 116);
            this.txt_appname.Name = "txt_appname";
            this.txt_appname.Size = new System.Drawing.Size(100, 20);
            this.txt_appname.TabIndex = 3;
            this.txt_appname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_appname_KeyPress);
            // 
            // txt_appnumber
            // 
            this.txt_appnumber.Location = new System.Drawing.Point(311, 54);
            this.txt_appnumber.Name = "txt_appnumber";
            this.txt_appnumber.Size = new System.Drawing.Size(100, 20);
            this.txt_appnumber.TabIndex = 2;
            this.txt_appnumber.TextChanged += new System.EventHandler(this.txt_appnumber_TextChanged);
            this.txt_appnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_appnumber_KeyPress);
            // 
            // lbl_appname
            // 
            this.lbl_appname.AutoSize = true;
            this.lbl_appname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_appname.Location = new System.Drawing.Point(95, 123);
            this.lbl_appname.Name = "lbl_appname";
            this.lbl_appname.Size = new System.Drawing.Size(142, 19);
            this.lbl_appname.TabIndex = 1;
            this.lbl_appname.Text = "Application Name :-";
            // 
            // frm_appinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 454);
            this.Controls.Add(this.panel1);
            this.Name = "frm_appinfo";
            this.Text = "appinfo";
            this.Load += new System.EventHandler(this.appinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_appname;
        private System.Windows.Forms.TextBox txt_appnumber;
        private System.Windows.Forms.TextBox txt_appname;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_appnumber;
    }
}