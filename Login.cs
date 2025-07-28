using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMC2021
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tb_passinput.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (POSDBEntities2 db = new POSDBEntities2()) { 
            //AUTHENTICATE CREDENTIALS
            //GET USERNAME
            string input_username = tb_userinput.Text;
            string input_password = tb_passinput.Text;
                //check DB for username
                var isExist = db.admin_users.Any(r => r.username == input_username);

                if (isExist)
                {

                   var query =
                   from ord in db.admin_users
                   where ord.username == input_username
                   select ord;
                  
                    foreach (admin_users ord in query)
                    {
                        if(ord.username==input_username && ord.password == input_password)
                        {

                            var query2 =
                           from orda in db.current_user
                           where orda.id == 1
                           select orda;

                            foreach (current_user orda in query2)
                            {
                             //   current_user cuser = new current_user()
                           
                                orda.fullname = ord.fullname;
                                orda.description = ord.designation;
                                orda.username = ord.username;
                                orda.password = ord.password;
                                orda.admin = ord.admin;
                            }

                            // Submit the changes to the database.
                            try
                            {
                                db.SaveChanges();
                            }
                            catch (Exception ee)
                            {
                                Console.WriteLine(ee);
                                // Provide for exceptions.
                            }
                            db.SaveChanges();
                        //    MessageBox.Show("WELCOME!");
                            MainDash frm = new MainDash();
                                        frm.Show();
                                        this.Hide();
                                  
                        }else
                        {
                            lb_note.Text = "WRONG PASSWORD!";
                        }             
                    }

                }else
                {
                    lb_note.Text = "USERNAME DOES NOT EXIST!";
                   
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                Application.Exit();
                //kill process
                //Environment.Exit(0);


            }
            else
            {
                // Console app
                System.Environment.Exit(0);
            }
        }
    }
}
