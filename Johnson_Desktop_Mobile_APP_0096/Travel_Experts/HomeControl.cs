using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;
using Query;

namespace Travel_Experts
{
        // Create Home Control for login 
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        //Instantiate login object with the correct login information (placeholder)

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ErrorProvider.ValidProvided(txtAgentID, "AgentID", errorProvider1)&& 
                ErrorProvider.ValidProvided(txtUname, "User Name", errorProvider1) && 
                ErrorProvider.ValidProvided(txtPword, "Password", errorProvider1) && 
                (txtAgentID.Text == "1"||txtAgentID.Text == "2")) // set JoshID and WeiID as 1 and 2 respectively
            {
                try
                {
                    Login.Login agent = new Login.Login(Convert.ToInt32(txtAgentID.Text), Convert.ToString(txtUname.Text), Convert.ToString(txtPword.Text));

                    LoginDB loginDB = new LoginDB();

                    string hashedPassword = loginDB.GetAgentHashedPasswordById(agent.AgentID);

                    bool validPassword = BCrypt.Net.BCrypt.Verify(agent.AgentPassword, hashedPassword); 

                    Console.WriteLine(validPassword);

                    if (validPassword == true)
                    {
                        MessageBox.Show("You have successfully log in as an Agent. ");

                        label1.Visible = true; 
                       // gbLogin.Visible = false; 
                        gbLogin.Visible = true; 
                        // go to main form to see control bar
                        Form_Main mainForm = (Form_Main)this.Parent; 
                        // agent navigation not inlcuing admin button
                        mainForm.AgentNavigation(true); 
                    }
                    else
                    {
                        MessageBox.Show("Log in not successful, please try again", "Login Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // FOR ADMIN LOGIN ONLY
            }
            else if (ErrorProvider.ValidProvided(txtAgentID, "AgentID", errorProvider1) &&
                ErrorProvider.ValidProvided(txtUname, "User Name", errorProvider1) &&
                ErrorProvider.ValidProvided(txtPword, "Password", errorProvider1) &&
                (txtAgentID.Text == "9999"||txtAgentID.Text == "7"))
            {
                try 
                {
                    Login.AdminLogin Admin = new Login.AdminLogin(Convert.ToInt32(txtAgentID.Text), Convert.ToString(txtUname.Text), Convert.ToString(txtPword.Text));

                    AdminLoginDB AdminloginDB = new AdminLoginDB();

                    string hashedPassword = AdminloginDB.GetAdminAgentHashedPasswordById(Admin.AdminID);

                    bool validPassword = BCrypt.Net.BCrypt.Verify(Admin.AdminPassword, hashedPassword);
                    if (validPassword == true)
                    {
                        MessageBox.Show(" You have logged in as an Administrator. ");

                        label1.Visible = true; 

                        gbLogin.Visible = false; 

                        Form_Main mainForm = (Form_Main)this.Parent; 
                        mainForm.Navigation(true); 
                    }
                    else
                    {
                        MessageBox.Show("Log in not successful, please check input and try again", "Login Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Log in not successful.", "Login Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        // show login section when load from
        private void HomeControl_Load(object sender, EventArgs e)
        {
            gbLogin.BringToFront();
        }
        // clear input and focus on first one
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAgentID.Text = "";
            txtUname.Text = "";
            txtPword.Text = "";
            txtAgentID.Focus();
        }

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void gbLogin_Enter(object sender, EventArgs e)
        //{

        //}

        //private void txtAgentID_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void lblAgent_Click(object sender, EventArgs e)
        //{

        //}

        //private void txtPword_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtUname_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
