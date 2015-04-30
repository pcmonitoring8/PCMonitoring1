using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;


namespace pcdesgininig1
{
    public partial class frm_fileshare : Form
    {
        public frm_fileshare()
        {
            InitializeComponent();
        }





        private void btn_selectfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();
            f1.ShowDialog();
            txt_selectfile.Text = f1.FileName;

        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            SmtpClient SmtpServer = new SmtpClient();
            MailMessage mail = new MailMessage();
            Attachment at = new Attachment(txt_selectfile.Text );
            try
            {
                SmtpServer.Credentials = new System.Net.NetworkCredential(txt_useremail.Text, txt_password.Text);
                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.gmail.com";

                

                mail = new MailMessage();
                mail.From = new MailAddress(txt_useremail.Text);
                mail.To.Add(txt_adminemail.Text);
                mail.Attachments.Add(at);
                mail.Subject ="shared file attachement";
                mail.Body = "As per your request shared file is attached here with";
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

                MessageBox.Show("Mail Send");
            }
            catch (Exception ex)
            {

            }


        }

        private void txt_selectfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_fileshare_Load(object sender, EventArgs e)
        {

        }
    }

}