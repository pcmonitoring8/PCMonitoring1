using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMS_SEND_RECEIVE;
using System.IO;
using System.Management;
using System.Diagnostics;
using System.Net.Mail;
using System.Data.OleDb;
using System;
using  System.Collections.Generic;
using System.Data;
using System.ComponentModel;


namespace pcdesgininig1
{
    
    public partial class smsengine : Form
    {
        SMS_SEND_RECEIVE.SMS_SEND_RECEIVE mainsms = new SMS_SEND_RECEIVE.SMS_SEND_RECEIVE();

        
        

         OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\SMS PC Control\dotNet\pcdesgininig1\bin\Debug\dbpccontrol1.mdb");
         ConnectionOptions co = new ConnectionOptions();
       
        public smsengine()
        {

            InitializeComponent();
           // mainsms.openPort("COM14");
        }
         private string searchvalue(string qry)
        {
            string result = "";
            OleDbDataAdapter da = new OleDbDataAdapter(qry, cn);
            DataSet ds = new DataSet("tmp");
            da.Fill(ds, "tmp");
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    result = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                result = "";
            }
            return result;

        }
        private string saverecord(string qry)
        {
            string result = "1";
            OleDbCommand cmd = new OleDbCommand();
            cn.Open();
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = qry;
                cmd.ExecuteNonQuery();
                result = "1";
            }
            catch (Exception ex)
            {
                result = "-1";
            }
            cn.Close();
            return result;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //string[] msgs;
            string mm = "";
            // b:
            //SMS_SEND_RECEIVE.SMS_SEND_RECEIVE mainsms = new SMS_SEND_RECEIVE.SMS_SEND_RECEIVE();

            string qry = "";
            string s1 = "";
            
                mainsms.openPort("COM14");
            
           
            if (mainsms.readSMS()==null)
            {
                timer1.Interval=6000;
            }

