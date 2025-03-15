namespace LanguageLearningApp
{
    partial class HomeForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.labelLanguageSelect = new System.Windows.Forms.Label();
            this.labelEn = new System.Windows.Forms.Label();
            this.labelDe = new System.Windows.Forms.Label();
            this.labelFr = new System.Windows.Forms.Label();
            this.labelEs = new System.Windows.Forms.Label();
            this.pictureBoxEs = new System.Windows.Forms.PictureBox();
            this.pictureBoxFr = new System.Windows.Forms.PictureBox();
            this.pictureBoxDe = new System.Windows.Forms.PictureBox();
            this.pictureBoxEn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEn)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLanguageSelect
            // 
            this.labelLanguageSelect.AutoSize = true;
            this.labelLanguageSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLanguageSelect.ForeColor = System.Drawing.Color.White;
            this.labelLanguageSelect.Location = new System.Drawing.Point(421, 171);
            this.labelLanguageSelect.Name = "labelLanguageSelect";
            this.labelLanguageSelect.Size = new System.Drawing.Size(150, 20);
            this.labelLanguageSelect.TabIndex = 4;
            this.labelLanguageSelect.Text = "Я хочу изучать...";
            // 
            // labelEn
            // 
            this.labelEn.AutoSize = true;
            this.labelEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEn.ForeColor = System.Drawing.Color.White;
            this.labelEn.Location = new System.Drawing.Point(199, 336);
            this.labelEn.Name = "labelEn";
            this.labelEn.Size = new System.Drawing.Size(94, 16);
            this.labelEn.TabIndex = 5;
            this.labelEn.Text = "Английский";
            // 
            // labelDe
            // 
            this.labelDe.AutoSize = true;
            this.labelDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDe.ForeColor = System.Drawing.Color.White;
            this.labelDe.Location = new System.Drawing.Point(365, 336);
            this.labelDe.Name = "labelDe";
            this.labelDe.Size = new System.Drawing.Size(81, 16);
            this.labelDe.TabIndex = 6;
            this.labelDe.Text = "Немецкий";
            // 
            // labelFr
            // 
            this.labelFr.AutoSize = true;
            this.labelFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFr.ForeColor = System.Drawing.Color.White;
            this.labelFr.Location = new System.Drawing.Point(509, 336);
            this.labelFr.Name = "labelFr";
            this.labelFr.Size = new System.Drawing.Size(107, 16);
            this.labelFr.TabIndex = 7;
            this.labelFr.Text = "Французский";
            // 
            // labelEs
            // 
            this.labelEs.AutoSize = true;
            this.labelEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEs.ForeColor = System.Drawing.Color.White;
            this.labelEs.Location = new System.Drawing.Point(680, 336);
            this.labelEs.Name = "labelEs";
            this.labelEs.Size = new System.Drawing.Size(87, 16);
            this.labelEs.TabIndex = 8;
            this.labelEs.Text = "Испанский";
            // 
            // pictureBoxEs
            // 
            this.pictureBoxEs.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEs.Image")));
            this.pictureBoxEs.Location = new System.Drawing.Point(683, 233);
            this.pictureBoxEs.Name = "pictureBoxEs";
            this.pictureBoxEs.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxEs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEs.TabIndex = 3;
            this.pictureBoxEs.TabStop = false;
            this.pictureBoxEs.Click += new System.EventHandler(this.pictureBoxEs_Click);
            // 
            // pictureBoxFr
            // 
            this.pictureBoxFr.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFr.Image")));
            this.pictureBoxFr.Location = new System.Drawing.Point(512, 233);
            this.pictureBoxFr.Name = "pictureBoxFr";
            this.pictureBoxFr.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFr.TabIndex = 2;
            this.pictureBoxFr.TabStop = false;
            this.pictureBoxFr.Click += new System.EventHandler(this.pictureBoxFr_Click);
            // 
            // pictureBoxDe
            // 
            this.pictureBoxDe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDe.Image")));
            this.pictureBoxDe.Location = new System.Drawing.Point(352, 233);
            this.pictureBoxDe.Name = "pictureBoxDe";
            this.pictureBoxDe.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDe.TabIndex = 1;
            this.pictureBoxDe.TabStop = false;
            this.pictureBoxDe.Click += new System.EventHandler(this.pictureBoxDe_Click);
            // 
            // pictureBoxEn
            // 
            this.pictureBoxEn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEn.Image")));
            this.pictureBoxEn.Location = new System.Drawing.Point(202, 233);
            this.pictureBoxEn.Name = "pictureBoxEn";
            this.pictureBoxEn.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEn.TabIndex = 0;
            this.pictureBoxEn.TabStop = false;
            this.pictureBoxEn.Click += new System.EventHandler(this.pictureBoxEn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.labelEs);
            this.Controls.Add(this.labelFr);
            this.Controls.Add(this.labelDe);
            this.Controls.Add(this.labelEn);
            this.Controls.Add(this.labelLanguageSelect);
            this.Controls.Add(this.pictureBoxEs);
            this.Controls.Add(this.pictureBoxFr);
            this.Controls.Add(this.pictureBoxDe);
            this.Controls.Add(this.pictureBoxEn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор языка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEn;
        private System.Windows.Forms.PictureBox pictureBoxDe;
        private System.Windows.Forms.PictureBox pictureBoxFr;
        private System.Windows.Forms.PictureBox pictureBoxEs;
        private System.Windows.Forms.Label labelLanguageSelect;
        private System.Windows.Forms.Label labelEn;
        private System.Windows.Forms.Label labelDe;
        private System.Windows.Forms.Label labelFr;
        private System.Windows.Forms.Label labelEs;
    }
}

