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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBoxEn_Click(object sender, EventArgs e)
        {
            EnglishPage EngForm = new EnglishPage();
            EngForm.Show();
            this.Hide();
        }

        private void pictureBoxDe_Click(object sender, EventArgs e)
        {
            DeutschPage DeForm = new DeutschPage();
            DeForm.Show();
            this.Hide();
        }

        private void pictureBoxFr_Click(object sender, EventArgs e)
        {
            FrenchPage FrForm = new FrenchPage();
            FrForm.Show();
            this.Hide();
        }

        private void pictureBoxEs_Click(object sender, EventArgs e)
        {
            SpanishPage EsForm = new SpanishPage();
            EsForm.Show();
            this.Hide();
        }
    }
}
