using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class NEET : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubject_Click(object sender, EventArgs e)
        {
            try
            {
                // Determine the clicked button and redirect to the corresponding subject page
                Button clickedButton = (Button)sender;

                switch (clickedButton.ID)
                {
                    case "btnBiology":
                        Response.Redirect("BiologyAdvanceQuestions.aspx");
                        break;
                    case "btnChemistry":
                        Response.Redirect("ChemistryAdvanceQuestions.aspx");
                        break;
                    case "btnPhysics":
                        Response.Redirect("PhysicsAdvanceQuestions.aspx");
                        break;
                    default:
                        // Handle unexpected button click
                        break;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = $"An error occurred: {ex.Message}";
            }
        }
    }
}
