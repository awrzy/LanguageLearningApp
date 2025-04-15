using System;
using System.Windows.Forms;

namespace LanguageLearningApp.Controls
{
    public partial class ModuleViewEng : UserControl
    {
        Controls.QuizControlEng1 ucQuizControl1 = new Controls.QuizControlEng1();
        Controls.QuizControlEng2 ucQuizControl2 = new Controls.QuizControlEng2();

        public ModuleViewEng()
        {
            InitializeComponent();
        }

        private void pictureBoxLesson1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQuizControl1);
            ucQuizControl1.Dock = DockStyle.Fill;
        }

        private void pictureBoxLesson2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQuizControl2);
            ucQuizControl2.Dock = DockStyle.Fill;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            EnglishForm engForm = new EnglishForm();
            engForm.Show();
            this.Hide();
        }
    }
}
