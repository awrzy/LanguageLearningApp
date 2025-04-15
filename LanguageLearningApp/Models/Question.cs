﻿namespace LanguageLearningApp.Models
{
    public class Question
    {
        public string Text { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public string[] ImagePaths { get; set; }
    }
}
