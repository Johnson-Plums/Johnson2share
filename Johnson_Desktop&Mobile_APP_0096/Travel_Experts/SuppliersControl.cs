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
using static Query.SuppliersDB;

namespace Travel_Experts
{
    // CREATE A SUPPLIER CLASS
    public partial class SuppliersControl : UserControl
    {
   // MANUAL ID ADDED
        public SuppliersControl()
        {
            InitializeComponent();
        }
        // POPULATE
        private void repopulate()
        {
            List<Suppliers> newSuppliersList = SuppliersDB.GetSuppliers();
            cbSupName.ValueMember = "SupplierId";
            cbSupName.DisplayMember = "SupName";
            cbSupName.DataSource = newSuppliersList;
            // Remove Contents
            txtSupId.Text = null;
            txtSupName.Text = null;
            cbSupName.SelectedIndex = -1;
        }

        private void SuppliersControl_Load(object sender, EventArgs e)
        {
            // DEFAULT SET UP
            cbSupName.Visible = false;
            txtSupName.Visible = false;
            txtSupId.Visible = false;
            rbAdd.Checked = true;
            lblSupId.Visible = false;
            lblSupName.Visible = false;
            lblSupNameDD.Visible = false;
            btnApply.Visible = false;
            btnApply.Text = "Add";
            btnApply.Visible = true;
            btnApply.Enabled = true;
            repopulate();
            // CLEAR
            txtSupId.Text = null;
            txtSupName.Text = null;
            cbSupName.SelectedIndex = -1;
        }
        // BOMBOBOX SELECTION
        private void supNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSupName.Visible = true;
            lblSupId.Visible = true;
            txtSupId.Visible = true;
            txtSupName.Visible = true;
            if (cbSupName.SelectedIndex != -1)
            {
                Suppliers sup = SuppliersDB.GetSuppliers(Convert.ToInt32(cbSupName.SelectedValue));

                txtSupName.Text = sup.SupName;
                txtSupId.Text = sup.SupplierId.ToString();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var checkedButton = gbOptions.Controls.OfType<RadioButton>()
                                .FirstOrDefault(r => r.Checked);
            switch (checkedButton.Name)
            {
                case "rbAdd":
                    try
                    {
                        if (Validator1.IsProvided(txtSupName, "Supplier Name") &&
                            Validator1.IsProvided(txtSupId, "Supplier ID")) 
                        {
                            Suppliers sup = new Suppliers(Convert.ToInt32(txtSupId.Text), txtSupName.Text);
                            DialogResult result = MessageBox.Show("Add " + sup.SupName + "?",
                            "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                bool insert = SuppliersDB.Insert(sup);
                                MessageBox.Show(sup.SupName + " Added Successfully");
                            }
                            else
                            {
                                txtSupName.Focus();
                            }
                        }
                    }
                    catch (DuplicateKeyException ex)
                    {
                        MessageBox.Show("Supplier ID already exist, try another ID"); 
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                    break;

                case "rbUpdate":
// VALIDATOR
                    try
                    {
                        if (Validator1.IsProvided(txtSupName, "Supplier Name") &&
                        Validator1.IsProvided(txtSupId, "Suppier ID"))
                        {
                            Suppliers sup = new Suppliers(Convert.ToInt32(txtSupId.Text), txtSupName.Text);
                            DialogResult result = MessageBox.Show("Update " + sup.SupName + "?",
                            "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Suppliers newSup = new Suppliers(Convert.ToInt32(txtSupId.Text), txtSupName.Text);
                                Suppliers oldSup = SuppliersDB.GetSuppliers(Convert.ToInt32(cbSupName.SelectedValue));

                                bool update = SuppliersDB.Update(oldSup, newSup);
                                MessageBox.Show(sup.SupName + " Updated Successfully");
                            }
                            else
                            {
                                txtSupName.Focus();
                            }

                        }
                    }
                    catch (DuplicateKeyException ex)
                    {
                        MessageBox.Show("Supplier ID already exist, try another ID");
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                    break;

                case "rbDelete":
// DELETE 
//VALIDATOR
                    try
                    {
                        if (Validator1.IsProvided(txtSupName, "Supplier Name"))
                        {
                            Suppliers delSup = new Suppliers(Convert.ToInt32(txtSupId.Text), txtSupName.Text);
                            DialogResult result = MessageBox.Show("Delete " + delSup.SupName + "?",
                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                bool delete = SuppliersDB.Delete(delSup);
                                MessageBox.Show(delSup.SupName + " Deleted Successfully");
                            }
                            else
                            {
                                cbSupName.SelectAll();
                            }
                        }
                    }
                    catch (ForiegnKeyException ex)
                    {
                        MessageBox.Show("This supplier has products, cannot delete.");
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                    catch (Exception ex)
                    {
                        ex.Message.GetType();
                    }
                    // CLEAR
                    txtSupId.Text = null;
                    txtSupName.Text = null;
                    cbSupName.SelectedIndex = -1;
                    break;
            }
            repopulate();
            btnApply.Enabled = true;
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
// DEFAULT SET UP
            repopulate();
            lblSupNameDD.Visible = true;
            cbSupName.Visible = true;
            txtSupId.Visible = false;
            txtSupName.Visible = false;
            txtSupId.Enabled = true;
            txtSupName.Enabled = true;
            lblSupId.Visible = false;
            lblSupName.Visible = false;
            // CLEAR
            txtSupId.Text = null;
            txtSupName.Text = null;
            cbSupName.SelectedIndex = -1;
            // SELECT UPDATE
            btnApply.Text = "Update";
            btnApply.Visible = true;
            btnApply.Enabled = true;
        }
        // DELETE
        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            // DEFAULT SET UP
            repopulate();
            lblSupNameDD.Visible = true;
            cbSupName.Visible = true;
            txtSupId.Visible = false;
            txtSupName.Visible = false;
            txtSupId.Enabled = false;
            txtSupName.Enabled = false;
            lblSupId.Visible = false;
            lblSupName.Visible = false;
            // CLEAR
            txtSupId.Text = null;
            txtSupName.Text = null;
            cbSupName.SelectedIndex = -1;
            // SELECT DELETE
            btnApply.Text = "Delete";
            btnApply.Visible = true;
            btnApply.Enabled = true;
        }
        // ADD
        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            // DEAFULT
            repopulate();
            lblSupName.Visible = true;
            lblSupId.Visible = true;
            txtSupId.Enabled = true;
            txtSupName.Enabled = true;
            txtSupName.Visible = true;
            txtSupId.Visible = true;
            cbSupName.Visible = false;
            lblSupNameDD.Visible = false;
            // CLEAR
            txtSupId.Text = null;
            txtSupName.Text = null;
            cbSupName.SelectedIndex = -1;
            // SELECT ADD
            btnApply.Text = "Add";
            btnApply.Visible = true;
            btnApply.Enabled = true;

        }

    }
}
