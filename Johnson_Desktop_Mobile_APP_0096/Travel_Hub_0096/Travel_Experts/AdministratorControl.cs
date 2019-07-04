using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
    public partial class AdministratorControl : UserControl
    {
        public AdministratorControl()
        {
            InitializeComponent();
        }

        private void btnAdminPkg_Click(object sender, EventArgs e)
        {
            adminControlPkg1.BringToFront();
        }

        private void adminControlPkg1_Load(object sender, EventArgs e)
        {

        }

        private void AdministratorControl_Load(object sender, EventArgs e)
        {
            adminControlPkg1.BringToFront();
        }

        private void btnAdminPdct_Click(object sender, EventArgs e)
        {
            adminControlPdct1.BringToFront();
        }

        private void btnAdminSup_Click(object sender, EventArgs e)
        {
            adminControlSup1.BringToFront();
        }
    }
}
