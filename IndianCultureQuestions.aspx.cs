using System;
using System.Data.SqlClient;

namespace WebApplication7
{
    public partial class IndianCultureQuestions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayQuestions("Indian Culture");
        }

        private void DisplayQuestions(string selectedSubject)
        {
            string connectionString = "Data Source=MUM-LAP-700373\\SQLEXPRESS01;Initial Catalog=SchoolDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 10 QuestionText, Marks, Level FROM Questions " +
                       "JOIN Subjects ON Questions.SubjectID = Subjects.SubjectID " +
                       "WHERE Subjects.SubjectName = @SubjectName ORDER BY NEWID()";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubjectName", selectedSubject);

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
            }
        }
    }
}