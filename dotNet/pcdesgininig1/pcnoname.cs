using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pcdesgininig1
{
    public partial class frm_pcnumbername : Form
    {

        OleDbConnection cn = new OleDbConnection("Provider=MSDAORA;User Id=pc;Password=pcpc");

        public frm_pcnumbername()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            string qry = "insert into pcno values(" + int.Parse(txt_pcnumber.Text) + ",'" + txt_pcname.Text + "','" + txt_pcip1.Text + "')";
            cmd.CommandText = qry;
            cmd.ExecuteNonQuery();
            double z = double.Parse(txt_pcip1.Text);
            if ((z <=255) && (z >=0))
            {
                MessageBox.Show("Registration sucessfully");
            }
            else
            {

                MessageBox.Show("invalid ip:");


            }
            lbl_ipp.Text = (txt_pcip1.Text + (".") + txt_pcip2.Text + (".") + txt_pcip3.Text + (".") + txt_pcip4.Text );

          
        }
        private void frm_pcnumbername_Load(object sender, EventArgs e)
        {
            cn.Open();
        }

        private void txt_pcnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            int val = Convert.ToInt16(e.KeyChar);
            if (!(val > 47 && val < 58 || val == 8 || val == 13))
            {
                MessageBox.Show("Number accept only");
                e.Handled = true;
                
            }
        }

        



        private void txt_pcip1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int val = Convert.ToInt16(e.KeyChar);
            if (!(val > 47 && val < 58 || val == 8 || val == 13))
            {
                MessageBox.Show("Number accept only");
                e.Handled = true;

            }

        }

        private void txt_pcip2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int val = Convert.ToInt16(e.KeyChar);
            if (!(val > 47 && val < 58 || val == 8 || val == 13))
            {
                MessageBox.Show("Number accept only");
                e.Handled = true;
            }


        }

        private void txt_pcip3_KeyPress(object sender, KeyPressEventArgs e)
        {
            int val = Convert.ToInt16(e.KeyChar);
            if (!(val > 47 && val < 58 || val == 8 || val == 13))
            {
                MessageBox.Show("Number accept only");
                e.Handled = true;
            }
        }

        private void txt_ip4_KeyPress(object sender, KeyPressEventArgs e)
        {
            int val = Convert.ToInt16(e.KeyChar);
            if (!(val > 47 && val < 58 || val == 8 || val == 13))
            {
                MessageBox.Show("Number accept only");
                e.Handled = true;
            }
        }

        

        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

       

        

        
    }
}