using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Model;
using Query;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Query.ProductsDB;
using static Query.Product_SuppliersDB;

namespace Travel_Experts
{

    // CREATE A CLASS FOR PRODUCT CRUD CONTROL 
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }
        // LOAD
        private void ProductControl_Load(object sender, EventArgs e)
        {
            HideAll();
            repopulate();
        }

// POPULATE
        private void repopulate()
        {
            List<Products> newProductList = ProductsDB.GetProducts();
            List<Suppliers> newSuppliersList = SuppliersDB.GetSuppliers();
//LIST BOX
            cbProdName.ValueMember = "ProductId";
            cbProdName.DisplayMember = "ProductName";
            cbProdName.DataSource = newProductList;

// NEW SUPPLIER LIST BOX
            cbNewSup.ValueMember = "SupplierId";
            cbNewSup.DisplayMember = "SupName";
            cbNewSup.DataSource = newSuppliersList;
            ClearAll();
        }
// BUBMIT
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            List<Products> productList = ProductsDB.GetProducts();

            List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();

            var checkedButton = gbOptions.Controls.OfType<RadioButton>()
                                .FirstOrDefault(r => r.Checked);

                switch (checkedButton.Name)
            {// VALIDATOR
                case "rbAdd":
                    try
                    {
                        if (Validator1.IsProvided_Combo(cbSupplier, "Old Supplier Name") &&
                            Validator1.IsProvided(txtProdName, "New Product Name"))
                        {
                            Products prod = new Products(txtProdName.Text);
                            DialogResult result = MessageBox.Show("Add " + prod.ProductName + "?",
                            "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                              
                                int insertedId = ProductsDB.InsertProduct(prod);
                                Suppliers sup = SuppliersDB.GetSuppliers(Convert.ToInt32(cbSupplier.SelectedValue));
                                Products_Suppliers pS = new Products_Suppliers(insertedId, sup.SupplierId);
                                Product_SuppliersDB.Insert(pS);
                                MessageBox.Show(prod.ProductName + " Added Successfully");//
                            }
                            else
                            {
                                txtProdName.Focus();
                            }
                        }

                    }
                    catch (Query.ProductsDB.DuplicateKeyException ex)
                    {
                        MessageBox.Show("Product ID already exist, try another ID");//
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                    break;

                case "rbUpdate":
                    try
                    {
                        // VALIDATOR
                        if (Validator1.IsProvided_Combo(cbSupplier, "Old Supplier Name") &&
                            Validator1.IsProvided(txtProdName, "New Product Name") &&
                            Validator1.IsProvided_Combo(cbProdName, "Product Name") &&
                            Validator1.IsProvided_Combo(cbNewSup, "New Supplier"))
                        {
                            Products newProd = new Products(txtProdName.Text);

                            var oldProd = (from x in productList where x.ProductName == cbProdName.Text select x).First();

                            
                            DialogResult result = MessageBox.Show("Update " + oldProd.ProductName + "?",
                            "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                bool updateP = ProductsDB.UpdateProduct(oldProd, newProd);
                                MessageBox.Show(oldProd.ProductName + " Updated Successfully");

                                Suppliers oldSup = SuppliersDB.GetSuppliers(Convert.ToInt32(cbSupplier.SelectedValue));
                                Suppliers newSup = SuppliersDB.GetSuppliers(Convert.ToInt32(cbNewSup.SelectedValue));

                                Products_Suppliers oldPs = new Products_Suppliers(oldProd.ProductId, oldSup.SupplierId);
                                Products_Suppliers newPs = new Products_Suppliers(oldProd.ProductId, newSup.SupplierId);


                                bool updatePS = Product_SuppliersDB.Update(oldPs, newPs);
                            }
                            else
                            {
                                cbProdName.Focus();
                            }
                        }
                    }
                    catch (Query.ProductsDB.DuplicateKeyException ex)
                    {
                        MessageBox.Show("Supplier ID already exist, try another ID");
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                    break;

                case "rbDelete": // VALIDATOR
                    try
                    {
                        if (Validator1.IsProvided_Combo(cbProdName, "Product Name"))
                        {
                            Products prd = ProductsDB.GetProducts(Convert.ToInt32(cbProdName.SelectedValue));

                            List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();

                            foreach (Products_Suppliers item in psList)
                            {
                                if (item.ProductId == prd.ProductId)
                                {
                                    Product_SuppliersDB.Delete(prd.ProductId);
                                }
                            }
                             
                            DialogResult result = MessageBox.Show("Delete Product: " + prd.ProductName + "?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Products delProd = new Products(cbProdName.Text);

                                bool delete = ProductsDB.DeleteProduct(delProd);

                                MessageBox.Show(prd.ProductName + " Deleted Successfully");
                            }
                            cbProdName.Focus();
                        }
                    }
                    catch (Query.ProductsDB.DuplicateKeyException ex)
                    {
                        MessageBox.Show("Supplier ID already exist, try another ID");
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                    catch (ForiegnKeyException ex)
                    {
                        MessageBox.Show("This product, is part of active packages. Please delete the packages first.");
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                    break;
            }
            repopulate();
        }

        private void cbProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProdName.SelectedIndex != -1)
            {
                Products prd = ProductsDB.GetProducts(Convert.ToInt32(cbProdName.SelectedValue));
                txtProdName.Text = prd.ProductName.ToString();

                if (rbUpdate.Checked)
                {
                    lblSupName.Text = "Old Supplier: ";
                    // CLEAR
                    cbSupplier.DataSource = null;
                    cbSupplier.Items.Clear();
                  
                    List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();
                    List<Products> productList = ProductsDB.GetProducts();
                    List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();
                    List<Suppliers> addList = new List<Suppliers>();
                    var oldSup = from s in suppliersList
                                 join ps in psList on s.SupplierId equals ps.SupplierId
                                 join p in productList on ps.ProductId equals p.ProductId
                                 where p.ProductId == Convert.ToInt32(cbProdName.SelectedValue)
                                 select new { s.SupName, s.SupplierId };

                    foreach (var item in oldSup)
                    {
                        Suppliers s = new Suppliers(Convert.ToInt32(item.SupplierId), Convert.ToString(item.SupName));
                        addList.Add(s);
                    }

// SUPPLIER LIST BOX
                    cbSupplier.ValueMember = "SupplierId";
                    cbSupplier.DisplayMember = "SupName";
                    cbSupplier.DataSource = addList;
                }
                else 
                {
                    lblSupName.Text = "Supplier: ";
                    cbSupplier.DataSource = null;
                    cbSupplier.Items.Clear();
                    List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();
                    cbSupplier.ValueMember = "SupplierId";
                    cbSupplier.DisplayMember = "SupName";
                    cbSupplier.DataSource = suppliersList;
                }
            }
        }
        // ADD
        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            // DEFAULT SET UP
            lblPnameTxt.Visible = true;
            lblSupName.Visible = true;
            txtProdName.Visible = true;
            cbSupplier.Visible = true;
            lblSupName.Text = "Supplier Name: ";
            btnSubmit.Visible = true;
            //btnProdClear.Visible = true;
            // Remove Contents
            txtProdName.Text = null;
            ClearAll();
        }
        // CHANGE
        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            lblSupName.Text = "Old Supplier Name: ";
            lblPnameCb.Visible = true;
            lblPnameTxt.Visible = true;
            lblSupName.Visible = true;
            lblNewSup.Visible = true;
            txtProdName.Visible = true;
            cbProdName.Visible = true;
            cbSupplier.Visible = true;
            cbNewSup.Visible = true;
            btnSubmit.Visible = true;
            //btnProdClear.Visible = true;
            // Remove Contents
            ClearAll();
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            lblPnameCb.Visible = true;
            cbProdName.Visible = true;
            btnSubmit.Visible = true;
            //btnProdClear.Visible = true;
            // Remove Contents
            ClearAll();
        }

        private void ClearAll()
        {
            // Clear 
            cbProdName.ResetText();
            cbSupplier.ResetText();
            cbNewSup.ResetText();
            cbProdName.SelectedIndex = -1;
            cbSupplier.SelectedIndex = -1;
            cbNewSup.SelectedIndex = -1;
            txtProdName.Text = null;
        }
        // HIDE
        private void HideAll()
        {
            // Alter visibility
            btnSubmit.Visible = false;
            //btnProdClear.Visible = false;
            lblSupName.Visible = false;
            lblPnameTxt.Visible = false;
            lblSupName.Visible = false;
            lblPnameCb.Visible = false;
            lblNewSup.Visible = false;
            txtProdName.Visible = false;
            cbProdName.Visible = false;
            cbSupplier.Visible = false;
            cbNewSup.Visible = false;
        }

        //private void lblStatus_Click(object sender, EventArgs e)
        //{

        //}
    }
}
