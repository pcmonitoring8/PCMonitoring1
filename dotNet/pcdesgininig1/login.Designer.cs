namespace pcdesgininig1
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::pcdesgininig1.Properties.Resources._23;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Location = new System.Drawing.Point(102, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 289);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.Location = new System.Drawing.Point(182, 190);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.Location = new System.Drawing.Point(78, 190);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 32);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(182, 107);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.White;
            this.lbl_password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_password.Location = new System.Drawing.Point(19, 108);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(106, 22);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password :-";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(182, 54);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(160, 20);
            this.txt_username.TabIndex = 1;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Linen;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_username.Location = new System.Drawing.Point(19, 54);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(112, 22);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "UserName :-";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 454);
            this.Controls.Add(this.panel1);
            this.Name = "frm_login";
            this.RightToLeftLayout = true;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
    }
}

