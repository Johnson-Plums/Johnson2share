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
    // CREATE A PAKAGES CONTROL CLASS
    public partial class PackagesControl : UserControl
    {
        public PackagesControl()
        {
            InitializeComponent();
        }
        // Initialize the form when load, set add to default
        private void PackagesControl_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtCommission.Enabled = false;
            dateStart.Enabled = false;
            dateEnd.Enabled = false;
            richTxtDescription.Enabled = false;
            lblId.Visible = false;
            radAdd.Checked = true;
        }

      //ADD
        private void AddPackageEvent()
        {
            try
            {
               if (Validator1.IsProvided1(txtName) &&
                    Validator1.IsProvided(txtPrice, "Base Price") &&
                    Validator1.IsNonNegativeDecimal(txtPrice, "Base Price") &&
                    Validator1.IsProvided(txtCommission, "Commission Amount") &&
                    Validator1.IsNonNegativeDecimal(txtCommission, "Commission Amount") &&
                    Validator1.IsProvided(richTxtDescription, "Package Description"))
                    {
                     Packages package = new Packages();

                     package.PkgName = txtName.Text;
                     package.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
                     package.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
                     package.PkgStartDate = Convert.ToDateTime(dateStart.Text);
                     package.PkgEndDate = Convert.ToDateTime(dateEnd.Text);
                     package.PkgDesc = richTxtDescription.Text;

                        if (package.PkgBasePrice > package.PkgAgencyCommission &&
                        package.PkgEndDate > package.PkgStartDate)
                            {
                                DialogResult result = MessageBox.Show("Add " + package.PkgName + "?",
                                 "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                   {
                                    int currentID = PackagesDB.AddPackage(package);
                                    foreach (Products_Suppliers addPS in psAddList)
                                    {
                                        int currentPSID = addPS.ProductSupplierId;
                                        Packages_Products_Suppliers ppsAdd = new Packages_Products_Suppliers                (currentID, currentPSID);
                                        Packages_Products_SuppliersDB.Insert(ppsAdd);
                                    }
                                    MessageBox.Show(package.PkgName + " added successfully");
                                }
                        }
                        // VALIDATION
                        else
                        {       
                                if (package.PkgBasePrice < package.PkgAgencyCommission)
                                {
                                    MessageBox.Show("Base Price must be greater than Commission Price");
                                    txtPrice.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("End Date must be later than Start Date");
                                    dateStart.Focus();
                                }
                        }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
        //UPDATE
        private void UpdatePackageEvent()
        {
            try
            {
                if (Validator1.IsProvided(txtName, "Package Name") &&
                    Validator1.IsProvided(txtPrice, "Base Price") &&
                    Validator1.IsNonNegativeDecimal(txtPrice, "Base Price") &&
                    Validator1.IsProvided(txtCommission, "Commission Amount") &&
                    Validator1.IsNonNegativeDecimal(txtCommission, "Commission Amount") &&
                    Validator1.IsProvided(richTxtDescription, "Package Description"))
                {
                    Packages package = PackagesDB.GetPackages(Convert.ToInt32(cbID.SelectedValue));
                    Packages newPackage = new Packages();
                    newPackage.PackageId = Convert.ToInt32(Convert.ToInt32(cbID.SelectedValue));
                    newPackage.PkgName = txtName.Text;
                    newPackage.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
                    newPackage.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
                    newPackage.PkgStartDate = Convert.ToDateTime(dateStart.Text);
                    newPackage.PkgEndDate = Convert.ToDateTime(dateEnd.Text);
                    newPackage.PkgDesc = richTxtDescription.Text;

                    if (newPackage.PkgBasePrice > newPackage.PkgAgencyCommission &&
                          newPackage.PkgEndDate > newPackage.PkgStartDate)
                    {
                        DialogResult result = MessageBox.Show("Update " + package.PkgName + "?",
                         "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            // Delete Packages_Products_Suppliers DATA BY currentPackageID
                            List<Packages_Products_Suppliers> currentPPS = Packages_Products_SuppliersDB.GetSuppliers();
                            foreach (Packages_Products_Suppliers pps in currentPPS)
                            {
                                if (pps.PackageId == package.PackageId)
                                {
                                    Packages_Products_SuppliersDB.Delete(pps);
                                }
                            }
                            foreach (Products_Suppliers ps in psAddList)
                            {
                                Packages_Products_Suppliers addPPS = new Packages_Products_Suppliers(package.PackageId, ps.ProductSupplierId);
                                Packages_Products_SuppliersDB.Insert(addPPS);
                            }

                            PackagesDB.UpdatePackage(package, newPackage);

                            MessageBox.Show(package.PkgName + " Updated successfully");
                            ClearControls();
                        }

                    }
                    else
                    {
                        // VALIDATOR
                        if (newPackage.PkgBasePrice < newPackage.PkgAgencyCommission)
                        {
                            MessageBox.Show("Base Price must be greater than Commission Price");
                            txtPrice.Focus();
                        }
                        else
                        {
                            MessageBox.Show("End Date must be later than Start Date");
                            dateStart.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                RepopulatePackages(cbID.SelectedIndex);
            }
        }

//DELETE
        private void DeletePackageEvent()
        {
            //Sans validation
            try
            {
                Packages package = PackagesDB.GetPackages(Convert.ToInt32(cbID.SelectedValue));
                List<Packages_Products_Suppliers> currentPPS = Packages_Products_SuppliersDB.GetSuppliers();
                foreach (Packages_Products_Suppliers pps in currentPPS)
                {
                    if (pps.PackageId == package.PackageId)
                    {
                        Packages_Products_SuppliersDB.Delete(pps);
                    }
                }
                DialogResult result = MessageBox.Show("Delete " + package.PkgName + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PackagesDB.DeletePackage(package);
                    MessageBox.Show(package.PkgName + " deleted successfully");
                }
                else
                {
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            finally
            {
                RepopulatePackages(cbID.SelectedIndex);
            }
        }
        //SUBMIT BUTTON EVENTS
        private void btnSubmit_Click(object sender, EventArgs e)
        {
                if (radAdd.Checked == true)
            {
                AddPackageEvent();
            }
            else if (radUpdate.Checked == true)
            {
                UpdatePackageEvent();
            }
            else
            {
                DeletePackageEvent();
            }
        }

// GET CURRENT PACKAGES DETAILS
        private void CurrentPackageDetails()
        {
            Packages package = PackagesDB.GetPackages(Convert.ToInt32(cbID.SelectedValue));
            List<Products> productsList = ProductsDB.GetProducts();
            List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();
            List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();
            List<Packages_Products_Suppliers> ppsList = Packages_Products_SuppliersDB.GetSuppliers();
// GET CURRENT INFOR
            var psDetails = from pps in ppsList
                           join ps in psList on pps.ProductSupplierId equals ps.ProductSupplierId
                           join product in productsList on ps.ProductId equals product.ProductId
                           join supplier in suppliersList on ps.SupplierId equals supplier.SupplierId
                           where pps.PackageId == package.PackageId // The current package ID
                           select new {pps.PackageId, ps.ProductSupplierId, product.ProductId, product.ProductName, supplier.SupName, supplier.SupplierId };

// ADD INTO LIST
            foreach (var ps in psDetails)
            {
                lbAdded.Items.Add(ps.ProductName.ToString() + " , " + ps.SupName.ToString());
                Products_Suppliers newPS = new Products_Suppliers(Convert.ToInt32(ps.ProductSupplierId), Convert.ToInt32(ps.ProductId), Convert.ToInt32(ps.SupplierId));
                psAddList.Add(newPS);
            }
        }

// PRODUCT SELECT
        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Products> productsList = ProductsDB.GetProducts();
            List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();
            List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();

            int selected = Convert.ToInt32(cbProduct.SelectedValue);

// GET SUPPLIERS
            var prodSuppliers = from ps in psList
                            join product in productsList on ps.ProductId equals product.ProductId
                            join supplier in suppliersList on ps.SupplierId equals supplier.SupplierId
                            where product.ProductId == selected
                            select new { product.ProductId, supplier.SupName, supplier.SupplierId };

            List<Products_Suppliers> psSelectionList = new List<Products_Suppliers>();

            foreach (var ps in prodSuppliers)
            {
                Products_Suppliers newPS = new Products_Suppliers(Convert.ToInt32(ps.ProductId), Convert.ToInt32(ps.SupplierId));
                psSelectionList.Add(newPS);
            }

            lbPS.DataSource = null;
            lbPS.Items.Clear();

// SHOW SUPPLIER INFOR
            lbPS.ValueMember = "SupplierId";
            lbPS.DisplayMember = "SupName";
            lbPS.DataSource = prodSuppliers.ToList();
        }
      // LIST CURRENT PRODUCT SUPPLIERS FOR SELECTED PRODUCTS. ADD, UPDATE, DELETE FUNCTIONS
        List<Products_Suppliers> psAddList = new List<Products_Suppliers>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();

            int selectedPID = Convert.ToInt32(cbProduct.SelectedValue);

            int selectedSupID = Convert.ToInt32(lbPS.SelectedValue);

            var current = from ps in psList where ps.ProductId == Convert.ToInt32(cbProduct.SelectedValue) && ps.SupplierId == Convert.ToInt32(lbPS.SelectedValue) select ps;
            //ADD TO LIST
            lbAdded.Items.Add(cbProduct.Text + " , " + lbPS.Text);

            foreach (var item in current)
            {
                Products_Suppliers psAdd = new Products_Suppliers(Convert.ToInt32(item.ProductSupplierId), Convert.ToInt32(item.ProductId), Convert.ToInt32(item.SupplierId));
                psAddList.Add(psAdd);
            }
        }

  //REMOVE AFTER ADDED
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selected = lbAdded.GetItemText(lbAdded.SelectedItem);

            string[] tokens = selected.Split(',');

            string product = tokens[0].Trim();
            string supplier = tokens[1].Trim();

            List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();
            List<Products> productsList = ProductsDB.GetProducts();
            List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();

            var search = from ps in psList
                           join prod in productsList on ps.ProductId equals prod.ProductId
                           join sup in suppliersList on ps.SupplierId equals sup.SupplierId
                           where prod.ProductName == product && sup.SupName == supplier
                           select new {ps.ProductSupplierId, prod.ProductId,  sup.SupplierId };

            // Remove from LIST
            foreach (var item in search)
            {
                Products_Suppliers psAdd = new Products_Suppliers(Convert.ToInt32(item.ProductSupplierId), Convert.ToInt32(item.ProductId), Convert.ToInt32(item.SupplierId));
                psAddList.RemoveAll(x => x.ProductSupplierId == psAdd.ProductSupplierId);
            }
            // Remove from LISTBOX
            lbAdded.Items.Remove(selected);
        }
     // SELECT NEW PKG
        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbID.SelectedIndex != -1)
            {
                // CLEAR
                psAddList.Clear();
                lbAdded.Items.Clear();
                DisplayPackages(Convert.ToInt32(cbID.SelectedValue));
                if (radUpdate.Checked != false)
                {
                    CurrentPackageDetails();
                }
            }
        }
// HANDLE RADIO OPTIONS
//ADD
        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            ClearControls();
            populateProductsDDL();
            psAddList.Clear();
// INITIALIZE SHOW INFO.
            gbPS.Visible = true;
            cbID.Visible = false;
            lblId.Visible = false;
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtCommission.Enabled = true;
            dateStart.Enabled = true;
            dateEnd.Enabled = true;
            richTxtDescription.Enabled = true;
        }
//UPDATE
        private void radUpdate_CheckedChanged(object sender, EventArgs e)
        {
            RepopulatePackages();
            populateProductsDDL();
            gbPS.Visible = true;
            cbID.Visible = true;
            lblId.Visible = true;
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtCommission.Enabled = true;
            dateStart.Enabled = true;
            dateEnd.Enabled = true;
            richTxtDescription.Enabled = true;
            lblId.Visible = true;
        }
// DELETE
        private void radDelete_CheckedChanged(object sender, EventArgs e)
        {
            RepopulatePackages();
            gbPS.Visible = false;
            cbID.Visible = true;
            lblId.Visible = true;
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtCommission.Enabled = false;
            dateStart.Enabled = false;
            dateEnd.Enabled = false;
            richTxtDescription.Enabled = false;
            lblId.Visible = true;
        }
// POPULATE INFO
        private void populateProductsDDL()
        {
            List<Products> productsList = ProductsDB.GetProducts();
            cbProduct.ValueMember = "ProductId";
            cbProduct.DisplayMember = "ProductName";
            cbProduct.DataSource = productsList;
        }
// DISPLAY CONTENT
        private void DisplayPackages(int pID)
        {
            Packages p = PackagesDB.GetPackages(pID);
            txtName.Text = p.PkgName;
            txtPrice.Text = p.PkgBasePrice.ToString();
            txtCommission.Text = p.PkgAgencyCommission.ToString();
            dateStart.Text = p.PkgStartDate.ToString();
            dateEnd.Text = p.PkgEndDate.ToString();
            richTxtDescription.Text = p.PkgDesc;
        }
// POPULATE PKG
        private void RepopulatePackages(int defaultSelection = -1)
        {
            cbID.SelectedIndex = defaultSelection;

            List<Packages> newPackagesList = PackagesDB.GetPackages();
            cbID.ValueMember = "PackageId";
            cbID.DisplayMember = "PkgName";
            cbID.DataSource = newPackagesList;
        }
// CLEAR
        private void ClearControls()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtCommission.Text = "";
            dateStart.Text = "";
            dateEnd.Text = "";
            richTxtDescription.Text = "";
        }
// LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form_Main mainForm = (Form_Main)this.Parent; //Access the parent form and enable the side navigation
            mainForm.Logout(true);
        }
    }
}
