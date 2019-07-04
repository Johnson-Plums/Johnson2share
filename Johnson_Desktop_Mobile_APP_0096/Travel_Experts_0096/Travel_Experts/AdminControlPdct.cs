using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Query;

namespace Travel_Experts
{
    //Search, view and export to excel/pdf all the products
    //Lead Programmer: Mo Sagnia
    //Date: 11th February 2019
    public partial class AdminControlPdct : UserControl
    {
        //establish general query for suppliers
        string prodQryAll = SQLforDataGrid.SqlQuery("Products", "*", "ProductId");

        public AdminControlPdct()
        {
            InitializeComponent();
        }

        private void AdminControlPdct_Load(object sender, EventArgs e)
        {
            //select a default value for search option (combo box)
            cboSearch.SelectedIndex = 0;

            //set the source of the data to be displayed in the grid view
            productGridView.DataSource = bindingSourceProduct;

            //get table for packages
            DataGridDB.GetDGData(prodQryAll, productGridView, bindingSourceProduct);
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
                        DataGridDB.GetDGData("SELECT * FROM PRODUCTS WHERE lower(CONCAT(ProductId, ProdName)) like '%" + txtSearch.Text.ToLower() + "%'", productGridView, bindingSourceProduct);

                        //if there are is no match to the database:
                        if (productGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Unable to find a match");
                            DataGridDB.GetDGData(prodQryAll, productGridView, bindingSourceProduct);
                        }
                    }
                    break;

                case "Id":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsNonZeroPositiveInt(txtSearch, lblId)) { }
                    else
                    {
                        DataGridDB.GetDGData("SELECT * from Products where lower(ProductId) like '%" + txtSearch.Text + "%'", productGridView, bindingSourceProduct);
                        //if there are is no match to the database:
                        if (productGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Unable to find a match");
                            DataGridDB.GetDGData(prodQryAll, productGridView, bindingSourceProduct);
                        }
                    }
                    break;

                case "Name":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsString(txtSearch, lblName)) { }
                    else
                    {
                        DataGridDB.GetDGData("SELECT * from Products where lower(ProdName) like '%" + txtSearch.Text + "%'", productGridView, bindingSourceProduct);

                        //if there are is no match to the database:
                        if (productGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Unable to find a match");
                            DataGridDB.GetDGData(prodQryAll, productGridView, bindingSourceProduct);
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

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblId.Visible = false;
            lblName.Visible = false;
            lblEmpty.Visible = false;
            txtSearch.BackColor = Color.White;
        }

        private void pctExcel_Click(object sender, EventArgs e)
        {
            Exportto.Excel(productGridView, "Product Information", saveExcelFile);
        }

        private void pctPdf_Click(object sender, EventArgs e)
        {
            Exportto.Pdf(productGridView, "Product Information", savePDFFile);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //get table for products
            DataGridDB.GetDGData(prodQryAll, productGridView, bindingSourceProduct);
        }
    }
}
