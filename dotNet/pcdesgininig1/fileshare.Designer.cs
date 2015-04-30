namespace pcdesgininig1
{
    partial class frm_fileshare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_fileshare));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_useremail = new System.Windows.Forms.TextBox();
            this.lbl_useremail = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_adminemail = new System.Windows.Forms.TextBox();
            this.txt_selectfile = new System.Windows.Forms.TextBox();
            this.btn_selectfile = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.lbl_adminemail = new System.Windows.Forms.Label();
            this.lbl_selectfile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_useremail);
            this.panel1.Controls.Add(this.lbl_useremail);
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.txt_adminemail);
            this.panel1.Controls.Add(this.txt_selectfile);
            this.panel1.Controls.Add(this.btn_selectfile);
            this.panel1.Controls.Add(this.btn_transfer);
            this.panel1.Controls.Add(this.lbl_adminemail);
            this.panel1.Controls.Add(this.lbl_selectfile);
            this.panel1.Location = new System.Drawing.Point(95, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 302);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(172, 200);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(214, 20);
            this.txt_password.TabIndex = 10;
            // 
            // txt_useremail
            // 
            this.txt_useremail.Location = new System.Drawing.Point(172, 156);
            this.txt_useremail.Name = "txt_useremail";
            this.txt_useremail.Size = new System.Drawing.Size(214, 20);
            this.txt_useremail.TabIndex = 9;
            // 
            // lbl_useremail
            // 
            this.lbl_useremail.AutoSize = true;
            this.lbl_useremail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_useremail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_useremail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_useremail.Location = new System.Drawing.Point(12, 155);
            this.lbl_useremail.Name = "lbl_useremail";
            this.lbl_useremail.Size = new System.Drawing.Size(119, 19);
            this.lbl_useremail.TabIndex = 8;
            this.lbl_useremail.Text = "User Email_ID:-";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_password.Location = new System.Drawing.Point(12, 199);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(122, 19);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = " User Password:-";
            // 
            // txt_adminemail
            // 
            this.txt_adminemail.Location = new System.Drawing.Point(172, 104);
            this.txt_adminemail.Name = "txt_adminemail";
            this.txt_adminemail.Size = new System.Drawing.Size(214, 20);
            this.txt_adminemail.TabIndex = 6;
            // 
            // txt_selectfile
            // 
            this.txt_selectfile.Location = new System.Drawing.Point(172, 40);
            this.txt_selectfile.Name = "txt_selectfile";
            this.txt_selectfile.Size = new System.Drawing.Size(225, 20);
            this.txt_selectfile.TabIndex = 5;
            this.txt_selectfile.TextChanged += new System.EventHandler(this.txt_selectfile_TextChanged);
            // 
            // btn_selectfile
            // 
            this.btn_selectfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectfile.Location = new System.Drawing.Point(453, 32);
            this.btn_selectfile.Name = "btn_selectfile";
            this.btn_selectfile.Size = new System.Drawing.Size(75, 33);
            this.btn_selectfile.TabIndex = 3;
            this.btn_selectfile.Text = "Browse";
            this.btn_selectfile.UseVisualStyleBackColor = true;
            this.btn_selectfile.Click += new System.EventHandler(this.btn_selectfile_Click);
            // 
            // btn_transfer
            // 
            this.btn_transfer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_transfer.Location = new System.Drawing.Point(219, 248);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(75, 27);
            this.btn_transfer.TabIndex = 2;
            this.btn_transfer.Text = "Transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // lbl_adminemail
            // 
            this.lbl_adminemail.AutoSize = true;
            this.lbl_adminemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_adminemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_adminemail.Location = new System.Drawing.Point(12, 103);
            this.lbl_adminemail.Name = "lbl_adminemail";
            this.lbl_adminemail.Size = new System.Drawing.Size(137, 19);
            this.lbl_adminemail.TabIndex = 1;
            this.lbl_adminemail.Text = " Admin  Email_ID:-";
            // 
            // lbl_selectfile
            // 
            this.lbl_selectfile.AutoSize = true;
            this.lbl_selectfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_selectfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_selectfile.Location = new System.Drawing.Point(19, 39);
            this.lbl_selectfile.Name = "lbl_selectfile";
            this.lbl_selectfile.Size = new System.Drawing.Size(93, 19);
            this.lbl_selectfile.TabIndex = 0;
            this.lbl_selectfile.Text = "Select File :-";
            // 
            // frm_fileshare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pcdesgininig1.Properties.Resources._126;
            this.ClientSize = new System.Drawing.Size(773, 454);
            this.Controls.Add(this.panel1);
            this.Name = "frm_fileshare";
            this.Text = "fileshare";
            this.Load += new System.EventHandler(this.frm_fileshare_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_adminemail;
        private System.Windows.Forms.TextBox txt_selectfile;
        private System.Windows.Forms.Button btn_selectfile;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Label lbl_adminemail;
        private System.Windows.Forms.Label lbl_selectfile;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_useremail;
        private System.Windows.Forms.Label lbl_useremail;
        private System.Windows.Forms.Label lbl_password;
    }
}