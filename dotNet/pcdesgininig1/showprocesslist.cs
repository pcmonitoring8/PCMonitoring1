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
    public partial class frm_showprocesslist : Form
    {
        string serverloc = "\\\\HP-PC\\Projects\\";
        public frm_showprocesslist()
        {
            InitializeComponent();
        }

        private void showprocesslist_Load(object sender, EventArgs e)
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

        private void show_Click(object sender, EventArgs e)
        {
            lst_showprocesslist.Items.Clear();
            string mname = cmb_selectmachine.Text.Trim();
            lst_showprocesslist.Items.AddRange(System.IO.File.ReadAllLines(serverloc + mname.Substring(2) + ".txt"));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_selectmachine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
        
    }
