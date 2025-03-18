using LanguageLearningApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LanguageLearningApp.Controls
{
    public partial class QuizControlEng2 : UserControl
    {
        private List<Sentence> sentences;
        private int currentSentenceIndex = 0;
        private int correctAnswersCount = 0;
        private int incorrectAnswersCount = 0;
        private List<System.Windows.Forms.Button> selectedWords = new List<System.Windows.Forms.Button>();

        public QuizControlEng2()
        {
            InitializeComponent();
            InitializeSentences();
            ShowSentence(sentences[currentSentenceIndex]);

            buttonWord1.Click += new EventHandler(WordButton_Click);
            buttonWord2.Click += new EventHandler(WordButton_Click);
            buttonWord3.Click += new EventHandler(WordButton_Click);
            buttonWord4.Click += new EventHandler(WordButton_Click);
            buttonWord5.Click += new EventHandler(WordButton_Click);
            buttonWord6.Click += new EventHandler(WordButton_Click);
            buttonWord7.Click += new EventHandler(WordButton_Click);
            buttonCheck.Click += CheckAnswerButton_Click;
            buttonReset.Click += ResetButton_Click;
        }

        private void InitializeSentences()
        {
        sentences = new List<Sentence>
        {
        new Sentence
        {
            Text =  "Переведите предложение 'Я люблю кофе'",
            Words = new string[] { "I", "love", "coffee", "tea" },
            CorrectOrder = new int[] { 0, 1, 2 }
        },
        new Sentence
        {
            Text = "Переведите предложение 'Собака лает'",
            Words = new string[] { "The", "dog", "barks", "cat" },
            CorrectOrder = new int[] { 0, 1, 2 }
        },
        new Sentence
        {
            Text = "Переведите предложение 'Я иду домой'",
            Words = new string[] { "I", "am", "going", "home" },
            CorrectOrder = new int[] { 0, 1, 2, 3 }
        },
        new Sentence
        {
            Text = "Переведите предложение 'Птицы поют утром'",
            Words = new string[] { "The", "birds", "sing", "in", "the", "morning" },
            CorrectOrder = new int[] { 0, 1, 2, 3, 4, 5 }
        },
        new Sentence
        {
            Text = "Переведите предложение 'Машина едет быстро'",
            Words = new string[] { "The", "car", "is", "moving", "fast" },
            CorrectOrder = new int[] { 0, 1, 2, 3, 4 }
        },
        new Sentence
        {
            Text = "Переведите предложение 'Солнце светит ярко'",
            Words = new string[] { "The", "sun", "is", "shining", "brightly" },
            CorrectOrder = new int[] { 0, 1, 2, 3, 4 }
        },
        new Sentence
        {
            Text = "Переведите предложение 'Они смотрят фильм'",
            Words = new string[] { "They", "are", "watching", "a", "movie" },
            CorrectOrder = new int[] { 0, 1, 2, 3, 4 }
        },
        new Sentence
        {
            Text = "Переведите предложение 'Я хочу пить'",
            Words = new string[] { "I", "want", "to", "drink", "water" },
            CorrectOrder = new int[] { 0, 1, 2, 3 }
        },
        new Sentence
        {
            Text = "Переведите предложение 'Онa говорит по-английски'",
            Words = new string[] { "She", "speaks", "English", "fluently" },
            CorrectOrder = new int[] { 0, 1, 2 }
        },
        new Sentence
        {
            Text = "Переведите предложение 'Мы живем в большом городе'",
            Words = new string[] { "We", "live", "in", "a", "big", "city" },
            CorrectOrder = new int[] { 0, 1, 2, 3, 4, 5 }
        }
            };
        }

        private void ShowSentence(Sentence sentence)
        {
            ShuffleWords(sentence);
            labelSentence.Text = sentence.Text;

            buttonWord1.Text = sentence.Words.Length > 0 ? sentence.Words[0].Trim() : string.Empty;
            buttonWord2.Text = sentence.Words.Length > 1 ? sentence.Words[1].Trim() : string.Empty;
            buttonWord3.Text = sentence.Words.Length > 2 ? sentence.Words[2].Trim() : string.Empty;
            buttonWord4.Text = sentence.Words.Length > 3 ? sentence.Words[3].Trim() : string.Empty;
            buttonWord5.Text = sentence.Words.Length > 4 ? sentence.Words[4].Trim() : string.Empty;
            buttonWord6.Text = sentence.Words.Length > 5 ? sentence.Words[5].Trim() : string.Empty;
            buttonWord7.Text = sentence.Words.Length > 6 ? sentence.Words[6].Trim() : string.Empty;

            UpdateButtonVisibility(sentence.Words.Length);

            buttonWord1.BackColor = SystemColors.Control;
            buttonWord2.BackColor = SystemColors.Control;
            buttonWord3.BackColor = SystemColors.Control;
            buttonWord4.BackColor = SystemColors.Control;
            buttonWord5.BackColor = SystemColors.Control;
            buttonWord6.BackColor = SystemColors.Control;
            buttonWord7.BackColor = SystemColors.Control;

            selectedWords.Clear();
            labelSelectedWords.Text = string.Empty;
        }

        private void UpdateButtonVisibility(int wordCount)
        {
            buttonWord1.Visible = wordCount > 0;
            buttonWord2.Visible = wordCount > 1;
            buttonWord3.Visible = wordCount > 2;
            buttonWord4.Visible = wordCount > 3;
            buttonWord5.Visible = wordCount > 4;
            buttonWord6.Visible = wordCount > 5;
            buttonWord7.Visible = wordCount > 6;
        }

        private void WordButton_Click(object sender, EventArgs e)
        {
            var button = (System.Windows.Forms.Button)sender;
            selectedWords.Add(button);
            labelSelectedWords.Text += button.Text + " ";
        }

        private void CheckAnswerButton_Click(object sender, EventArgs e)
        {
            var currentSentence = sentences[currentSentenceIndex];
            bool isCorrect = true;

            for (int i = 0; i < selectedWords.Count; i++)
            {
                if (!selectedWords[i].Text.Equals(
                    currentSentence.Words[currentSentence.CorrectOrder[i]],
                    StringComparison.OrdinalIgnoreCase)) // Игнорируем регистр
                {
                    isCorrect = false;
                    break;
                }
            }

            if (isCorrect && selectedWords.Count == currentSentence.CorrectOrder.Length)
            {
                correctAnswersCount++;
                MessageBox.Show("Правильный ответ!", "Результат", MessageBoxButtons.OK);
            }
            else
            {
                incorrectAnswersCount++;
                MessageBox.Show("Неправильный ответ!", "Результат", MessageBoxButtons.OK);
            }

            currentSentenceIndex++;
            if (currentSentenceIndex < sentences.Count)
            {
                ShowSentence(sentences[currentSentenceIndex]);
            }
            else
            {
                progressBar.Value = (int)((double)correctAnswersCount / sentences.Count * 100);
                ShowStatistics();
            }
            progressBar.Value = (int)((double)correctAnswersCount / sentences.Count * 100);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            selectedWords.Clear();
            labelSelectedWords.Text = string.Empty;
        }

        private void ShuffleWords(Sentence sentence)
        {
            var wordIndexPairs = sentence.Words
                .Select((word, index) => new { Word = word, Index = index })
                .ToList();

            Random rng = new Random();
            wordIndexPairs = wordIndexPairs.OrderBy(x => rng.Next()).ToList();

            for (int i = 0; i < wordIndexPairs.Count; i++)
            {
                sentence.Words[i] = wordIndexPairs[i].Word;
            }

            for (int i = 0; i < sentence.CorrectOrder.Length; i++)
            {
                int originalIndex = sentence.CorrectOrder[i];
                for (int j = 0; j < wordIndexPairs.Count; j++)
                {
                    if (wordIndexPairs[j].Index == originalIndex)
                    {
                        sentence.CorrectOrder[i] = j;
                        break;
                    }
                }
            }
        }

        private void ShowStatistics()
        {
            string message = $"Урок завершен!\n\n" +
                             $"Правильных ответов: {correctAnswersCount}\n" +
                             $"Неправильных ответов: {incorrectAnswersCount}\n" +
                             $"Общее количество предложений: {sentences.Count}";

            MessageBox.Show(message, "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);

            buttonCheck.Enabled = false;
            buttonReset.Enabled = false;
        }
    }
}