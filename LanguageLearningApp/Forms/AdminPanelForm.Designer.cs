namespace LanguageLearningApp.Forms
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxWord1 = new System.Windows.Forms.TextBox();
            this.textBoxWord2 = new System.Windows.Forms.TextBox();
            this.textBoxWord3 = new System.Windows.Forms.TextBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxCorrectWord = new System.Windows.Forms.ComboBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelWords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(220, 37);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(310, 20);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // textBoxWord1
            // 
            this.textBoxWord1.Location = new System.Drawing.Point(218, 75);
            this.textBoxWord1.Name = "textBoxWord1";
            this.textBoxWord1.Size = new System.Drawing.Size(100, 20);
            this.textBoxWord1.TabIndex = 1;
            // 
            // textBoxWord2
            // 
            this.textBoxWord2.Location = new System.Drawing.Point(324, 75);
            this.textBoxWord2.Name = "textBoxWord2";
            this.textBoxWord2.Size = new System.Drawing.Size(100, 20);
            this.textBoxWord2.TabIndex = 2;
            // 
            // textBoxWord3
            // 
            this.textBoxWord3.Location = new System.Drawing.Point(430, 75);
            this.textBoxWord3.Name = "textBoxWord3";
            this.textBoxWord3.Size = new System.Drawing.Size(100, 20);
            this.textBoxWord3.TabIndex = 3;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "En",
            "De",
            "Fr",
            "Es"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(218, 157);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLanguage.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(220, 242);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxCorrectWord
            // 
            this.comboBoxCorrectWord.FormattingEnabled = true;
            this.comboBoxCorrectWord.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxCorrectWord.Location = new System.Drawing.Point(220, 116);
            this.comboBoxCorrectWord.Name = "comboBoxCorrectWord";
            this.comboBoxCorrectWord.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCorrectWord.TabIndex = 8;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.ForeColor = System.Drawing.Color.White;
            this.labelQuestion.Location = new System.Drawing.Point(99, 41);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(113, 16);
            this.labelQuestion.TabIndex = 9;
            this.labelQuestion.Text = "Введите вопрос";
            // 
            // labelWords
            // 
            this.labelWords.AutoSize = true;
            this.labelWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWords.ForeColor = System.Drawing.Color.White;
            this.labelWords.Location = new System.Drawing.Point(25, 76);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(187, 16);
            this.labelWords.TabIndex = 10;
            this.labelWords.Text = "Введите варианты ответов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Выберите правильный ответ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выберите язык";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(12, 324);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(86, 23);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(637, 359);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWords);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.comboBoxCorrectWord);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.textBoxWord3);
            this.Controls.Add(this.textBoxWord2);
            this.Controls.Add(this.textBoxWord1);
            this.Controls.Add(this.textBoxQuestion);
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxWord1;
        private System.Windows.Forms.TextBox textBoxWord2;
        private System.Windows.Forms.TextBox textBoxWord3;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxCorrectWord;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
    }
}