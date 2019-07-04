using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Query;

namespace Travel_Experts
{
    //Search, view and export to excel/pdf all the suppliers
    //Lead Programmer: Mo Sagnia
    //Date: 11th February 2019
    public partial class AdminControlSup : UserControl
    {
        //establish general query for suppliers
        string supQryAll = SQLforDataGrid.SqlQuery("Suppliers", "*", "SupplierId");

        public AdminControlSup()
        {
            InitializeComponent();
        }

        private void AdminControlSup_Load(object sender, EventArgs e)
        {
            //select a default value for search option (combo box)
            cboSearch.SelectedIndex = 0;

            //set the source of the data to be displayed in the grid view
            supplierGridView.DataSource = bindingSourceSupplier;

            //get table for packages
            DataGridDB.GetDGData(supQryAll, supplierGridView, bindingSourceSupplier);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cboSearch.SelectedItem.ToString())
            {
                case "All":
                    //validate input from user
                    if (!Validator.IsProvided(txtSearch, lblEmpty)) { }
                    else
                    {
                        DataGridDB.GetDGData("SELECT * FROM SUPPLIERS WHERE lower(CONCAT(SupplierId, SupName)) like '%" + txtSearch.Text.ToLower() + "%'", supplierGridView, bindingSourceSupplier);

                        //if there are is no match to the database:
                        if (supplierGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Unable to find a match");
                            DataGridDB.GetDGData(supQryAll, supplierGridView, bindingSourceSupplier);
                        }
                    }
                    break;

                case "Id":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsNonZeroPositiveInt(txtSearch, lblId)) { }
                    else
                    {
                        DataGridDB.GetDGData("SELECT * from Suppliers where lower(SupplierId) like '%" + txtSearch.Text + "%'", supplierGridView, bindingSourceSupplier);
                        //if there are is no match to the database:
                        if (supplierGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Unable to find a match");
                            DataGridDB.GetDGData(supQryAll, supplierGridView, bindingSourceSupplier);
                        }
                    }
                    break;

                case "Name":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsString(txtSearch, lblName)) { }
                    else
                    {
                        DataGridDB.GetDGData("SELECT * from Suppliers where lower(SupName) like '%" + txtSearch.Text + "%'", supplierGridView, bindingSourceSupplier);

                        //if there are is no match to the database:
                        if (supplierGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Unable to find a match");
                            DataGridDB.GetDGData(supQryAll, supplierGridView, bindingSourceSupplier);
                        }
                    }
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset default value for search option (combo box)
            cboSearch.SelectedIndex = 0;

            //clear text fields and default background color
            txtSearch.Text = "";
            txtSearch.BackColor = Color.White;

            //visible false error messages if any
            lblCurrency.Visible = false;
            lblEmpty.Visible = false;
            lblId.Visible = false;
            lblName.Visible = false;

            //focus on search text field
            txtSearch.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //get table for suppliers
            DataGridDB.GetDGData(supQryAll, supplierGridView, bindingSourceSupplier);
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblId.Visible = false;
            lblName.Visible = false;
            lblEmpty.Visible = false;
            txtSearch.BackColor = Color.White;

        }

        private void pctExcel_Click(object sender, EventArgs e)
        {
            Exportto.Excel(supplierGridView, "Supplier Information", saveExcelFile);
        }

        private void pctPdf_Click(object sender, EventArgs e)
        {
            Exportto.Pdf(supplierGridView, "Supplier Information", savePDFFile);
        }
    }
}
