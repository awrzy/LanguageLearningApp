namespace LanguageLearningApp.Controls
{
    partial class UserProfileControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.listBoxStats = new System.Windows.Forms.ListBox();
            this.labelCreatedAt = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.listBoxStats);
            this.panel1.Controls.Add(this.labelCreatedAt);
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 561);
            this.panel1.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.Location = new System.Drawing.Point(670, 518);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(91, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // listBoxStats
            // 
            this.listBoxStats.FormattingEnabled = true;
            this.listBoxStats.Location = new System.Drawing.Point(86, 220);
            this.listBoxStats.Name = "listBoxStats";
            this.listBoxStats.Size = new System.Drawing.Size(120, 95);
            this.listBoxStats.TabIndex = 2;
            // 
            // labelCreatedAt
            // 
            this.labelCreatedAt.AutoSize = true;
            this.labelCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreatedAt.ForeColor = System.Drawing.Color.White;
            this.labelCreatedAt.Location = new System.Drawing.Point(480, 102);
            this.labelCreatedAt.Name = "labelCreatedAt";
            this.labelCreatedAt.Size = new System.Drawing.Size(126, 16);
            this.labelCreatedAt.TabIndex = 1;
            this.labelCreatedAt.Text = "Дата регистрации";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(297, 102);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(129, 16);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Имя пользователя";
            // 
            // UserProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserProfileControl";
            this.Size = new System.Drawing.Size(778, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ListBox listBoxStats;
        private System.Windows.Forms.Label labelCreatedAt;
        private System.Windows.Forms.Label labelUserName;
    }
}
