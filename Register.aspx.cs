using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string role = ddlUserRole.SelectedValue; // Get selected role

            if (password == confirmPassword)
            {
                DatabaseHelper.CreateUser(username, password, role);
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblErrorMessage.Text = "Password mismatch. Please make sure your passwords match.";
            }
        }

    }
}