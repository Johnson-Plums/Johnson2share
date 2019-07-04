using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
    // CREATE INPUT ERROR HANDLER
    // not empty
    public static class ErrorProvider
    {
        public static bool ValidProvided(TextBox tb, string name, System.Windows.Forms.ErrorProvider er)
        {
            er.Clear();
            if (tb.Text == string.Empty)
            {
                er.SetError(tb, name + " is missing");
                return false;
            }

            return true;
        }
        // integer
        public static bool ValidInt(TextBox tb, string name, System.Windows.Forms.ErrorProvider er)
        {
            er.Clear();
            try
            {
                int i = Convert.ToInt32(tb.Text);
            }
            catch
            {
                er.Clear();
                er.SetError(tb,  name + " must be an integer");
                return false;
            }

            return true;
        }
        // double
        public static bool ValidDouble(TextBox tb, string name, System.Windows.Forms.ErrorProvider er)
        {
            er.Clear();
            try
            {
                double i = Convert.ToDouble(tb.Text);
            }
            catch
            {
                er.Clear();
                er.SetError(tb, name + " must be a numeric decimal value");
                return false;
            }
            return true;
        }
    }
}
