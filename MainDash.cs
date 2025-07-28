using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMC2021
{
    
    public partial class MainDash : Form
    {

       
        public MainDash()
        {
            InitializeComponent();
            DisplayCurrentUser();
        }

        private void DisplayCurrentUser()
        {
            POSDBEntities2 db = new POSDBEntities2();
            var query =
                from ord in db.current_user
                where ord.id == 1
                select ord;

            foreach (current_user ord in query)
            {
                lb_current_fullname.Text = ord.fullname;
                lb_designation.Text = ord.description;

                if (ord.admin == 1)
                {

                    lb_admin.Text = "ADMIN USER";
                }
                else
                {

                    lb_admin.Text = "NORMAL USER";
                }
            }
            
        }

        private void USERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            
            BusinessProfile frm = new BusinessProfile();
            frm.Show();
            
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            Btn_POS.Enabled = true;
            PointOfSales frm = new PointOfSales();
            frm.Show();
            
        }


        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Lb_admin_Click(object sender, EventArgs e)
        {

        }

        private void Lb_designation_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ChangePassword frm = new ChangePassword();
            frm.Show();
            
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Inventory frm = new Inventory();
            frm.Show();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            
            if (lb_admin.Text == "ADMIN USER")
            {
                Analytics frm = new Analytics();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can access this feature.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            
            if (lb_admin.Text == "ADMIN USER")
            {
                FinanceMonitoring frm = new FinanceMonitoring();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can access this feature.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ADMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
         
            
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            SalesMonitoring frm = new SalesMonitoring(); //yep. Yan talaga yung name ng orders form lol
            frm.Show();
         
        }

        private void HELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"\" + "Layertech BMC Manual.chm");
            //Help.ShowHelp(this, "file://C:\\Users\\Frei\\source\\repos\\BMC2021\\BMC21.chm");
            Help.ShowHelp(this, Application.StartupPath + @"\" + "BMC21.chm");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_current_fullname_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void eXITBMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to EXIT BMC?", "EXIT BMC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void contactDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us through support@layertechlab.com | www.Layertechlab.com ", "CONTACT LAYERTECH", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutBMCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ABOUT frm = new ABOUT();
            frm.Show();
        }

        private void adminControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_admin.Text == "ADMIN USER")
            {

                ADMIN frm = new ADMIN();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can access this feature.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void importCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void importToINVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_admin.Text == "ADMIN USER")
            {

                Import frm = new Import();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can access this feature.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void importToSALESMONITORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_admin.Text == "ADMIN USER")
            {

                ImportSM frm = new ImportSM();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can access this feature.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
