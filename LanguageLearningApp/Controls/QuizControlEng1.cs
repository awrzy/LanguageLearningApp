using LanguageLearningApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LanguageLearningApp.Controls
{
    public partial class QuizControlEng1 : UserControl
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;
        private int incorrectAnswersCount = 0;

        public QuizControlEng1()
        {
            InitializeComponent();
            InitializeQuestions();
            ShowQuestion(questions[currentQuestionIndex]);

            buttonAnswer1.Click += new EventHandler(AnswerButton_Click);
            buttonAnswer2.Click += new EventHandler(AnswerButton_Click);
            buttonAnswer3.Click += new EventHandler(AnswerButton_Click);
            buttonCheck.Click += CheckAnswerButton_Click;
        }

        private void InitializeQuestions()
        {
            questions = new List<Question>();

            string connectionString = "Server=DESKTOP-NV8RV3L\\MSSQL;Database=LanguageLearningDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                List<(int Id, string Text, int CorrectAnswerIndex)> loadedQuestions = new List<(int, string, int)>();

                using (SqlCommand cmd = new SqlCommand("SELECT QuestionID, QuestionText, CorrectAnswerIndex FROM QuestionsEng", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string text = reader.GetString(1);
                        int correctIndex = reader.GetInt32(2);
                        loadedQuestions.Add((id, text, correctIndex));
                    }
                }

                foreach (var (id, text, correctAnswerIndex) in loadedQuestions)
                {
                    List<string> answers = new List<string>();
                    List<string> imagePaths = new List<string>();

                    using (SqlCommand cmdAnswers = new SqlCommand("SELECT AnswerText, ImagePath FROM AnswersEng WHERE QuestionId = @id ORDER BY QuestionID", conn))
                    {
                        cmdAnswers.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmdAnswers.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                answers.Add(reader.GetString(0));
                                imagePaths.Add(reader.GetString(1));
                            }
                        }
                    }

                    if (answers.Count == 3 && imagePaths.Count == 3)
                    {
                        questions.Add(new Question
                        {
                            Text = text,
                            Answers = answers.ToArray(),
                            CorrectAnswerIndex = correctAnswerIndex,
                            ImagePaths = imagePaths.ToArray()
                        });
                    }
                    else
                    {
                        MessageBox.Show($"Вопрос с ID={id} имеет недопустимое количество ответов или изображений (не 3). Пропускается.");
                    }
                }

                conn.Close();
            }
        }

        private void ShowQuestion(Question question)
        {
            labelQuestion.Text = question.Text;
            buttonAnswer1.Text = question.Answers[0];
            buttonAnswer2.Text = question.Answers[1];
            buttonAnswer3.Text = question.Answers[2];

            buttonAnswer1.Image = Image.FromFile(question.ImagePaths[0]);
            buttonAnswer2.Image = Image.FromFile(question.ImagePaths[1]);
            buttonAnswer3.Image = Image.FromFile(question.ImagePaths[2]);

            buttonAnswer1.BackColor = SystemColors.Control;
            buttonAnswer2.BackColor = SystemColors.Control;
            buttonAnswer3.BackColor = SystemColors.Control;
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            buttonAnswer1.BackColor = SystemColors.Control;
            buttonAnswer2.BackColor = SystemColors.Control;
            buttonAnswer3.BackColor = SystemColors.Control;

            ((System.Windows.Forms.Button)sender).BackColor = Color.LightGreen;
        }

        private void CheckAnswerButton_Click(object sender, EventArgs e)
        {
            var currentQuestion = questions[currentQuestionIndex];

            if (buttonAnswer1.BackColor == Color.LightGreen && currentQuestion.CorrectAnswerIndex == 0 ||
                buttonAnswer2.BackColor == Color.LightGreen && currentQuestion.CorrectAnswerIndex == 1 ||
                buttonAnswer3.BackColor == Color.LightGreen && currentQuestion.CorrectAnswerIndex == 2)
            {
                correctAnswersCount++;
                MessageBox.Show("Правильный ответ!", "Результат", MessageBoxButtons.OK);
            }
            else
            {
                incorrectAnswersCount++;
                MessageBox.Show("Неправильный ответ!", "Результат", MessageBoxButtons.OK);
            }

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                ShowQuestion(questions[currentQuestionIndex]);
            }
            else
            {
                progressBar.Value = (int)((double)correctAnswersCount / questions.Count * 100);
                ShowStatistics();
            }
            progressBar.Value = (int)((double)correctAnswersCount / questions.Count * 100);
        }

        private void ShowStatistics()
        {
            string message = $"Урок завершен!\n\n" +
                             $"Правильных ответов: {correctAnswersCount}\n" +
                             $"Неправильных ответов: {incorrectAnswersCount}\n" +
                             $"Общее количество вопросов: {questions.Count}";

            MessageBox.Show(message, "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);

            buttonCheck.Enabled = false;
        }
    }
}
