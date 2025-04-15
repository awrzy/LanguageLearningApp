using System;
using System.Windows.Forms;

namespace LanguageLearningApp
{
    public partial class DeutschForm : Form
    {
        Controls.ModuleViewDe ucModuleViewDe = new Controls.ModuleViewDe();

        public DeutschForm()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Завершает цикл сообщений и закрывает все формы
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
            panelMain.Controls.Add(ucModuleViewDe);
            ucModuleViewDe.Dock = DockStyle.Fill;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            HomeForm homePage = new HomeForm();
            homePage.Show();
            this.Hide();
        }
    }
}
