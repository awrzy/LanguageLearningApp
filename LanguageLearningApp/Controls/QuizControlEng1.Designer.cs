namespace LanguageLearningApp.Controls
{
    partial class QuizControlEng1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuestion = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonAnswer3 = new System.Windows.Forms.Button();
            this.buttonAnswer2 = new System.Windows.Forms.Button();
            this.buttonAnswer1 = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.ForeColor = System.Drawing.Color.White;
            this.labelQuestion.Location = new System.Drawing.Point(272, 98);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(200, 21);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Выберите слово \"Кофе\"";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.progressBar.ForeColor = System.Drawing.Color.Lime;
            this.progressBar.Location = new System.Drawing.Point(196, 25);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(337, 23);
            this.progressBar.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonCheck);
            this.panelMain.Controls.Add(this.progressBar);
            this.panelMain.Controls.Add(this.buttonAnswer3);
            this.panelMain.Controls.Add(this.labelQuestion);
            this.panelMain.Controls.Add(this.buttonAnswer2);
            this.panelMain.Controls.Add(this.buttonAnswer1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(778, 561);
            this.panelMain.TabIndex = 2;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(623, 486);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(118, 33);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = false;
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.BackColor = System.Drawing.Color.White;
            this.buttonAnswer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAnswer3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnswer3.ForeColor = System.Drawing.Color.Black;
            this.buttonAnswer3.Location = new System.Drawing.Point(508, 229);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(125, 140);
            this.buttonAnswer3.TabIndex = 2;
            this.buttonAnswer3.Text = "Milk";
            this.buttonAnswer3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAnswer3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAnswer3.UseVisualStyleBackColor = false;
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.BackColor = System.Drawing.Color.White;
            this.buttonAnswer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAnswer2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnswer2.ForeColor = System.Drawing.Color.Black;
            this.buttonAnswer2.Location = new System.Drawing.Point(299, 229);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(125, 140);
            this.buttonAnswer2.TabIndex = 1;
            this.buttonAnswer2.Text = "Tea";
            this.buttonAnswer2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAnswer2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAnswer2.UseVisualStyleBackColor = false;
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.BackColor = System.Drawing.Color.White;
            this.buttonAnswer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAnswer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnswer1.ForeColor = System.Drawing.Color.Black;
            this.buttonAnswer1.Location = new System.Drawing.Point(102, 229);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(125, 140);
            this.buttonAnswer1.TabIndex = 0;
            this.buttonAnswer1.Text = "Cofee";
            this.buttonAnswer1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAnswer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAnswer1.UseVisualStyleBackColor = false;
            // 
            // QuizControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.panelMain);
            this.Name = "QuizControl";
            this.Size = new System.Drawing.Size(778, 561);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonAnswer1;
        private System.Windows.Forms.Button buttonAnswer2;
        private System.Windows.Forms.Button buttonAnswer3;
    }
}
