using LanguageLearningApp.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LanguageLearningApp.Forms
{
    public partial class AdminPanelForm : Form
    {
        string connectionString = "Server=DESKTOP-NV8RV3L\\MSSQL;Database=LanguageLearningDB;Integrated Security=True;";

        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string questionText = textBoxQuestion.Text;
            string word1 = textBoxWord1.Text;
            string word2 = textBoxWord2.Text;
            string word3 = textBoxWord3.Text;
            int correctIndex = comboBoxCorrectWord.SelectedIndex + 1;
            string language = comboBoxLanguage.SelectedItem.ToString();

            if (language != "En")
            {
                MessageBox.Show("На данный момент поддерживается только английский.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string insertSentence = "INSERT INTO SentencesEng (QuestionText) OUTPUT INSERTED.Id VALUES (@question)";
                SqlCommand cmdSentence = new SqlCommand(insertSentence, conn);
                cmdSentence.Parameters.AddWithValue("@question", questionText);
                int sentenceId = (int)cmdSentence.ExecuteScalar();

                string[] words = { word1, word2, word3 };

                for (int i = 0; i < words.Length; i++)
                {
                    int wordOrder = (i + 1 == correctIndex) ? 1 : 0;
                    string insertWord = "INSERT INTO SentenceWordsEng (SentenceId, Word, WordOrder) VALUES (@sentenceId, @word, @wordOrder)";
                    SqlCommand cmdWord = new SqlCommand(insertWord, conn);
                    cmdWord.Parameters.AddWithValue("@sentenceId", sentenceId);
                    cmdWord.Parameters.AddWithValue("@word", words[i]);
                    cmdWord.Parameters.AddWithValue("@wordOrder", wordOrder);
                    cmdWord.ExecuteNonQuery();
                }

                MessageBox.Show("Данные успешно добавлены!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
