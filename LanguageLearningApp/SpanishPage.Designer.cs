namespace LanguageLearningApp
{
    partial class SpanishPage
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
            this.buttonReselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReselect
            // 
            this.buttonReselect.Location = new System.Drawing.Point(12, 415);
            this.buttonReselect.Name = "buttonReselect";
            this.buttonReselect.Size = new System.Drawing.Size(134, 23);
            this.buttonReselect.TabIndex = 0;
            this.buttonReselect.Text = "Выбрать другой язык";
            this.buttonReselect.UseVisualStyleBackColor = true;
            this.buttonReselect.Click += new System.EventHandler(this.buttonReselect_Click);
            // 
            // SpanishPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReselect);
            this.Name = "SpanishPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpanishPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReselect;
    }
}