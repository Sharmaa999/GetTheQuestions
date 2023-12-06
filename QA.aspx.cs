using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class QA : System.Web.UI.Page
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
                case "Indian Culture Advance":
                    Response.Redirect("IndianCultureAdvanceQuestions.aspx");
                    break;
                case "History":
                    Response.Redirect("HistoryQuestions.aspx");
                    break;
                case "Environment":
                    Response.Redirect("EnvironmentQuestions.aspx");
                    break;
                default:
                    // Handle unknown subject
                    break;
            }
        }
    }
}
