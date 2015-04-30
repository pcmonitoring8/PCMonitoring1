namespace pcdesgininig1
{
    partial class frm_reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_emailid = new System.Windows.Forms.TextBox();
            this.lbl_emailid = new System.Windows.Forms.Label();
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_mobilenumber = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_confirmpassword = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_moblienumber = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.txt_emailid);
            this.panel1.Controls.Add(this.lbl_emailid);
            this.panel1.Controls.Add(this.txt_confirmpassword);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_mobilenumber);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.lbl_confirmpassword);
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.lbl_moblienumber);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(34, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 399);
            this.panel1.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(348, 325);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 33);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(226, 325);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 32);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_emailid
            // 
            this.txt_emailid.Location = new System.Drawing.Point(359, 251);
            this.txt_emailid.Name = "txt_emailid";
            this.txt_emailid.Size = new System.Drawing.Size(225, 26);
            this.txt_emailid.TabIndex = 4;
            // 
            // lbl_emailid
            // 
            this.lbl_emailid.AutoSize = true;
            this.lbl_emailid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_emailid.Location = new System.Drawing.Point(145, 252);
            this.lbl_emailid.Name = "lbl_emailid";
            this.lbl_emailid.Size = new System.Drawing.Size(105, 22);
            this.lbl_emailid.TabIndex = 8;
            this.lbl_emailid.Text = "Email_ID :-";
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.Location = new System.Drawing.Point(359, 204);
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.PasswordChar = '*';
            this.txt_confirmpassword.Size = new System.Drawing.Size(139, 26);
            this.txt_confirmpassword.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(359, 168);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(139, 26);
            this.txt_password.TabIndex = 2;
            // 
            // txt_mobilenumber
            // 
            this.txt_mobilenumber.Location = new System.Drawing.Point(359, 119);
            this.txt_mobilenumber.MaxLength = 10;
            this.txt_mobilenumber.Name = "txt_mobilenumber";
            this.txt_mobilenumber.Size = new System.Drawing.Size(241, 26);
            this.txt_mobilenumber.TabIndex = 1;
            this.txt_mobilenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobileno_KeyPress_1);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(359, 77);
            this.txt_name.MinimumSize = new System.Drawing.Size(5, 15);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(261, 26);
            this.txt_name.TabIndex = 0;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress_1);
            // 
            // lbl_confirmpassword
            // 
            this.lbl_confirmpassword.AutoSize = true;
            this.lbl_confirmpassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_confirmpassword.Location = new System.Drawing.Point(144, 205);
            this.lbl_confirmpassword.Name = "lbl_confirmpassword";
            this.lbl_confirmpassword.Size = new System.Drawing.Size(177, 22);
            this.lbl_confirmpassword.TabIndex = 3;
            this.lbl_confirmpassword.Text = "Confirm password :-";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_password.Location = new System.Drawing.Point(144, 168);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(106, 22);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password :-";
            // 
            // lbl_moblienumber
            // 
            this.lbl_moblienumber.AutoSize = true;
            this.lbl_moblienumber.BackColor = System.Drawing.Color.White;
            this.lbl_moblienumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moblienumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_moblienumber.Location = new System.Drawing.Point(144, 123);
            this.lbl_moblienumber.Name = "lbl_moblienumber";
            this.lbl_moblienumber.Size = new System.Drawing.Size(154, 22);
            this.lbl_moblienumber.TabIndex = 1;
            this.lbl_moblienumber.Text = "Mobile Number :-";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_name.Location = new System.Drawing.Point(144, 81);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(74, 22);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name :-";
            // 
            // frm_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 454);
            this.Controls.Add(this.panel1);
            this.Name = "frm_reg";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frm_reg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_emailid;
        private System.Windows.Forms.Label lbl_emailid;
        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_mobilenumber;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_confirmpassword;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_moblienumber;
        private System.Windows.Forms.Label lbl_name;
    }
}