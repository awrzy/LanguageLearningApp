namespace LanguageLearningApp
{
    partial class EnglishForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnglishForm));
            this.PanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonLessons = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.PanelMenu.Controls.Add(this.pictureBoxBack);
            this.PanelMenu.Controls.Add(this.pictureBoxLogo);
            this.PanelMenu.Controls.Add(this.buttonLessons);
            this.PanelMenu.Controls.Add(this.buttonProfile);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(206, 561);
            this.PanelMenu.TabIndex = 1;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.Image")));
            this.pictureBoxBack.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBack.TabIndex = 2;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(59, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // buttonLessons
            // 
            this.buttonLessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLessons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLessons.ForeColor = System.Drawing.Color.White;
            this.buttonLessons.Image = ((System.Drawing.Image)(resources.GetObject("buttonLessons.Image")));
            this.buttonLessons.Location = new System.Drawing.Point(3, 59);
            this.buttonLessons.Name = "buttonLessons";
            this.buttonLessons.Size = new System.Drawing.Size(197, 74);
            this.buttonLessons.TabIndex = 2;
            this.buttonLessons.Text = "Уроки";
            this.buttonLessons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLessons.UseVisualStyleBackColor = false;
            this.buttonLessons.Click += new System.EventHandler(this.buttonLessons_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProfile.ForeColor = System.Drawing.Color.White;
            this.buttonProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfile.Image")));
            this.buttonProfile.Location = new System.Drawing.Point(3, 139);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(197, 74);
            this.buttonProfile.TabIndex = 3;
            this.buttonProfile.Text = "Профиль";
            this.buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProfile.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(206, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(778, 561);
            this.panelMain.TabIndex = 2;
            // 
            // EnglishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.PanelMenu);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EnglishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изучение английского языка";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel PanelMenu;
        private System.Windows.Forms.Button buttonLessons;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelMain;
    }
}