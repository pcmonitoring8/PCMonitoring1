namespace pcdesgininig1
{
    partial class frm_pcnumbername
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pcnumbername));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ipp = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.txt_pcip4 = new System.Windows.Forms.TextBox();
            this.txt_pcip3 = new System.Windows.Forms.TextBox();
            this.txt_pcip2 = new System.Windows.Forms.TextBox();
            this.txt_pcip1 = new System.Windows.Forms.TextBox();
            this.lbl_pcip = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_pcname = new System.Windows.Forms.TextBox();
            this.txt_pcnumber = new System.Windows.Forms.TextBox();
            this.lbl_pcnm = new System.Windows.Forms.Label();
            this.lbl_pcno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_ipp);
            this.panel1.Controls.Add(this.lbl_ip);
            this.panel1.Controls.Add(this.txt_pcip4);
            this.panel1.Controls.Add(this.txt_pcip3);
            this.panel1.Controls.Add(this.txt_pcip2);
            this.panel1.Controls.Add(this.txt_pcip1);
            this.panel1.Controls.Add(this.lbl_pcip);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.txt_pcname);
            this.panel1.Controls.Add(this.txt_pcnumber);
            this.panel1.Controls.Add(this.lbl_pcnm);
            this.panel1.Controls.Add(this.lbl_pcno);
            this.panel1.Location = new System.Drawing.Point(120, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 343);
            this.panel1.TabIndex = 6;
            // 
            // lbl_ipp
            // 
            this.lbl_ipp.AutoSize = true;
            this.lbl_ipp.Location = new System.Drawing.Point(278, 224);
            this.lbl_ipp.Name = "lbl_ipp";
            this.lbl_ipp.Size = new System.Drawing.Size(0, 13);
            this.lbl_ipp.TabIndex = 12;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(254, 224);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(0, 13);
            this.lbl_ip.TabIndex = 11;
            // 
            // txt_pcip4
            // 
            this.txt_pcip4.Location = new System.Drawing.Point(362, 182);
            this.txt_pcip4.MaxLength = 3;
            this.txt_pcip4.Name = "txt_pcip4";
            this.txt_pcip4.Size = new System.Drawing.Size(41, 20);
            this.txt_pcip4.TabIndex = 10;
            this.txt_pcip4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ip4_KeyPress);
            // 
            // txt_pcip3
            // 
            this.txt_pcip3.Location = new System.Drawing.Point(317, 182);
            this.txt_pcip3.MaxLength = 3;
            this.txt_pcip3.Name = "txt_pcip3";
            this.txt_pcip3.Size = new System.Drawing.Size(39, 20);
            this.txt_pcip3.TabIndex = 9;
            this.txt_pcip3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pcip3_KeyPress);
            // 
            // txt_pcip2
            // 
            this.txt_pcip2.Location = new System.Drawing.Point(266, 183);
            this.txt_pcip2.MaxLength = 3;
            this.txt_pcip2.Name = "txt_pcip2";
            this.txt_pcip2.Size = new System.Drawing.Size(44, 20);
            this.txt_pcip2.TabIndex = 8;
            this.txt_pcip2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pcip2_KeyPress);
            // 
            // txt_pcip1
            // 
            this.txt_pcip1.Location = new System.Drawing.Point(210, 183);
            this.txt_pcip1.MaxLength = 3;
            this.txt_pcip1.Name = "txt_pcip1";
            this.txt_pcip1.Size = new System.Drawing.Size(50, 20);
            this.txt_pcip1.TabIndex = 7;
            this.txt_pcip1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pcip1_KeyPress);
            // 
            // lbl_pcip
            // 
            this.lbl_pcip.AutoSize = true;
            this.lbl_pcip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_pcip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pcip.Location = new System.Drawing.Point(72, 186);
            this.lbl_pcip.Name = "lbl_pcip";
            this.lbl_pcip.Size = new System.Drawing.Size(59, 19);
            this.lbl_pcip.TabIndex = 6;
            this.lbl_pcip.Text = "Pc_ip :-";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.Location = new System.Drawing.Point(235, 262);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_submit.Location = new System.Drawing.Point(119, 262);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 32);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_pcname
            // 
            this.txt_pcname.Location = new System.Drawing.Point(210, 135);
            this.txt_pcname.Name = "txt_pcname";
            this.txt_pcname.Size = new System.Drawing.Size(100, 20);
            this.txt_pcname.TabIndex = 3;
            // 
            // txt_pcnumber
            // 
            this.txt_pcnumber.Location = new System.Drawing.Point(210, 72);
            this.txt_pcnumber.Name = "txt_pcnumber";
            this.txt_pcnumber.Size = new System.Drawing.Size(100, 20);
            this.txt_pcnumber.TabIndex = 2;
            //this.txt_pcnumber.TextChanged += new System.EventHandler(this.txt_pcnumber_TextChanged);
            this.txt_pcnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pcnumber_KeyPress);
            // 
            // lbl_pcnm
            // 
            this.lbl_pcnm.AutoSize = true;
            this.lbl_pcnm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_pcnm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcnm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pcnm.Location = new System.Drawing.Point(69, 135);
            this.lbl_pcnm.Name = "lbl_pcnm";
            this.lbl_pcnm.Size = new System.Drawing.Size(87, 19);
            this.lbl_pcnm.TabIndex = 1;
            this.lbl_pcnm.Text = "Pc_Name :-";
            // 
            // lbl_pcno
            // 
            this.lbl_pcno.AutoSize = true;
            this.lbl_pcno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_pcno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pcno.Location = new System.Drawing.Point(69, 72);
            this.lbl_pcno.Name = "lbl_pcno";
            this.lbl_pcno.Size = new System.Drawing.Size(63, 19);
            this.lbl_pcno.TabIndex = 0;
            this.lbl_pcno.Text = "Pc No :-";
            // 
            // frm_pcnumbername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 454);
            this.Controls.Add(this.panel1);
            this.Name = "frm_pcnumbername";
            this.Text = "pcnumbername";
            this.Load += new System.EventHandler(this.frm_pcnumbername_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_pcno;
        private System.Windows.Forms.Label lbl_pcnm;
        private System.Windows.Forms.TextBox txt_pcnumber;
        private System.Windows.Forms.TextBox txt_pcname;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pcip1;
        private System.Windows.Forms.Label lbl_pcip;
        private System.Windows.Forms.TextBox txt_pcip4;
        private System.Windows.Forms.TextBox txt_pcip3;
        private System.Windows.Forms.TextBox txt_pcip2;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_ipp;
    }
}