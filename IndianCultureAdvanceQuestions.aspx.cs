using System;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication7
{
    public partial class IndianCultureAdvanceQuestions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Assuming you have a method to create the SqlCommand
            SqlCommand command = CreateSqlCommand("Indian Culture Advance");
            DisplayQuestions(command);
        }

        private SqlCommand CreateSqlCommand(string selectedSubject)
        {
            string connectionString = "Data Source=MUM-LAP-700373\\SQLEXPRESS01;Initial Catalog=SchoolDatabase;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT TOP 10 QuestionText, Marks, Level FROM Questions " +
                           "JOIN Subjects ON Questions.SubjectID = Subjects.SubjectID " +
                           "WHERE Subjects.SubjectName = @SubjectName ORDER BY NEWID()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SubjectName", selectedSubject);

            return command;
        }

        private void DisplayQuestions(SqlCommand command)
        {
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string questionText = reader["QuestionText"].ToString();
                        int marks = Convert.ToInt32(reader["Marks"]);
                        string level = reader["Level"].ToString();

                        // Display the question details as needed (e.g., in a label or other controls)
                        lblQuestions.Text += $"Question: {questionText}<br>Marks: {marks}<br>Level: {level}<br><br>";
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message)
                lblError.Text = $"An error occurred: {ex.Message}";
            }
        }
    }
}
