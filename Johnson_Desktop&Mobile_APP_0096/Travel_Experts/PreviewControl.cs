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
    
    //Summary: The PDF Preview tab function that calls the AcroPdf library Com component. 
{
    public partial class PreviewControl : UserControl
    {
        public PreviewControl()
        {
            InitializeComponent();
        }

        private void openPDFToolStripMenuItem1_Click(object sender, EventArgs e) // creating the customer pdf dialog window
        {
            if (openFilePDFDialog.ShowDialog () == System.Windows.Forms.DialogResult.OK)
            {
                axAcroPDF1.src = openFilePDFDialog.FileName;
            }
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
