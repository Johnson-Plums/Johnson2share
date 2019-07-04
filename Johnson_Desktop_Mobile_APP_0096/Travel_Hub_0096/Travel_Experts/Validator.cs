using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
    // CREATE A VALIDATAOR FOR INPUT DATA
    public static class Validator
    {
       // DATA MUST BE LESS THAN PICKED DATA
        public static bool IsDate(DateTimePicker dtPicker, Label lblName)
        {
            lblName.Visible = false;
            bool result = true;
            if (DateTime.Now.Date > dtPicker.Value.Date)
            {
                result = false;
                lblName.Visible = true;
                dtPicker.Focus();
            }
            return result;
        }
        //ERROR MESSAGE FORMAT
        private static void FormFormat(bool ValidationResult, TextBox txtBoxName, Label lblName)
        {
            if (ValidationResult)
            {
                lblName.Visible = false;
                txtBoxName.BackColor = Color.White;
            }
            else
            {
                lblName.Visible = true;
                txtBoxName.Focus();
                txtBoxName.BackColor = Color.Pink;
            }
        }

        //Email format
        public static bool IsEmail(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            if (!Regex.IsMatch(txtBoxName.Text, @"^[a-zA-Z][a-zA-Z0-9.!#$%&'*+\/=?^_`{-]+@([a-zA-Z][a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$"))
            {
                result = false;
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }
        //Phone Number format
        public static bool IsPhoneNo(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            if(!Regex.IsMatch(txtBoxName.Text, @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$"))
            {
                result = false;
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }
        // Postal Code format
        public static bool IsPostalCode(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            if (!Regex.IsMatch(txtBoxName.Text, @"^([A-Za-z]\d[A-Za-z][- ]?\d[A-Za-z]\d)+$"))
            {
                result = false;
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }
        // input box not empty
        public static bool IsProvided(TextBox txtBoxName, Label lblName)
        {
            bool result = true; 
            if(txtBoxName.Text == "") 
            {
                result = false;
               MessageBox.Show(lblName + " is required", "Data entry error");
                txtBoxName.Focus();
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }
        // rich text box not empty
        public static bool IsProvided(RichTextBox richTxtBoxName, Label lblName)
        {
            bool result = true; 
            if (richTxtBoxName.Text == "") 
            {
                result = false;
                MessageBox.Show(lblName + " is required", "Data entry error");
                richTxtBoxName.Focus();
            }
            return result;
        }

        //input string not empty
        public static bool IsString(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            if(!Regex.IsMatch(txtBoxName.Text,"^[a-zA-Z -'.]+$"))
            {
                result = false;
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }

        //Integer
        public static bool IsNonNegativeInt(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            int num; 
            if(!Int32.TryParse(txtBoxName.Text, out num)) 
            {
                result = false;
                MessageBox.Show(lblName + " has to be a whole number", "Data entry error");
                txtBoxName.SelectAll(); 
                txtBoxName.Focus();
            }
            else //non-negative
            {
                if(num < 0)
                {
                    result = false;
                    MessageBox.Show(lblName + " needs to be positive or zero", "Data entry error");
                    txtBoxName.SelectAll(); 
                    txtBoxName.Focus();
                }
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }

        //none zero and positive integer
        public static bool IsNonZeroPositiveInt(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            int num; // parsed number
            if (!Int32.TryParse(txtBoxName.Text, out num)) // if not integer
            {
                result = false;
            }
            else // none negative
            {
                if (num <= 0)
                {
                    result = false;
                }
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }
            //none negative double
            public static bool IsNonNegativeDouble(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            double num; 
            if (!Double.TryParse(txtBoxName.Text, out num)) 
            {
                result = false;
                MessageBox.Show(lblName + " has to be a floating", "Data entry error");
                txtBoxName.SelectAll(); 
                txtBoxName.Focus();
            }
            else // not negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(lblName + " needs to be positive or zero", "Data entry error");
                    txtBoxName.SelectAll(); 
                    txtBoxName.Focus();
                }
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }
        // not negative Decimal
        public static bool IsNonNegativeDecimal(TextBox txtBoxName, Label lblName)
        {
            bool result = true;
            decimal num; 
            if (!Decimal.TryParse(txtBoxName.Text, out num)) 
            {
                result = false;
                MessageBox.Show(lblName + " has to be a floating", "Data entry error");
                txtBoxName.SelectAll();
                txtBoxName.Focus();
            }
            else // negative decimal
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(lblName + " needs to be positive or zero", "Data entry error");
                    txtBoxName.SelectAll(); 
                    txtBoxName.Focus();
                }
            }
            FormFormat(result, txtBoxName, lblName);
            return result;
        }
    }
}
