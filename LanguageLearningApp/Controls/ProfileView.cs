using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LanguageLearningApp.Controls
{
    public partial class UserProfileControl : UserControl
    {
        private int userId;

        public UserProfileControl(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadUserProfile();
            LoadUserStatistics();
        }

        private void LoadUserProfile()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=LanguageLearning;Integrated Security=True";
            string query = "SELECT UserName, CreatedAt FROM UserProfile WHERE UserID = @UserID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        labelUserName.Text = $"Имя пользователя: {reader["UserName"]}";
                        labelCreatedAt.Text = $"Дата регистрации: {Convert.ToDateTime(reader["CreatedAt"]).ToShortDateString()}";
                    }
                }
            }
        }

        private void LoadUserStatistics()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=LanguageLearning;Integrated Security=True";
            string query = @"
                SELECT 
                    LanguageCode,
                    COUNT(*) AS Total,
                    SUM(CAST(IsCorrect AS INT)) AS Correct
                FROM UserStats
                WHERE UserID = @UserID
                GROUP BY LanguageCode";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    listBoxStats.Items.Clear();
                    while (reader.Read())
                    {
                        string lang = reader["LanguageCode"].ToString();
                        int total = (int)reader["Total"];
                        int correct = (int)reader["Correct"];
                        listBoxStats.Items.Add($"{lang.ToUpper()}: {correct}/{total} правильных");
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadUserStatistics();
        }
    }
}
