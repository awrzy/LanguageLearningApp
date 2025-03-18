using LanguageLearningApp.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageLearningApp
{
    public partial class FrenchForm : Form
    {
        Controls.ModuleViewFr ucModuleViewFr = new Controls.ModuleViewFr();

        public FrenchForm()
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
            panelMain.Controls.Add(ucModuleViewFr);
            ucModuleViewFr.Dock = DockStyle.Fill;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            HomeForm homePage = new HomeForm();
            homePage.Show();
            this.Hide();
        }
    }
}
