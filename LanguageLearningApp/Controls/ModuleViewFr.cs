using System;
using System.Windows.Forms;

namespace LanguageLearningApp.Controls
{
    public partial class ModuleViewFr : UserControl
    {
        Controls.QuizControlFr1 ucQuizControlFr1 = new Controls.QuizControlFr1();
        Controls.QuizControlFr2 ucQuizControlFr2 = new Controls.QuizControlFr2();

        public ModuleViewFr()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FrenchForm frForm = new FrenchForm();
            frForm.Show();
            this.Hide();
        }

        private void pictureBoxLesson1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQuizControlFr1);
            ucQuizControlFr1.Dock = DockStyle.Fill;
        }

        private void pictureBoxLesson2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQuizControlFr2);
            ucQuizControlFr2.Dock = DockStyle.Fill;
        }
    }
}
