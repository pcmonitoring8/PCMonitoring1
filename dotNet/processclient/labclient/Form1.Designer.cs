namespace labclient
{
    partial class Frm1
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
            this.txtmachinname = new System.Windows.Forms.TextBox();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            // txtmachinname
            // 
            this.txtmachinname.Location = new System.Drawing.Point(154, 38);
            this.txtmachinname.Name = "txtmachinname";
            this.txtmachinname.Size = new System.Drawing.Size(131, 20);
            this.txtmachinname.TabIndex = 0;
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(12, 76);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(765, 394);
            this.ListBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::labclient.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 478);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtmachinname);
            this.Controls.Add(this.ListBox1);
            this.Name = "Frm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtmachinname;
        internal System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

