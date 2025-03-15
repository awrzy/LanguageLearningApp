using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearningApp.Models
{
    public class Question
    {
        public string Text { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public string[] ImagePaths { get; set; }
    }
}
