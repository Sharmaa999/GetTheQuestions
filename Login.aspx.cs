using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Replace "UserS" with the actual role name for regular users
            if (DatabaseHelper.ValidateUser(username, password, "User"))
            {
                // Redirect regular users to the next page
                Response.Redirect("SelectClassStream.aspx");
            }
            else if (DatabaseHelper.ValidateUser(username, password, "Admin"))
            {
                // Redirect administrators to the admin page
                Response.Redirect("Admin.aspx");
            }
            else
            {
                lblErrorMessage.Text = "Invalid login credentials. Please try again.";
            }
        }
    }
}
