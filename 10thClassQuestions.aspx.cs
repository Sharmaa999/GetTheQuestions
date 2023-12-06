using System;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class _10thClassQuestions : System.Web.UI.Page
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
                    case "btnGeometry":
                        Response.Redirect("GeometryQuestions.aspx");
                        break;
                    case "btnAlgebra":
                        Response.Redirect("AlgebraQuestions.aspx");
                        break;
                    case "btnScience1":
                        Response.Redirect("Science1Questions.aspx");
                        break;
                    case "btnScience2":
                        Response.Redirect("Science2Questions.aspx");
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
