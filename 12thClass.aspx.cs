using System;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication7
{
    public partial class _12thClass : System.Web.UI.Page
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
                        Response.Redirect("BiologyQuestions.aspx");
                        break;
                    case "btnChemistry":
                        Response.Redirect("ChemistryQuestions.aspx");
                        break;
                    case "btnPhysics":
                        Response.Redirect("PhysicsQuestions.aspx");
                        break;
                    case "btnIT":
                        Response.Redirect("ITQuestions.aspx");
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