            else
            {
                
                 string messages = mainsms.readSMS();
            
            if (messages.Length > 0 || messages != null)
            {
                // mainsms.closePort();
                //try
                //{
                string[] msgs = messages.Split('Ç');

                if (messages.Equals("No message in inbox"))
                {
                    timer1.Interval = 6000;
                }

                else
                {


                    int i = msgs.Length - 2;
                    if (i < 0)
                    {
                        timer1.Interval = 6000;
                    }
                    // for (i = 0; i < msgs.Length - 2; i++)
                    {
                        if (msgs.Length == 1 || msgs.Length == 0)
                        {
                            timer1.Interval = 6000;
                        }
                        string srno = msgs[i].Split('ô')[0];
                        if (srno == null || srno.Length == 0 || srno.Length == 1)
                        {
                            timer1.Interval = 6000;
                        }
                        string dttmpart = msgs[i].Split('ô')[1];
                        string dtpart = dttmpart.Split(' ')[0];

                        string dttm = dttmpart.Split(' ')[2];// This is because 2 Spaces Are Within Date And Time..
                        if (dttm == null || dttm.Length < 0)
                        {
                            timer1.Interval = 6000;
                        }
                        dtpart = dtpart.Replace('/', '-');// This is For Converting Date in Proper Format

                        DateTime rdt = DateTime.Now;
                        string rdate = "";
                        try
                        {
                            rdt = DateTime.ParseExact(dtpart, "dd/MM/yyyy", null);
                            rdate = rdt.ToString("dd-MMM-yyyy");

                        }
                        catch (Exception ex)
                        {
                        }





                        string msgfrom = msgs[i].Split('ô')[3].Trim();
                        string regusermail = "";
                        if (msgfrom.Contains("91"))
                            msgfrom = msgfrom.Substring(2);

                        qry = "select reg_email from tbl_registration where reg_MobNo='" + msgfrom + "'";
                        regusermail = searchvalue(qry);
                        if (regusermail == "")
                        {
                            return;
                        }

                        string receivedmsg = msgs[i].Split('ô')[4];

                        // Of Msg Starts With \n .. It Must be reconstruct Using Substring Function
                        if (receivedmsg.Contains("\n"))
                            receivedmsg = receivedmsg.Substring(1);

                        try
                        {
                            // Check If That Message Already Read 
                            qry = "Select SMS_FROM from TBL_SMSLOG Where SMS_FROM='" + msgfrom + "' And SMS_DTTM='" + dttmpart + "'";
                            if (searchvalue(qry) != "")
                            {
                                return;
                            }
                            //Saves To SMS Log table
                            qry = "Insert Into tbl_smslog values('" + msgfrom + "','" + dttmpart + "','" + receivedmsg + "')";
                            s1 = saverecord(qry);

                        }
                        catch (Exception ex)
                        {
                        }


                        // Processing The SMS
                        // 1. request For Process List On Specific Machine
                        // Format: "Processlist VCPC-2"

                        //2. Start Or Kill Process
                        // Format: "Start notepad.exe VCPC-2" 


                        //3. Get Disk Space
                        // Format: "Diskspace C: VCPC-2" 


                        //4. Share File And Send Mail
                        // Format: "Share abc@gmail.com \\VCPC-2\projects\1.doc" 


                        //5. Capture Descktop Screen and Send Mail
                        // Format: "Capture abc@gmail.com VCPC-2" 

                        //6. Block Site????
                        // Format: ?????
                        //receivedmsg = "Share vishram85@gmail.com \\\\VCPC-44\\Academic\\Trial.txt";
                        //receivedmsg = "Capture vishram85@gmail.com VCPC-2";
                        string pcnm = "";
                        if (receivedmsg.Contains("Processlist"))
                        {
                            // Process List On Machine
                            string prclist = "";
                            pcnm = receivedmsg.Split(' ')[1];
                            string line = "";
                            //StreamReader fread = new StreamReader("\\Server\\" + pcnm + ".txt");
                            StreamReader fread = new StreamReader(Program.serverpath + "\\" + pcnm + ".txt");
                            while ((line = fread.ReadLine()) != null)
                            {


                                if (
                                    (line.Contains("winword"))
                                    || (line.Contains("calc"))
                                    || (line.Contains("mspaint"))
                                    || (line.Contains("msaccess"))
                                    || (line.Contains("excel"))
                                    || (line.Contains("iexpolre"))
                                    || (line.Contains("acrord32"))
                                    || (line.Contains("cmd"))
                                    || (line.Contains("powerpnt"))
                                    || (line.Contains("firefox"))
                                    || (line.Contains("chrome"))
                                    || (line.Contains("notepad"))
                                  )
                                {
                                    prclist += line + ",";
                                }
                            }
                            fread.Close();

                            // Code To Send SMS Of ProcessList To Admin
                            mainsms.openPort("COM14");
                            mainsms.sendSMS(msgfrom, prclist);
                            //mainsms.closePort();

                        }
                        else if ((receivedmsg.Contains("Start")) || (receivedmsg.Contains("Kill")))
                        {
                            // Start Or Kill Process
                            string processnm = receivedmsg.Split(' ')[1];
                            pcnm = receivedmsg.Split(' ')[2];
                            if (receivedmsg.Contains("Start"))
                            {
                                try
                                {
                                    pcnm = pcnm.Trim().ToUpper();
                                    //pcnm = pcnm.Substring(1);
                                    // Code To Write Command To The File ...
                                    int flg = 1;
                                    // check process is started
                                    string prclist = "";
                                    string line = "";
                                    //StreamReader fread = new StreamReader("\\Server\\" + pcnm + ".txt");
                                    StreamReader fread = new StreamReader(Program.serverpath + "\\" + pcnm + ".txt");
                                    while ((line = fread.ReadLine()) != null)
                                    {
                                        string ss = processnm.Substring(0, processnm.Length - 4);
                                        if (line.Contains(ss))
                                        {
                                            flg = 0;
                                            break;
                                        }

                                    }
                                    fread.Close();

                                    //ends 
                                    if (flg == 1)
                                    {
                                        StreamWriter outfile = new StreamWriter(Program.serverpath + "\\op.txt", true);

                                        outfile.WriteLine(pcnm.Trim() + " " + processnm);
                                        outfile.Close();

                                    }

                                    // Code To Send SMS Of ProcessList To Admin
                                    mainsms.openPort("COM14");
                                    if (flg == 1)
                                    {
                                        mainsms.sendSMS(msgfrom, processnm + " is started on " + pcnm);
                                    }
                                    else
                                    {
                                        mainsms.sendSMS(msgfrom, " Process is already running on PC " + pcnm);
                                    }
                                    //mainsms.closePort();

                                }

                                catch (Exception ex)
                                { }

                            }
                            else
                            {
                                try
                                {

                                    Process p1 = new Process();
                                    p1.StartInfo.FileName = Application.StartupPath + "\\pskill.exe";
                                    p1.StartInfo.Arguments = "\\\\" + pcnm + "  " + processnm;
                                    p1.Start();
                                    System.Threading.Thread.Sleep(1000);

                                    // Code To Send SMS Of ProcessList To Admin

                                    mainsms.openPort("COM14");
                                    mainsms.sendSMS(msgfrom, processnm + " is Killed on PC" + pcnm);
                                     //mainsms.closePort();

                                }

                                catch (Exception ex)
                                { }



                            }

                        }

                        else if (receivedmsg.Contains("Diskspace"))
                        {
                            // Get Disk Space
                            string drivenm = receivedmsg.Split(' ')[1];
                            pcnm = receivedmsg.Split(' ')[2];

                            string content = "";
                            content = getDiskSpace(pcnm, drivenm);

                            // Code To Send SMS Of ProcessList To Admin
                            mainsms.openPort("COM14");
                            mainsms.sendSMS(msgfrom, content + "GB");
                            //mainsms.closePort();


                        }
                        else if (receivedmsg.Contains("Shutdown"))
                        {
                            pcnm = receivedmsg.Split(' ')[1];

                            Process proc = new System.Diagnostics.Process();
                            proc.EnableRaisingEvents = false;

                            proc.StartInfo.Arguments = "-s -m \\\\" + pcnm;
                            proc.StartInfo.FileName = "C:\\WINDOWS\\system32\\shutdown.exe";
                            proc.Start();


                            // Code To Send SMS Of ProcessList To Admin
                            mainsms.openPort("COM14");
                            mainsms.sendSMS(msgfrom, pcnm + " PC Shutdown successfully");
                            // mainsms.closePort();


                        }



                        else if (receivedmsg.Contains("Restart"))
                        {

                            pcnm = receivedmsg.Split(' ')[1];
                            System.Diagnostics.Process proc = new System.Diagnostics.Process();
                            proc.EnableRaisingEvents = false;

                            proc.StartInfo.Arguments = "-r -m " + pcnm;
                            proc.StartInfo.FileName = "C:\\WINDOWS\\system32\\shutdown.exe";
                            proc.Start();

                            mainsms.openPort("COM14");
                            mainsms.sendSMS(msgfrom, pcnm + " PC Restarted successfully ");

                            //mainsms.closePort();
                        }


                        else if (receivedmsg.Contains("Fileshare"))
                        {
                            // Share File Name- get On Mail
                            string mailid = receivedmsg.Split(' ')[1];
                            string ss1 = receivedmsg.Split(' ')[2];
                            //string ss2 = receivedmsg.Split(' ')[3];
                            string fileloc = ss1;// +"\\" + ss2;


                            //  Send mail With Attachment For The Shared File...
                            //  File.Copy(fileloc, Application.StartupPath(""));
                            string content = "As per Your Request The Shared File is Attached herewith..";
                            if (SendMail(mailid, content, "Shared File", fileloc) == "Successful")
                            {
                                qry = "Insert Into tbl_maillog values('" + mailid + "','" + dttmpart + "','Shared File','" + fileloc + "')";
                                s1 = saverecord(qry);

                                // MessageBox.Show("Mail Sent Successfully");
                                mainsms.sendSMS(msgfrom, pcnm + "Mail Send Successfully");
                            }
                            else
                            {
                                //MessageBox.Show("Unable To Sent Mail");
                            }

                        }
                        else if (receivedmsg.Contains("Capture"))
                        {
                            // get Capture Screen Image On Mail
                            string mailid = regusermail;// receivedmsg.Split(' ')[1];
                            pcnm = receivedmsg.Split(' ')[1];
                            string fileloc = Program.serverpath + "\\" + pcnm + ".jpg";
                            string content = " As per Your Request The Screen Captured is Attached herewith..";
                            SendMail(mailid, content, "Shared File", fileloc);
                            if (SendMail(mailid, content, "Captured Screen  Of " + pcnm, fileloc) == "Successful")
                            {
                                qry = "Insert Into tbl_maillog values('" + mailid + "','" + dttmpart + "','Captured Screen','" + fileloc + "')";
                                s1 = saverecord(qry);
                                //MessageBox.Show("Mail Sent Successfully");
                            }
                            else
                            {
                                //MessageBox.Show("Unable To Sent Mail");
                            }

                            mainsms.sendSMS(msgfrom, pcnm + "Mail Send Successfully");

                        }
                        mainsms.deleteSMS();
                        //if(response=="")
                     // mainsms.closePort();

                    }
                }
            }
           
        }
        }
        //catch(Exception ex)
    //{
        
            //mainsms.sendSMS("7040219264", ex.Message);
        
      //  }
      //  }
      //ends
        
        private string getDiskSpace(string pcnm, string drivenm)
        {
            string result = "";
            pcnm = "\\" + pcnm;
            //ConnectionOptions co = new ConnectionOptions();

            //ObjectQuery oQuery = new ObjectQuery("SELECT Size, FreeSpace, Name, FileSystem FROM Win32_LogicalDisk WHERE DriveType = 3");
            //co.Impersonation = ImpersonationLevel.Impersonate;
            //co.Authentication = AuthenticationLevel.Packet;
            //co.Timeout = new TimeSpan(0, 0, 30);
            //co.EnablePrivileges = true;
            //co.Username = "Administrator";
            //co.Password = "transport";

            //ManagementScope scope = new ManagementScope("" + pcnm  + "\\root\\cimv2", co);
            //ManagementObjectSearcher moSearcher = new ManagementObjectSearcher(scope, oQuery);
            //ManagementObjectCollection collection = moSearcher.Get();
            //foreach (ManagementObject res in collection)
            //{
            //    decimal size = Decimal.Round(Convert.ToDecimal(res["Size"]) / 1024 / 1024 / 1024);
            //    decimal freeSpace = Decimal.Round(Convert.ToDecimal(res["FreeSpace"]) / 1024 / 1024 / 1024);
            //    string nm = res["Name"].ToString();
            //    if (nm == drivenm)
            //    {
            //        MessageBox.Show("" + nm + " Total Size " + size + "  And Free Size " + freeSpace);
            //        result = "Total Size: " + size + " Free Size: " + freeSpace;
            //        break;
            //    }
            //}
            ObjectQuery oQuery = new ObjectQuery("SELECT Size, FreeSpace, Name, FileSystem FROM Win32_LogicalDisk WHERE DriveType = 3");
            co.Impersonation = ImpersonationLevel.Impersonate;
            co.Authentication = AuthenticationLevel.Packet;
            co.Timeout = new TimeSpan(0, 0, 30);
            co.EnablePrivileges = true;
            co.Username = "Administrator";
            co.Password = "transport";

            ManagementScope scope = new ManagementScope("\\" + pcnm  + "\\root\\cimv2", co);
            ManagementObjectSearcher moSearcher = new ManagementObjectSearcher(scope, oQuery);
            ManagementObjectCollection collection = moSearcher.Get();
            foreach (ManagementObject res in collection)
            {
                decimal size = Decimal.Round(Convert.ToDecimal(res["Size"]) / 1024 / 1024 / 1024);
                decimal freeSpace = Decimal.Round(Convert.ToDecimal(res["FreeSpace"]) / 1024 / 1024 / 1024);
                string nm = res["Name"].ToString();
                if (nm == drivenm)
                {
                  //  MessageBox.Show("" + nm + " Total Size " + size + "  And Free Size " + freeSpace);
                    result = "Total Size: " + size + " Free Size: " + freeSpace;
                    break;
                }
               
            }
            //lstDiskSpace.Items.Add(nm + "::" + size + "::" + freeSpace);
            return result;
        }
        private string SendMail(string mto, string content,string subject,string filepath)
        {
            string result = "";
            try
            {
                SmtpClient SmtpServer = new SmtpClient();
                MailMessage mail = new MailMessage();
                Attachment attach= new Attachment(filepath);

               // SmtpServer.Credentials = new System.Net.NetworkCredential("pcmonitoring8@gmail.com", "smsbased8");
                SmtpServer.Credentials = new System.Net.NetworkCredential("vishram85@gmail.com", "v!shram123456");

                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.gmail.com";

                mail = new MailMessage(); //New Mail
                mail.From = new MailAddress("vishram85@gmail.com"); //From Address
                mail.To.Add(mto );  // To Address
                mail.Subject = subject ;  //Subject

                mail.Attachments.Add(attach);

                mail.Body =content ;                       // Assign Encrypted Value to Message Body
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                result = "Successful";
            }
            catch (Exception ex)
            {
                //str = "insert into TBL_SENDMAIL values('" + txt_from.Text + "','" + ddlist_to.Text + "','" + txt_subject.Text + "','" + ciphertext + "','N')";  //Mail Sendig Failed
                result = "Error";
            }
            return result;
        }

        private void smsengine_Load(object sender, EventArgs e)
        {
           timer1.Start();
          


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            do
            {

                btnRead_Click(sender, e);
            } while (timer1.Interval> 6000);
        }
       

        }
    }

