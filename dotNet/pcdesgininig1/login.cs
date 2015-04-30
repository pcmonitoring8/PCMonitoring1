using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pcdesgininig1
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
             
           
        { 
            
            if (txt_username.Text=="admin"  && txt_password.Text=="123")
            {
                MessageBox.Show("Login sucessfully");
                frm_reg f = new frm_reg();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
