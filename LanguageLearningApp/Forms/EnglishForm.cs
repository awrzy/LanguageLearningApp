using System;
using System.Windows.Forms;

namespace LanguageLearningApp
{
    public partial class EnglishForm : Form
    {
        Controls.ModuleViewEng ucModuleViewEng = new Controls.ModuleViewEng();

        public EnglishForm()
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

        private void buttonLessons_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucModuleViewEng);
            ucModuleViewEng.Dock = DockStyle.Fill;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            HomeForm homePage = new HomeForm();
            homePage.Show();
            this.Hide();
        }
    }
}
