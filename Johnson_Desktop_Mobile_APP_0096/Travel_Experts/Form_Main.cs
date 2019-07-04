using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
    // CREATE A MAIN FORM WHICH IS THE FIRST FORM TO SHOW AS THE NAVIGATION BAR
    // Create agent and amin log in for different users.
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
// Bring home control 1 to current. Navigation not able to use before login.        
        private void Form1_Load(object sender, EventArgs e)
        {
            Navigation(false);
            homeControl1.BringToFront();
            DateTime dateTime = DateTime.Now;
            txtTime.Text = dateTime.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeControl1.BringToFront();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            suppliersControl1.BringToFront();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            productControl1.BringToFront();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            packagesControl1.BringToFront();
        }

        //private void btnPreview_Click(object sender, EventArgs e)
        //{
        //    //previewControl1.BringToFront();
        //}

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            administratorControl1.BringToFront();
        }


        private void picBoxFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void pictureBoxInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void pictureBoxTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com/");
        }

        private void pictureBoxTwitt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/");

        }

   

        private void pbShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  //  Create a navigation bar to turn on or off
  // Admin can use all buttons
        public void Navigation(bool TF)
        {
            btnPackages.Enabled =TF;
            btnProducts.Enabled = TF;
            btnSuppliers.Enabled = TF;
           // btnPreview.Enabled = TF;
            btnAdmin.Enabled = TF;
        }
        // Agent ccan not use Admin button
        public void AgentNavigation (bool TF)
        {
            btnPackages.Enabled = TF;
            btnProducts.Enabled = TF;
            btnSuppliers.Enabled = TF;
            //btnPreview.Enabled = TF;
        }
        // When logged out, can not use navigation bar and bring homecontrol to front
        public void Logout (bool TF)
        {
            homeControl1.BringToFront();
            Navigation(false);
        }

        //private void homeControl1_Load(object sender, EventArgs e)
        //{

        //}

        //private void administratorControl1_Load(object sender, EventArgs e)
        //{

        //}

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form newForm = new frmHome();
            newForm.Show();
            //frmHome.BringToFront();
        }
    }
}
