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
    public partial class frm_appinfo : Form
    {
        OleDbConnection cn = new OleDbConnection("Provider=MSDAORA;User Id=pc;Password=pcpc");
        public frm_appinfo()
        {
            InitializeComponent();
        }

        private void appinfo_Load(object sender, EventArgs e)
        {
            cn.Open();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            string qry = "insert into appinfo values(" + int.Parse(txt_appnumber.Text) + ",'" + txt_appname.Text + "','" + txt_path.Text + "')";
            cmd.CommandText = qry;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registration sucessfully");
        }

        private void txt_appnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            int val = Convert.ToInt16(e.KeyChar);
            if (!(val > 47 && val < 58 || val == 8 || val == 13))
            {
                MessageBox.Show("Number accept only");
                e.Handled = true;
            }

        }

        private void txt_appname_KeyPress(object sender, KeyPressEventArgs e)
        {
            int val = Convert.ToInt16(e.KeyChar);
            if (!(val > 64 && val < 91 || val > 97 && val < 123 || val == 32 || val == 8 || val == 13))
            {
                MessageBox.Show("Accept only alphabets");
                e.Handled = true;
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();
            f1.ShowDialog();
            txt_path.Text = f1.FileName;

        }

        

        private void txt_appnumber_TextChanged(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        
    }
}
