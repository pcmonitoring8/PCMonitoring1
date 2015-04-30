using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace pcdesgininig1
{
     public partial class frm_reg : Form
    {

         //OleDbConnection cn = new OleDbConnection("Provider=MSDAORA;User Id=pc;Password=pcpc");
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\SMS PC Control\dotNet\pcdesgininig1\bin\Debug\dbpccontrol1.mdb");
        //ConnectionOptions co = new ConnectionOptions();

        public frm_reg()
        {
            InitializeComponent();
        }

       

       

        private void btn_submit_Click(object sender, EventArgs e)
        {

            OleDbCommand cmd = new OleDbCommand();
             cmd.Connection = cn;
                string  qry = "insert into tbl_registration values('" + txt_name.Text + "'," +txt_mobilenumber.Text + ",'" + txt_password.Text + "','" + txt_emailid.Text + "')";
                cmd.CommandText = qry;
                cmd.ExecuteNonQuery();

        
            
        

                string z = txt_password.Text;
                string z1 = txt_confirmpassword.Text;

                if (z == z1)
                {
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = regex.Match(txt_emailid.Text);
                    if (match.Success)
                       
                    { 
                        MessageBox.Show("Registration sucessfully"); 
                    }
                    else
                        MessageBox.Show("Not Correct");
                    
                }
                else
                {

                    MessageBox.Show("password not match");
                }
            
           
        }

        private void txt_name_KeyPress_1(object sender, KeyPressEventArgs e)
         {
             int val = Convert.ToInt16(e.KeyChar);
             if (!(val > 64 && val < 91 || val > 96 && val < 123 || val == 32 || val == 8 || val == 13))
             {
                 MessageBox.Show("Accept only alphabets");
                 e.Handled = true;
             }
             
         }

         private void txt_mobileno_KeyPress_1(object sender, KeyPressEventArgs e)
         {
             int val = Convert.ToInt16(e.KeyChar);
             if (!(val > 47 && val < 58 || val == 8 || val == 13))
             {
                 MessageBox.Show("Number accept only");
                 e.Handled = true;
             }

         }

        

         private void btn_cancel_Click_1(object sender, EventArgs e)
         {
             System.Environment.Exit(0);
         }

         private void frm_reg_Load(object sender, EventArgs e)
         {
             cn.Open();
         }

       

        

         

         


        }
    }

