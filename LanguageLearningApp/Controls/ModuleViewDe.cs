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
    public partial class ModuleViewDe : UserControl
    {
        Controls.QuizControlDe1 ucQuizControl1 = new Controls.QuizControlDe1();

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
            panelMain.Controls.Add(ucQuizControl1);
            ucQuizControl1.Dock = DockStyle.Fill;
        }
    }
}
