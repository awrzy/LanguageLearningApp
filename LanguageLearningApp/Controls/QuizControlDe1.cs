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

namespace LanguageLearningApp.Controls
{
    public partial class QuizControlDe1 : UserControl
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;
        private int incorrectAnswersCount = 0;

        public QuizControlDe1()
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
            Text = "Выберите слово 'Кофе'",
            Answers = new string[] { "Kaffee", "Tee", "Milch" },
            CorrectAnswerIndex = 0,
            ImagePaths = new string[]
            {
                "Resources\\coffee.png",
                "Resources\\tea.png",
                "Resources\\milk.png"
            }
        },
        new Question
        {
            Text = "Выберите слово 'Соль'",
            Answers = new string[] { "Butter", "Brot", "Salz" },
            CorrectAnswerIndex = 2,
            ImagePaths = new string[]
            {
                "Resources\\butter.png",
                "Resources\\bread.png",
                "Resources\\salt.png"
            }
        },
        new Question
        {
            Text = "Выберите слово 'Яблоко'",
            Answers = new string[] { "Apfel", "Banane", "Orange" },
            CorrectAnswerIndex = 0,
            ImagePaths = new string[]
            {
                "Resources\\apple.png",
                "Resources\\banana.png",
                "Resources\\orange.png"
            }
        },
        new Question
        {
            Text = "Выберите слово 'Книга'",
            Answers = new string[] { "Buch", "Stift", "Tisch" },
            CorrectAnswerIndex = 0,
            ImagePaths = new string[]
            {
                "Resources\\book.png",
                "Resources\\pen.png",
                "Resources\\table.png"
            }
        },
        new Question
        {
            Text = "Выберите слово 'Собака'",
            Answers = new string[] { "Katze", "Hund", "Vogel" },
            CorrectAnswerIndex = 1,
            ImagePaths = new string[]
            {
                "Resources\\cat.png",
                "Resources\\dog.png",
                "Resources\\bird.png"
            }
        },
        new Question
        {
            Text = "Выберите слово 'Машина'",
            Answers = new string[] { "Fahrrad", "Auto", "Bus" },
            CorrectAnswerIndex = 1,
            ImagePaths = new string[]
            {
                "Resources\\bike.png",
                "Resources\\car.png",
                "Resources\\bus.png"
            }
        },
        new Question
        {
            Text = "Выберите слово 'Стол'",
            Answers = new string[] { "Brett", "Stuhl", "Tisch" },
            CorrectAnswerIndex = 2,
            ImagePaths = new string[]
            {
                "Resources\\board.png",
                "Resources\\chair.png",
                "Resources\\table.png"
            }
        },
        new Question
        {
            Text = "Выберите слово 'Окно'",
            Answers = new string[] { "Tür", "Fenster", "Wand" },
            CorrectAnswerIndex = 1,
            ImagePaths = new string[]
            {
                "Resources\\door.png",
                "Resources\\window.png",
                "Resources\\wall.png"
            }
        },
        new Question
        {
            Text = "Выберите слово 'Цветок'",
            Answers = new string[] { "Blume", "Baum", "Gras" },
            CorrectAnswerIndex = 0,
            ImagePaths = new string[]
            {
                "Resources\\flower.png",
                "Resources\\tree.png",
                "Resources\\grass.png"
            }
        },
        new Question
        {
            Text = "Выберите слово 'Рука'",
            Answers = new string[] { "Hand", "Fuß", "Hals" },
            CorrectAnswerIndex = 0,
            ImagePaths = new string[]
            {
                "Resources\\hand.png",
                "Resources\\foot.png",
                "Resources\\neck.png"
            }
        }
    };
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
