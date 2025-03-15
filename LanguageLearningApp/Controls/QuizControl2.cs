using LanguageLearningApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LanguageLearningApp.Controls
{
    public partial class QuizControl2 : UserControl
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;

        public QuizControl2()
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
            questions = new List<Question>
            {
                new Question
                {
                    Text = "1'",
                    Answers = new string[] { "1", "2", "3" },
                    CorrectAnswerIndex = 2,
                    ImagePaths = new string[] { "butter.png", "bread.png", "salt.png" }
                },
            };
        }

        private void ShowQuestion(Question question)
        {
            labelQuestion.Text = question.Text;
            buttonAnswer1.Text = question.Answers[0];
            buttonAnswer2.Text = question.Answers[1];
            buttonAnswer3.Text = question.Answers[2];

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
                MessageBox.Show("Правильный ответ!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Неправильный ответ!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                ShowQuestion(questions[currentQuestionIndex]);
            }
            else
            {
                MessageBox.Show("Викторина завершена!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonCheck.Enabled = false;
            }

            progressBar.Value = (int)((double)correctAnswersCount / questions.Count * 100);
        }
    }
}
