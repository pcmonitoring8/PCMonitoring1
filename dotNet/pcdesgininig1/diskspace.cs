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
using System.Management;
namespace pcdesgininig1
{
    public partial class frm_diskspace : Form
    {

        string serverloc = "\\\\HP-PC\\Projects\\";
        ConnectionOptions co = new ConnectionOptions();
        public frm_diskspace()
        {
            InitializeComponent();
        }


        private void frm_diskspace_Load(object sender, EventArgs e)
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

        private void btn_showdisk_Click(object sender, EventArgs e)
        {

            ObjectQuery oQuery = new ObjectQuery("SELECT Size, FreeSpace, Name, FileSystem FROM Win32_LogicalDisk WHERE DriveType = 3");
            co.Impersonation = ImpersonationLevel.Impersonate;
            co.Authentication = AuthenticationLevel.Packet;
            co.Timeout = new TimeSpan(0, 0, 30);
            co.EnablePrivileges = true;
            co.Username = "Administrator";
            co.Password = "transport";

            ManagementScope scope = new ManagementScope("" + cmb_selectmachine.Text.Trim() + "\\root\\cimv2", co);
            ManagementObjectSearcher moSearcher = new ManagementObjectSearcher(scope, oQuery);
            ManagementObjectCollection collection = moSearcher.Get();
            foreach (ManagementObject res in collection)
            {
                decimal size = Decimal.Round(Convert.ToDecimal(res["Size"]) / 1024 / 1024 / 1024);
                decimal freeSpace = Decimal.Round(Convert.ToDecimal(res["FreeSpace"]) / 1024 / 1024 / 1024);
                string nm = res["Name"].ToString();

                if (nm == cmb_selectdisk.Text && cmb_selectdisk.Text != "All")
                {
                    lbl_totalsize.Text = "Total Size = " + size + "GB";
                    lbl_freesize.Text = "Free Size = " + freeSpace + "GB";

                    break;

                }

                if (nm != cmb_selectdisk.Text && cmb_selectdisk.Text == "All")
                {
                    MessageBox.Show("" + nm + " Total Size " + size + "  And Free Size " + freeSpace);
                    /*int allsize = 0 + size;
                    MessageBox.Show("" + nm + " Total Size " + allsize); */
                    lbl_totalsize.Text = "";
                    lbl_freesize.Text = "";
                }

            }
            //lstDiskSpace.Items.Add(nm + "::" + size + "::" + freeSpace);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        

        

        
       
    
