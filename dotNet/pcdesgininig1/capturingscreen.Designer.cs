namespace pcdesgininig1
{
    partial class frm_capturingscreen
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
            this.btn_showcapturing = new System.Windows.Forms.Button();
            this.cmb_selectmachine = new System.Windows.Forms.ComboBox();
            this.lbl_selectmachine = new System.Windows.Forms.Label();
            this.pic_capturingscreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_capturingscreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_showcapturing
            // 
            this.btn_showcapturing.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showcapturing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_showcapturing.Location = new System.Drawing.Point(579, 30);
            this.btn_showcapturing.Name = "btn_showcapturing";
            this.btn_showcapturing.Size = new System.Drawing.Size(75, 31);
            this.btn_showcapturing.TabIndex = 5;
            this.btn_showcapturing.Text = "Show";
            this.btn_showcapturing.UseVisualStyleBackColor = true;
            this.btn_showcapturing.Click += new System.EventHandler(this.btn_showcapturing_Click);
            // 
            // cmb_selectmachine
            // 
            this.cmb_selectmachine.FormattingEnabled = true;
            this.cmb_selectmachine.Location = new System.Drawing.Point(435, 37);
            this.cmb_selectmachine.Name = "cmb_selectmachine";
            this.cmb_selectmachine.Size = new System.Drawing.Size(121, 21);
            this.cmb_selectmachine.TabIndex = 4;
            //this.cmb_selectmachine.SelectedIndexChanged += new System.EventHandler(this.cmb_selectmachine_SelectedIndexChanged);
            // 
            // lbl_selectmachine
            // 
            this.lbl_selectmachine.AutoSize = true;
            this.lbl_selectmachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_selectmachine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectmachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_selectmachine.Location = new System.Drawing.Point(270, 39);
            this.lbl_selectmachine.Name = "lbl_selectmachine";
            this.lbl_selectmachine.Size = new System.Drawing.Size(123, 19);
            this.lbl_selectmachine.TabIndex = 3;
            this.lbl_selectmachine.Text = "Select machine :-";
            // 
            // pic_capturingscreen
            // 
            this.pic_capturingscreen.BackColor = System.Drawing.Color.White;
            this.pic_capturingscreen.Location = new System.Drawing.Point(31, 81);
            this.pic_capturingscreen.Name = "pic_capturingscreen";
            this.pic_capturingscreen.Size = new System.Drawing.Size(1110, 571);
            this.pic_capturingscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_capturingscreen.TabIndex = 6;
            this.pic_capturingscreen.TabStop = false;
            // 
            // frm_capturingscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pcdesgininig1.Properties.Resources._129;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 653);
            this.Controls.Add(this.pic_capturingscreen);
            this.Controls.Add(this.btn_showcapturing);
            this.Controls.Add(this.cmb_selectmachine);
            this.Controls.Add(this.lbl_selectmachine);
            this.Name = "frm_capturingscreen";
            this.Text = "capturingscreen";
            this.Load += new System.EventHandler(this.frm_capturingscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_capturingscreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showcapturing;
        private System.Windows.Forms.ComboBox cmb_selectmachine;
        private System.Windows.Forms.Label lbl_selectmachine;
        private System.Windows.Forms.PictureBox pic_capturingscreen;
    }
}