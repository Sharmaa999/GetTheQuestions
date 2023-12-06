using System;
using System.Web.UI.WebControls;


namespace WebApplication7
{
    public partial class UPSC : System.Web.UI.Page
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
                    case "btnReasoning":
                        Response.Redirect("ReasoningQuestions.aspx");
                        break;
                    case "btnIndianCulture":
                        Response.Redirect("IndianCultureQuestions.aspx");
                        break;
                    case "btnPolitics":
                        Response.Redirect("PoliticsQuestions.aspx");
                        break;
                    case "btnQuants":
                        Response.Redirect("QuantsQuestions.aspx");
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