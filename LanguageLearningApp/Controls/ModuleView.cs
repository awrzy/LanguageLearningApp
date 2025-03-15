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
    public partial class ModuleView : UserControl
    {
        Controls.QuizControl ucQuizControl1 = new Controls.QuizControl();
        Controls.QuizControl2 ucQuizControl2 = new Controls.QuizControl2();

        public ModuleView()
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
