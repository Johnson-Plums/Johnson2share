using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
// CREATE A FORM TEXTBOX VALIDATOR
    public static class Validator1
    {
        // NOT EMPTY
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true; 
            if(tb.Text == "")
            {
                result = false;
                MessageBox.Show(name + " is required", "Data entry error");
                tb.Focus();
            }
            return result;
        }
        // TEXT BOX
        public static bool IsProvided1(TextBox tb)
        {
            bool result = true; 
            if (tb.Text == "")
            {
                result = false;
                MessageBox.Show(tb.Tag + " is required", "Data entry error");
                tb.Focus();
            }
            return result;
        }
        // COMBO BOX
        public static bool IsProvided_Combo(ComboBox tb, string name)
        {
            bool result = true; // "innocent until proven guilty"
            if (tb.Text == "")//empty text box
            {
                result = false;
                MessageBox.Show(name + " is required", "Data entry error");
                tb.Focus();
            }
            return result;
        }
        // RICH TEXT BOX
        public static bool IsProvided(RichTextBox tb, string name)
        {
            bool result = true; 
            if (tb.Text == "")
            {
                result = false;
                MessageBox.Show(name + " is required", "Data entry error");
                tb.Focus();
            }
            return result;
        }
       // TEXT BOX POSITIVE INTEGER
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool result = true;
            int num; 
            if(!Int32.TryParse(tb.Text, out num)) 
            {
                result = false;
                MessageBox.Show(name + " has to be a whole number, between 0 and 2147483647", "Data entry error");
                tb.SelectAll(); 
                tb.Focus();
            }
            else // none negative
            {
                if(num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); 
                    tb.Focus();
                }
            }
            return result;
        }
        //text box, positive double
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool result = true;
            double num;
            if (!Double.TryParse(tb.Text, out num)) 
            {
                result = false;
                MessageBox.Show(name + " has to be an a flooating", "Data entry error");
                tb.SelectAll(); 
                tb.Focus();
            }
            else 
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); 
                    tb.Focus();
                }
            }
            return result;
        }
        // text box positive decimal
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool result = true;
            decimal num;
            if (!Decimal.TryParse(tb.Text, out num)) 
            {
                result = false;
                MessageBox.Show(name + " has to be an a flooating", "Data entry error");
                tb.SelectAll(); 
                tb.Focus();
            }
            else // non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); 
                    tb.Focus();
                }
            }
            return result;
        }
    }
}

