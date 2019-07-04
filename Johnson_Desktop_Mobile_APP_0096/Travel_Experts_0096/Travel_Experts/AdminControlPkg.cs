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
    //Search, view and export to excel/pdf all the packages
    //Lead Programmer: Mo Sagnia
    //Date: 11th February 2019
    public partial class AdminControlPkg : UserControl
    {
        //establish general query for packages
        string pkgQryAll = SQLforDataGrid.SqlQuery("Packages", "*", "PackageId");

        public AdminControlPkg()
        {
            InitializeComponent();
        }

        private void AdminControlPkg_Load(object sender, EventArgs e)
        {
            //select a default value for search option (combo box)
            cboSearch.SelectedIndex = 0;
            cboDate.SelectedIndex = 0;
            cboCurrency.SelectedIndex = 0;

            //set the source of the data to be displayed in the grid view
            packageGridView.DataSource = bindingSourcePackage;

            

            //get table for packages
            DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);

        }

        //button to allow user to search in the database based on their search criteria
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cboSearch.SelectedItem.ToString())
            {
                case "All":
                    //validate input from user
                    if (!Validator.IsProvided(txtSearch, lblEmpty)) { }
                    else
                    {
                        DataGridDB.GetDGData("SELECT * from Packages where lower(CONCAT(PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission)) like '%" + txtSearch.Text.ToLower() + "%'", packageGridView, bindingSourcePackage);

                        //if there are is no match to the database:
                        if (packageGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Unable to find a match");
                            DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
                        }
                    }
                    break;

                case "Id":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsNonZeroPositiveInt(txtSearch, lblId)) { }
                    else
                    {
                        DataGridDB.GetDGData("SELECT * from Packages where lower(PackageId) like '%" + txtSearch.Text + "%'", packageGridView, bindingSourcePackage);
                        //if there are is no match to the database:
                        if (packageGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Unable to find a match");
                            DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
                        }
                    }
                    break;

                case "Name":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsString(txtSearch, lblName)) { }
                    else
                    {
                        DataGridDB.GetDGData("SELECT * from Packages where lower(PkgName) like '%" + txtSearch.Text + "%'", packageGridView, bindingSourcePackage);

                        //if there are is no match to the database:
                        if (packageGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Unable to find a match");
                            DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
                        }
                    }
                    break;

                case "Start Date":
                case "End Date":
                    string tableDate;
                    if (cboSearch.SelectedItem.ToString() == "Start Date")
                    {
                        tableDate = "PkgStartDate";
                    }
                    else { tableDate = "PkgEndDate"; }
                    switch (cboDate.SelectedItem.ToString())
                    {
                        case "Before:":
                            var sqlBefore = String.Format("SELECT * from Packages where {0} <= '{1}'", tableDate, dateTimePickerPkg.Value.Date);
                            DataGridDB.GetDGData(sqlBefore, packageGridView, bindingSourcePackage);
                            //if there are is no match to the database:
                            if (packageGridView.Rows.Count == 0)
                            {
                                MessageBox.Show("Unable to find a match");
                                DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
                            }
                            break;
                        case "After:":
                            var sqlAfter = String.Format("SELECT * from Packages where {0} >= '{1}'", tableDate, dateTimePickerPkg.Value.Date);
                            DataGridDB.GetDGData(sqlAfter, packageGridView, bindingSourcePackage);
                            //if there are is no match to the database:
                            if (packageGridView.Rows.Count == 0)
                            {
                                MessageBox.Show("Unable to find a match");
                                DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
                            }
                            break;
                        case "Exactly on:":
                            var sqlExact = String.Format("SELECT * from Packages where {0} = '{1}'", tableDate, dateTimePickerPkg.Value.Date);
                            DataGridDB.GetDGData(sqlExact, packageGridView, bindingSourcePackage);
                            //if there are is no match to the database:
                            if (packageGridView.Rows.Count == 0)
                            {
                                MessageBox.Show("Unable to find a match");
                                DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
                            }
                            break;
                    }
                    break;

                case "Base Price":
                case "Commission":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsNonNegativeDecimal(txtSearch, lblCurrency)) { }
                    else
                    {
                        string tableCurrency;
                        if (cboSearch.SelectedItem.ToString() == "Base Price")
                        {
                            tableCurrency = "PkgBasePrice";
                        }
                        else { tableCurrency = "PkgAgencyCommission"; }
                        switch (cboCurrency.SelectedItem.ToString())
                        {
                            case "Above:":
                                var sqlAbove = String.Format("SELECT * from Packages where {0} >= '{1}'", tableCurrency, Convert.ToDecimal(txtSearch.Text));
                                DataGridDB.GetDGData(sqlAbove, packageGridView, bindingSourcePackage);
                                //if there are is no match to the database:
                                if (packageGridView.Rows.Count == 1)
                                {
                                    MessageBox.Show("Unable to find a match");
                                    DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
                                }
                                break;

                            case "Below:":
                                var sqlBelow = String.Format("SELECT * from Packages where {0} <= '{1}'", tableCurrency, Convert.ToDecimal(txtSearch.Text));
                                DataGridDB.GetDGData(sqlBelow, packageGridView, bindingSourcePackage);
                                //if there are is no match to the database:
                                if (packageGridView.Rows.Count == 0)
                                {
                                    MessageBox.Show("Unable to find a match");
                                    DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
                                }
                                break;

                            case "Exactly:":
                                var sqlExact = String.Format("SELECT * from Packages where {0} = '{1}'", tableCurrency, Convert.ToDecimal(txtSearch.Text));
                                DataGridDB.GetDGData(sqlExact, packageGridView, bindingSourcePackage);
                                //if there are is no match to the database:
                                if (packageGridView.Rows.Count == 0)
                                {
                                    MessageBox.Show("Unable to find a match");
                                    DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
                                }
                                break;
                        }
                    }
                    break;
            }
        }

        //change visibility of text fields and labels based on user choice
        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCurrency.Visible = false;
            lblEmpty.Visible = false;
            lblId.Visible = false;
            lblName.Visible = false;
            txtSearch.BackColor = Color.White;

            if (cboSearch.SelectedItem.ToString() == "All" ||
                cboSearch.SelectedItem.ToString() == "Id" ||
                cboSearch.SelectedItem.ToString() == "Name")
            {
                cboDate.Visible = false;
                cboCurrency.Visible = false;
                dateTimePickerPkg.Visible = false;
                lblSearch.Visible = true;
                txtSearch.Visible = true;
            }
            else if (cboSearch.SelectedItem.ToString() == "Start Date" ||
                     cboSearch.SelectedItem.ToString() == "End Date")
            {
                cboDate.Visible = true;
                cboCurrency.Visible = false;
                dateTimePickerPkg.Visible = true;
                lblSearch.Visible = false;
                txtSearch.Visible = false;
            }
            else
            {
                cboDate.Visible = false;
                cboCurrency.Visible = true;
                dateTimePickerPkg.Visible = false;
                lblSearch.Visible = false;
                txtSearch.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset default value for search option (combo box)
            cboSearch.SelectedIndex = 0;
            cboDate.SelectedIndex = 0;
            cboCurrency.SelectedIndex = 0;
            
            //reset default visibility for text field and label
            cboDate.Visible = false;
            cboCurrency.Visible = false;
            dateTimePickerPkg.Visible = false;
            lblSearch.Visible = true;
            txtSearch.Visible = true;

            //visible false error messages if any
            lblCurrency.Visible = false;
            lblEmpty.Visible = false;
            lblId.Visible = false;
            lblName.Visible = false;

            //clear text fields and background color
            txtSearch.Text = "";
            txtSearch.BackColor = Color.White;

            //focus on search text field
            txtSearch.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //get table for packages
            DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    DataGridDB.SaveDGData(bindingSourcePackage);
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    DataGridDB.DeleteDGData("Packages", "PackageId", packageGridView);
        //    DataGridDB.GetDGData(pkgQryAll, packageGridView, bindingSourcePackage);
        //}

        private void pctExcel_Click(object sender, EventArgs e)
        {
            Exportto.Excel(packageGridView, "Package Information", saveExcelFile);
        }

        private void pctPdf_Click(object sender, EventArgs e)
        {
            Exportto.Pdf(packageGridView, "Package Information", savePDFFile);
        }
    }
}
