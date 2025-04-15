using System;
using System.Windows.Forms;

namespace LanguageLearningApp.Controls
{
    public partial class ModuleViewEs : UserControl
    {
        Controls.QuizControlEs1 ucQuizControlEs1 = new Controls.QuizControlEs1();
        Controls.QuizControlEs2 ucQuizControlEs2 = new Controls.QuizControlEs2();

        public ModuleViewEs()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            SpanishForm esForm = new SpanishForm();
            esForm.Show();
            this.Hide();
        }

        private void pictureBoxLesson1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQuizControlEs1);
            ucQuizControlEs1.Dock = DockStyle.Fill;
        }

        private void pictureBoxLesson2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQuizControlEs2);
            ucQuizControlEs2.Dock = DockStyle.Fill;
        }
    }
}
