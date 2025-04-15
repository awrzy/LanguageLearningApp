namespace LanguageLearningApp.Models
{
    public class Sentence
    {
        public string Text { get; set; }
        public string[] Words { get; set; }
        public int[] CorrectOrder { get; set; }
    }
}
