namespace LanguageLearningApp.Controls
{
    partial class ModuleViewDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleViewDe));
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxLesson2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLesson1 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLesson2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLesson1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panelMain.Controls.Add(this.pictureBoxBack);
            this.panelMain.Controls.Add(this.pictureBoxLesson2);
            this.panelMain.Controls.Add(this.pictureBoxLesson1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(778, 561);
            this.panelMain.TabIndex = 2;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.Image")));
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBack.TabIndex = 3;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureBoxLesson2
            // 
            this.pictureBoxLesson2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLesson2.Image")));
            this.pictureBoxLesson2.Location = new System.Drawing.Point(231, 85);
            this.pictureBoxLesson2.Name = "pictureBoxLesson2";
            this.pictureBoxLesson2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLesson2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLesson2.TabIndex = 1;
            this.pictureBoxLesson2.TabStop = false;
            this.pictureBoxLesson2.Click += new System.EventHandler(this.pictureBoxLesson2_Click);
            // 
            // pictureBoxLesson1
            // 
            this.pictureBoxLesson1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLesson1.Image")));
            this.pictureBoxLesson1.Location = new System.Drawing.Point(131, 85);
            this.pictureBoxLesson1.Name = "pictureBoxLesson1";
            this.pictureBoxLesson1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLesson1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLesson1.TabIndex = 0;
            this.pictureBoxLesson1.TabStop = false;
            this.pictureBoxLesson1.Click += new System.EventHandler(this.pictureBoxLesson1_Click);
            // 
            // ModuleViewDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "ModuleViewDe";
            this.Size = new System.Drawing.Size(778, 561);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLesson2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLesson1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxLesson2;
        private System.Windows.Forms.PictureBox pictureBoxLesson1;
    }
}
