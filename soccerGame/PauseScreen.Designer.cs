namespace soccerGame
{
    partial class PauseScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.resumeButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Eras Bold ITC", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Location = new System.Drawing.Point(70, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(451, 111);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "PAUSED";
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.resumeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resumeButton.FlatAppearance.BorderSize = 10;
            this.resumeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.resumeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.resumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resumeButton.Font = new System.Drawing.Font("Eras Bold ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeButton.ForeColor = System.Drawing.Color.White;
            this.resumeButton.Location = new System.Drawing.Point(175, 144);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(250, 75);
            this.resumeButton.TabIndex = 1;
            this.resumeButton.Text = "RESUME";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            this.resumeButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.quitButton.FlatAppearance.BorderSize = 10;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Eras Bold ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(175, 249);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(250, 75);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "MENU";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // PauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PauseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PauseScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button quitButton;
    }
}