using LanguageLearningApp.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LanguageLearningApp.Models
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            string connectionString = "Server=DESKTOP-NV8RV3L\\MSSQL;Database=LanguageLearningDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int result = (int)cmd.ExecuteScalar();
                        if (result > 0)
                        {
                            MessageBox.Show("Успешный вход!");

                            if (username.ToLower() == "admin")
                            {
                                AdminPanelForm adminForm = new AdminPanelForm();
                                adminForm.Show();
                            }
                            else
                            {
                                HomeForm homeForm = new HomeForm();
                                homeForm.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к БД: " + ex.Message);
                }
            }
        }
    }
}