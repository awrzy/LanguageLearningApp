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
    public partial class ModuleViewFr : UserControl
    {
        Controls.QuizControlFr1 ucQuizControlFr1 = new Controls.QuizControlFr1();

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
    }
}
