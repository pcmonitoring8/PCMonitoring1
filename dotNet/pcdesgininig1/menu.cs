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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

       

        private void processlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_showprocesslist p = new frm_showprocesslist();
          //  p.MdiParent = this;
            p.ShowDialog();
            
        }

        private void diskSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_diskspace p1 = new frm_diskspace();
           // p1.MdiParent = this;
            p1.ShowDialog();
           
        }

        private void fileShareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_fileshare p2 = new frm_fileshare();
            //p2.MdiParent = this;
            p2.ShowDialog();
           
            
        }

        private void capturingScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_capturingscreen p3 = new frm_capturingscreen();
           // p3.MdiParent = this;
            p3.ShowDialog();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_startkill p4 = new frm_startkill();
            //p4.MdiParent = this;
            p4.ShowDialog();
            
        }

        private void appinfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_appinfo p5 = new frm_appinfo();
            //p5.MdiParent = this;
            p5.ShowDialog();
        }

        private void pcInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_pcnumbername p6 = new frm_pcnumbername();
           // p6.MdiParent = this;
            p6.ShowDialog();

        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reg p7 = new frm_reg();
            //p7.MdiParent = this;
            p7.ShowDialog();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login p8 = new frm_login();
           // p8.MdiParent = this;
            p8.ShowDialog();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void msgread_Click(object sender, EventArgs e)
        {
            smsengine p9 = new smsengine();
            //p7.MdiParent = this;
            p9.ShowDialog();


        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
