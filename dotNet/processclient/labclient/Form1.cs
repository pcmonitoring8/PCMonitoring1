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
using System.Drawing.Imaging;

namespace labclient
{
    public partial class Frm1 : Form
    {
        string serverloc = "\\\\vcpc-4\\Processlist\\";
        string fnm = Application.StartupPath + "\\MyFile.txt";
       
        public Frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtmachinname.Text = System.Environment.MachineName;
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            string proInfo = null;
            Process[] p1 = null;

            FileStream f1 = new FileStream(fnm, FileMode.Create);
            StreamWriter wr = new StreamWriter(f1);

            ListBox1.Items.Clear();

            p1 = Process.GetProcesses();
            for (i = 0; i <= p1.Length -1 ;i++)
                
            {
                try
                {
                    proInfo = p1[i].ProcessName + "-" + p1[i].StartTime.ToString() + " " + p1[i].MainWindowTitle.ToString() + " " + p1[i].Responding.ToString();

                    ListBox1.Items.Add(proInfo);
                    wr.WriteLine(proInfo);

                }
                catch (Exception ex)
                {
                }
            }
            wr.Close();
            File.Copy(fnm, serverloc + txtmachinname.Text + ".txt", true);
       
        }

   
    }

        
    }

