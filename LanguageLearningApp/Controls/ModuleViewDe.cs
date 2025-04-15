using System;
using System.Windows.Forms;

namespace LanguageLearningApp.Controls
{
    public partial class ModuleViewDe : UserControl
    {
        Controls.QuizControlDe1 ucQuizControlDe1 = new Controls.QuizControlDe1();
        Controls.QuizControlDe2 ucQuizControlDe2 = new Controls.QuizControlDe2();

        public ModuleViewDe()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            DeutschForm deForm = new DeutschForm();
            deForm.Show();
            this.Hide();
        }

        private void pictureBoxLesson1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQuizControlDe1);
            ucQuizControlDe1.Dock = DockStyle.Fill;
        }

        private void pictureBoxLesson2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQuizControlDe2);
            ucQuizControlDe2.Dock = DockStyle.Fill;
        }
    }
}
