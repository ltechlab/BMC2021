using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Management;
using System.Text.RegularExpressions;

namespace BMC2021
{
    public partial class SplashScreen : Form
    {
        POSDBEntities2 db = new POSDBEntities2();
        String s, ss;


        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Teal;
            progressBar1.Value = progressBar1.Value + 10;
            if (progressBar1.Value == 80)
            {
                progressBar1.Value = progressBar1.Value + 20;
                if (progressBar1.Value >= progressBar1.Maximum)
                {
                    timer1.Enabled = false;


                    Login frm = new Login();
                    frm.Show();
                    this.Hide();


                }
            }
        }


        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
