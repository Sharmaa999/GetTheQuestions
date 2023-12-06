using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class _9thClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubject_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string selectedSubject = clickedButton.Text;

            // Store the selected subject in a session variable
            Session["SelectedSubject"] = selectedSubject;

            // Redirect to the specific page for the selected subject
            switch (selectedSubject)
            {
                case "Maths":
                    Response.Redirect("MathsQuestions.aspx");
                    break;
                case "Social Science":
                    Response.Redirect("SocialScienceQuestions.aspx");
                    break;
                case "Science":
                    Response.Redirect("ScienceQuestions.aspx");
                    break;
                case "English":
                    Response.Redirect("EnglishQuestions.aspx");
                    break;
                default:
                    // Handle unknown subject
                    break;
            }
        }
    }
}
