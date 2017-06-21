namespace soccerGame.Screens
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manoBox = new System.Windows.Forms.PictureBox();
            this.soccerBox = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.manoLabel = new System.Windows.Forms.Label();
            this.soccerLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.recordsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.manoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // manoBox
            // 
            this.manoBox.BackColor = System.Drawing.Color.Transparent;
            this.manoBox.BackgroundImage = global::soccerGame.Properties.Resources.Header;
            this.manoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manoBox.Location = new System.Drawing.Point(0, 23);
            this.manoBox.Name = "manoBox";
            this.manoBox.Size = new System.Drawing.Size(710, 102);
            this.manoBox.TabIndex = 1;
            this.manoBox.TabStop = false;
            // 
            // soccerBox
            // 
            this.soccerBox.BackColor = System.Drawing.Color.Transparent;
            this.soccerBox.BackgroundImage = global::soccerGame.Properties.Resources.Header_clone;
            this.soccerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soccerBox.Location = new System.Drawing.Point(84, 122);
            this.soccerBox.Name = "soccerBox";
            this.soccerBox.Size = new System.Drawing.Size(749, 166);
            this.soccerBox.TabIndex = 2;
            this.soccerBox.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.playButton.FlatAppearance.BorderSize = 10;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Eras Bold ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(166, 351);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(250, 75);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click_1);
            this.playButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // manoLabel
            // 
            this.manoLabel.AutoSize = true;
            this.manoLabel.BackColor = System.Drawing.Color.Transparent;
            this.manoLabel.Font = new System.Drawing.Font("Eras Bold ITC", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manoLabel.ForeColor = System.Drawing.Color.White;
            this.manoLabel.Location = new System.Drawing.Point(136, 33);
            this.manoLabel.Name = "manoLabel";
            this.manoLabel.Size = new System.Drawing.Size(556, 75);
            this.manoLabel.TabIndex = 4;
            this.manoLabel.Text = "MANO-A-MANO";
            // 
            // soccerLabel
            // 
            this.soccerLabel.AutoSize = true;
            this.soccerLabel.BackColor = System.Drawing.Color.Transparent;
            this.soccerLabel.Font = new System.Drawing.Font("Eras Bold ITC", 96F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soccerLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.soccerLabel.Location = new System.Drawing.Point(251, 139);
            this.soccerLabel.Name = "soccerLabel";
            this.soccerLabel.Size = new System.Drawing.Size(590, 148);
            this.soccerLabel.TabIndex = 5;
            this.soccerLabel.Text = "SOCCER";
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
            this.quitButton.Location = new System.Drawing.Point(403, 539);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(250, 75);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // recordsButton
            // 
            this.recordsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.recordsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.recordsButton.FlatAppearance.BorderSize = 10;
            this.recordsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.recordsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.recordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordsButton.Font = new System.Drawing.Font("Eras Bold ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsButton.ForeColor = System.Drawing.Color.White;
            this.recordsButton.Location = new System.Drawing.Point(284, 445);
            this.recordsButton.Name = "recordsButton";
            this.recordsButton.Size = new System.Drawing.Size(250, 75);
            this.recordsButton.TabIndex = 2;
            this.recordsButton.Text = "RECORDS";
            this.recordsButton.UseVisualStyleBackColor = false;
            this.recordsButton.Click += new System.EventHandler(this.recordsButton_Click);
            this.recordsButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::soccerGame.Properties.Resources.succer_bal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.recordsButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.soccerLabel);
            this.Controls.Add(this.manoLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.soccerBox);
            this.Controls.Add(this.manoBox);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox manoBox;
        private System.Windows.Forms.PictureBox soccerBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label manoLabel;
        private System.Windows.Forms.Label soccerLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button recordsButton;
    }
}
