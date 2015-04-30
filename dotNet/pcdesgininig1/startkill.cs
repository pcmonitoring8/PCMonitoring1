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
    public partial class frm_startkill : Form
    {
        Process p1 = new Process();
        public frm_startkill()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {

            
            try
            {
                StreamWriter outfile = new StreamWriter(Program.serverpath  + "\\op.txt", true);
                string pcnm = cmb_selectmachine.Text.Trim();
                pcnm = pcnm.Substring(1);
                // Code To Write Command To The File ...

                outfile.WriteLine(cmb_selectmachine.Text.Trim().Substring(2) + " " + cmb_selectapp.Text);
                
                outfile.Close();
                


            }
            catch (Exception ex)
            { }

            

            /*if (cmb_selectapp.Text == "Notepad")
            {
                p1.StartInfo.FileName = "C:\\WINDOWS\\system32\\Notepad.exe";
                p1.Start();
            }

            if (cmb_selectapp.Text == "Mspaint")
            {
                p1.StartInfo.FileName = "C:\\WINDOWS\\system32\\Mspaint.exe";
                p1.Start();
            }

            if (cmb_selectapp.Text == "MSACCESS")
            {
                p1.StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\Office12\\MSACCESS.exe";
                p1.Start();
            }

            if (cmb_selectapp.Text == "MSWORD")
            {
                p1.StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\Office12\\WINWORD.exe";
                p1.Start();
            }

            if (cmb_selectapp.Text == "MSEXCEL")
            {
                p1.StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\Office12\\EXCEL.exe";
                p1.Start();
            }
            if (cmb_selectapp.Text == "MSPOWERPOINT")
            {
                p1.StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\Office12\\POWERPNT.exe";
                p1.Start();
            }
            if (cmb_selectapp.Text == "Calculator")
            {
                p1.StartInfo.FileName = "C:\\WINDOWS\\system32\\calc.exe";
                p1.Start();
            }


            if (cmb_selectapp.Text == "Remote Desktop")
            {
                p1.StartInfo.FileName = "C:\\WINDOWS\\system32\\mstsc.exe";
                p1.Start();
            }
            if (cmb_selectapp.Text == "Command Prompt")
            {
                p1.StartInfo.FileName = "C:\\WINDOWS\\system32\\cmd.exe";
                p1.Start();
            }*/
        }

        private void btn_kill_Click(object sender, EventArgs e)
        {
            p1.Kill();
        }

        private void frm_startkill_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
