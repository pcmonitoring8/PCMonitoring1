using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace pcdesgininig1
{
    public partial class frm_shutdown : Form
    {
        Process p1 = new Process();
        public frm_shutdown()
        {
            InitializeComponent();
        }

        private void shutdown_Load(object sender, EventArgs e)
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
                            cmb_selectmachine.Items.Add(MName.TrimEnd());
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
            }
        }

      
       private void btn_restart_Click(object sender, EventArgs e)
       {
           System.Diagnostics.Process proc = new System.Diagnostics.Process();
           proc.EnableRaisingEvents = false;

           proc.StartInfo.Arguments = "-r -m " + cmb_selectmachine.Text.Substring(2);
           proc.StartInfo.FileName = "C:\\WINDOWS\\system32\\shutdown.exe";
           proc.Start();

       }

       private void btn_shutdown_Click_1(object sender, EventArgs e)
       {
           System.Diagnostics.Process proc = new System.Diagnostics.Process();
           proc.EnableRaisingEvents = false;

           proc.StartInfo.Arguments = "-s -m " + cmb_selectmachine.Text.Substring(2);
           proc.StartInfo.FileName = "C:\\WINDOWS\\system32\\shutdown.exe";
           proc.Start();
       }

       private void panel1_Paint(object sender, PaintEventArgs e)
       {

       }

       


       
    }
}
