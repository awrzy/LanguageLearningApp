using System;
using System.Windows.Forms;

namespace LanguageLearningApp
{
    public partial class SpanishForm : Form
    {
        Controls.ModuleViewEs ucModuleViewEs = new Controls.ModuleViewEs();

        public SpanishForm()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            HomeForm homePage = new HomeForm();
            homePage.Show();
            this.Hide();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            HomeForm homePage = new HomeForm();
            homePage.Show();
            this.Hide();
        }

        private void buttonLessons_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucModuleViewEs);
            ucModuleViewEs.Dock = DockStyle.Fill;
        }
    }
}
