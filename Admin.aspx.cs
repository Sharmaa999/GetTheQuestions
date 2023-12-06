using System;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication7
{
    public partial class Admin : System.Web.UI.Page
    {
        private const string ConnectionString = "Data Source=MUM-LAP-700373\\SQLEXPRESS01;Initial Catalog=SchoolDatabase;Integrated Security=True";

        private bool AuthenticateAndCheckRole(string username, string password)
        {
            // Implement your authentication logic here
            // For simplicity, let's assume a hardcoded admin user
            if (username == "admin" && password == "adminpassword")
            {
                // Assign the "Admin" role
                Session["UserRole"] = "Admin";
                return true;
            }

            return false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the user is authenticated and is an admin
                string username = "admin"; // Replace with your authentication logic
                string password = "adminpassword"; // Replace with your authentication logic

                if (AuthenticateAndCheckRole(username, password))
                {
                    BindQuestionsGridView();
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void BindQuestionsGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT QuestionText, Marks, Level FROM Questions";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        GridView1.DataSource = dataTable;
                        GridView1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or display it for troubleshooting
                lblSuccessMessage.Text = $"An error occurred while fetching questions: {ex.Message}";
            }
        }

        protected void btnInsertQuestions_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedClass = ddlClass.SelectedValue;
                string selectedSubject = ddlSubject.SelectedValue;

                // Get questions and other details from admin input
                string questionText = txtQuestion.Text;
                int marks = Convert.ToInt32(txtMarks.Text);
                string level = ddlLevel.SelectedValue;

                bool questionsInserted = InsertQuestions(selectedClass, selectedSubject, questionText, marks, level);

                if (questionsInserted)
                {
                    lblSuccessMessage.Text = "Questions inserted successfully!";
                    BindQuestionsGridView();
                }
                else
                {
                    lblSuccessMessage.Text = "Failed to insert questions. Please try again.";
                }
            }
            catch (Exception ex)
            {
                // Log the error or display it for troubleshooting
                lblSuccessMessage.Text = $"An error occurred while inserting questions: {ex.Message}";
            }
        }

        private bool InsertQuestions(string selectedClass, string selectedSubject, string questionText, int marks, string level)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Find the next available SubjectID sequentially
                    int subjectID = FindNextAvailableSubjectID(connection);

                    // Insert the question using the obtained SubjectID
                    string insertQuestionQuery = "INSERT INTO Questions (QuestionText, SubjectID, Marks, Level) VALUES " +
                                                 "(@QuestionText, @SubjectID, @Marks, @Level)";

                    using (SqlCommand insertQuestionCommand = new SqlCommand(insertQuestionQuery, connection))
                    {
                        insertQuestionCommand.Parameters.AddWithValue("@QuestionText", questionText);
                        insertQuestionCommand.Parameters.AddWithValue("@SubjectID", subjectID);
                        insertQuestionCommand.Parameters.AddWithValue("@Marks", marks);
                        insertQuestionCommand.Parameters.AddWithValue("@Level", level);

                        insertQuestionCommand.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                // Log the error or display it for troubleshooting
                return false;
            }
        }

        private int FindNextAvailableSubjectID(SqlConnection connection)
        {
            try
            {
                // Get the maximum existing SubjectID from the Subjects table
                string getMaxSubjectIDQuery = "SELECT MAX(SubjectID) FROM Subjects";
                using (SqlCommand getMaxSubjectIDCommand = new SqlCommand(getMaxSubjectIDQuery, connection))
                {
                    object result = getMaxSubjectIDCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int maxSubjectID = Convert.ToInt32(result);

                        // Return the next available SubjectID
                        return maxSubjectID + 1;
                    }
                    else
                    {
                        // If no existing SubjectID is found, start from 1
                        return 1;
                    }
                }
            }
            catch (Exception)
            {
                // Log the error or display it for troubleshooting
                return -1; // Return an invalid value to indicate an error
            }
        }
    }
}
