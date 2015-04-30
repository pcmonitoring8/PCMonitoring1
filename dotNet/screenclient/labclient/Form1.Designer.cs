namespace labclient
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Label1 = new System.Windows.Forms.Label();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.txtmachinname = new System.Windows.Forms.TextBox();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(26, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Machine Name";
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(409, 76);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(383, 381);
            this.picCapture.TabIndex = 7;
            this.picCapture.TabStop = false;
            // 
            // txtmachinname
            // 
            this.txtmachinname.Location = new System.Drawing.Point(154, 38);
            this.txtmachinname.Name = "txtmachinname";
            this.txtmachinname.Size = new System.Drawing.Size(131, 20);
            this.txtmachinname.TabIndex = 6;
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(12, 76);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(391, 381);
            this.ListBox1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 5000;
            //this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 478);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.picCapture);
            this.Controls.Add(this.txtmachinname);
            this.Controls.Add(this.ListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox picCapture;
        internal System.Windows.Forms.TextBox txtmachinname;
        internal System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

