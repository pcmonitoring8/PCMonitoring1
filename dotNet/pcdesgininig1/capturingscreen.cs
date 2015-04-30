using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace pcdesgininig1
{
    public partial class frm_capturingscreen : Form
    {
        string serverloc = "\\\\HP-PC\\Projects\\";
        public frm_capturingscreen()
        {
            InitializeComponent();
        }

        private void btn_showcapturing_Click(object sender, EventArgs e)
        {
            string mname = cmb_selectmachine.Text.Trim();
            pic_capturingscreen.ImageLocation = serverloc + mname.Substring(2) + ".jpg";
        }

        private void frm_capturingscreen_Load(object sender, EventArgs e)
        {
            Process netsend = new Process();
            netsend.StartInfo.FileName = "net.exe";
            netsend.StartInfo.CreateNoWindow = true;
            netsend.StartInfo.Arguments = "view";
            netsend.StartInfo.RedirectStandardOutput = true;
            netsend.StartInfo.UseShellExecute = false;
            netsend.StartInfo.RedirectStandardError = true;
            netsend.Start();
            string pc = null;
            Int16 i = 0;
            cmb_selectmachine.Items.Clear();
            StreamReader sr = new StreamReader(netsend.StandardOutput.BaseStream, netsend.StandardOutput.CurrentEncoding);
            string sss = "";
            string MName = null;
            if (string.IsNullOrEmpty(cmb_selectmachine.Text))
            {
                while (true)
                {
                    sss = sr.ReadLine();
                    try
                    {
                        if (sss.StartsWith("\\"))
                        {
                            MName = sss.Substring(0, sss.Length);
                            cmb_selectmachine.Items.Add(MName);
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("not found");
                        break; // TODO: might not be correct. Was : Exit Try
                    }
                    if (sss == null & cmb_selectmachine.Items.Count > 0)
                    {
                        break; // TODO: might not be correct. Was : Exit While
                    }
                }
                sr.Close();
                netsend.WaitForExit(1000);
            }
        }

       

       
    }
}
