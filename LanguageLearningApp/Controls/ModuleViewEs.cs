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
    public partial class ModuleViewEs : UserControl
    {
        Controls.QuizControlEs1 ucQuizControlEs1 = new Controls.QuizControlEs1();

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
    }
}
