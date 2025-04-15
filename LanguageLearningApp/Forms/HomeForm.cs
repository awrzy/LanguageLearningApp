using LanguageLearningApp.Models;
using System;
using System.Windows.Forms;

namespace LanguageLearningApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void pictureBoxEn_Click(object sender, EventArgs e)
        {
            EnglishForm EngForm = new EnglishForm();
            EngForm.Show();
            this.Hide();
        }

        private void pictureBoxDe_Click(object sender, EventArgs e)
        {
            DeutschForm DeForm = new DeutschForm();
            DeForm.Show();
            this.Hide();
        }

        private void pictureBoxFr_Click(object sender, EventArgs e)
        {
            FrenchForm FrForm = new FrenchForm();
            FrForm.Show();
            this.Hide();
        }

        private void pictureBoxEs_Click(object sender, EventArgs e)
        {
            SpanishForm EsForm = new SpanishForm();
            EsForm.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
