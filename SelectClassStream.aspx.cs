using System;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class SelectClassStream : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClass_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string selectedClass = clickedButton.Text;

            switch (selectedClass)
            {
                case "9th Class":
                    Response.Redirect("9thClass.aspx");
                    break;
                case "10th Class":
                    Response.Redirect("10thClassQuestions.aspx");
                    break;
                case "12th Class":
                    Response.Redirect("12thClass.aspx");
                    break;
                case "NEET":
                    Response.Redirect("NEET.aspx");
                    break;
                case "UPSC":
                    Response.Redirect("UPSC.aspx");
                    break;
                case "QA":
                    Response.Redirect("QA.aspx");
                    break;
                default:
                    // Handle unknown class
                    break;
            }
        }
    }
}
    

