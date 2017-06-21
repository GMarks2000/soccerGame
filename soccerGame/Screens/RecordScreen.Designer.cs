namespace soccerGame.Screens
{
    partial class RecordScreen
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
            this.redBox = new System.Windows.Forms.PictureBox();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redScoreLabel2 = new System.Windows.Forms.Label();
            this.redScoreLabel3 = new System.Windows.Forms.Label();
            this.blueScoreLabel1 = new System.Windows.Forms.Label();
            this.blueScoreLabel3 = new System.Windows.Forms.Label();
            this.blueScoreLabel2 = new System.Windows.Forms.Label();
            this.redScoreLabel1 = new System.Windows.Forms.Label();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.redWinsLabel = new System.Windows.Forms.Label();
            this.blueWinsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Transparent;
            this.redBox.BackgroundImage = global::soccerGame.Properties.Resources.Header;
            this.redBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redBox.Location = new System.Drawing.Point(139, 3);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(468, 131);
            this.redBox.TabIndex = 2;
            this.redBox.TabStop = false;
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.BackColor = System.Drawing.Color.Transparent;
            this.redLabel.Font = new System.Drawing.Font("Eras Bold ITC", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(158, 26);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(379, 75);
            this.redLabel.TabIndex = 5;
            this.redLabel.Text = "RED TEAM";
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.Color.Transparent;
            this.blueBox.BackgroundImage = global::soccerGame.Properties.Resources.Header_clone_2;
            this.blueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueBox.Location = new System.Drawing.Point(661, 3);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(470, 131);
            this.blueBox.TabIndex = 6;
            this.blueBox.TabStop = false;
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.BackColor = System.Drawing.Color.Transparent;
            this.blueLabel.Font = new System.Drawing.Font("Eras Bold ITC", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(674, 35);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(417, 75);
            this.blueLabel.TabIndex = 7;
            this.blueLabel.Text = "BLUE TEAM";
            // 
            // redScoreLabel2
            // 
            this.redScoreLabel2.BackColor = System.Drawing.Color.ForestGreen;
            this.redScoreLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redScoreLabel2.Font = new System.Drawing.Font("Eras Bold ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redScoreLabel2.ForeColor = System.Drawing.Color.White;
            this.redScoreLabel2.Location = new System.Drawing.Point(331, 285);
            this.redScoreLabel2.Name = "redScoreLabel2";
            this.redScoreLabel2.Size = new System.Drawing.Size(276, 94);
            this.redScoreLabel2.TabIndex = 9;
            this.redScoreLabel2.Text = "0";
            this.redScoreLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redScoreLabel3
            // 
            this.redScoreLabel3.BackColor = System.Drawing.Color.ForestGreen;
            this.redScoreLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redScoreLabel3.Font = new System.Drawing.Font("Eras Bold ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redScoreLabel3.ForeColor = System.Drawing.Color.White;
            this.redScoreLabel3.Location = new System.Drawing.Point(331, 419);
            this.redScoreLabel3.Name = "redScoreLabel3";
            this.redScoreLabel3.Size = new System.Drawing.Size(276, 94);
            this.redScoreLabel3.TabIndex = 10;
            this.redScoreLabel3.Text = "0";
            this.redScoreLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueScoreLabel1
            // 
            this.blueScoreLabel1.BackColor = System.Drawing.Color.ForestGreen;
            this.blueScoreLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueScoreLabel1.Font = new System.Drawing.Font("Eras Bold ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueScoreLabel1.ForeColor = System.Drawing.Color.White;
            this.blueScoreLabel1.Location = new System.Drawing.Point(661, 156);
            this.blueScoreLabel1.Name = "blueScoreLabel1";
            this.blueScoreLabel1.Size = new System.Drawing.Size(276, 94);
            this.blueScoreLabel1.TabIndex = 11;
            this.blueScoreLabel1.Text = "0";
            this.blueScoreLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueScoreLabel3
            // 
            this.blueScoreLabel3.BackColor = System.Drawing.Color.ForestGreen;
            this.blueScoreLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueScoreLabel3.Font = new System.Drawing.Font("Eras Bold ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueScoreLabel3.ForeColor = System.Drawing.Color.White;
            this.blueScoreLabel3.Location = new System.Drawing.Point(661, 419);
            this.blueScoreLabel3.Name = "blueScoreLabel3";
            this.blueScoreLabel3.Size = new System.Drawing.Size(276, 94);
            this.blueScoreLabel3.TabIndex = 12;
            this.blueScoreLabel3.Text = "0";
            this.blueScoreLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueScoreLabel2
            // 
            this.blueScoreLabel2.BackColor = System.Drawing.Color.ForestGreen;
            this.blueScoreLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueScoreLabel2.Font = new System.Drawing.Font("Eras Bold ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueScoreLabel2.ForeColor = System.Drawing.Color.White;
            this.blueScoreLabel2.Location = new System.Drawing.Point(661, 285);
            this.blueScoreLabel2.Name = "blueScoreLabel2";
            this.blueScoreLabel2.Size = new System.Drawing.Size(276, 94);
            this.blueScoreLabel2.TabIndex = 13;
            this.blueScoreLabel2.Text = "0";
            this.blueScoreLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redScoreLabel1
            // 
            this.redScoreLabel1.BackColor = System.Drawing.Color.ForestGreen;
            this.redScoreLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redScoreLabel1.Font = new System.Drawing.Font("Eras Bold ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redScoreLabel1.ForeColor = System.Drawing.Color.White;
            this.redScoreLabel1.Location = new System.Drawing.Point(331, 156);
            this.redScoreLabel1.Name = "redScoreLabel1";
            this.redScoreLabel1.Size = new System.Drawing.Size(276, 94);
            this.redScoreLabel1.TabIndex = 8;
            this.redScoreLabel1.Text = "0";
            this.redScoreLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.upButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.upButton.FlatAppearance.BorderSize = 10;
            this.upButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.upButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.Font = new System.Drawing.Font("Eras Bold ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.ForeColor = System.Drawing.Color.White;
            this.upButton.Location = new System.Drawing.Point(661, 566);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(76, 81);
            this.upButton.TabIndex = 2;
            this.upButton.Text = "▲";
            this.upButton.UseVisualStyleBackColor = false;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            this.upButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.downButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.downButton.FlatAppearance.BorderSize = 10;
            this.downButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.downButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Font = new System.Drawing.Font("Eras Bold ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.ForeColor = System.Drawing.Color.White;
            this.downButton.Location = new System.Drawing.Point(531, 566);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(76, 81);
            this.downButton.TabIndex = 1;
            this.downButton.Text = "▼";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            this.downButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.returnButton.FlatAppearance.BorderSize = 10;
            this.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.returnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Eras Bold ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(1036, 614);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(250, 75);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "BACK";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            this.returnButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // redWinsLabel
            // 
            this.redWinsLabel.BackColor = System.Drawing.Color.ForestGreen;
            this.redWinsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redWinsLabel.Font = new System.Drawing.Font("Eras Bold ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redWinsLabel.ForeColor = System.Drawing.Color.White;
            this.redWinsLabel.Location = new System.Drawing.Point(39, 285);
            this.redWinsLabel.Name = "redWinsLabel";
            this.redWinsLabel.Size = new System.Drawing.Size(276, 94);
            this.redWinsLabel.TabIndex = 17;
            this.redWinsLabel.Text = "0";
            this.redWinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueWinsLabel
            // 
            this.blueWinsLabel.BackColor = System.Drawing.Color.ForestGreen;
            this.blueWinsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueWinsLabel.Font = new System.Drawing.Font("Eras Bold ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueWinsLabel.ForeColor = System.Drawing.Color.White;
            this.blueWinsLabel.Location = new System.Drawing.Point(955, 285);
            this.blueWinsLabel.Name = "blueWinsLabel";
            this.blueWinsLabel.Size = new System.Drawing.Size(276, 94);
            this.blueWinsLabel.TabIndex = 18;
            this.blueWinsLabel.Text = "0";
            this.blueWinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::soccerGame.Properties.Resources.Grass2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.blueWinsLabel);
            this.Controls.Add(this.redWinsLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.blueScoreLabel2);
            this.Controls.Add(this.blueScoreLabel3);
            this.Controls.Add(this.blueScoreLabel1);
            this.Controls.Add(this.redScoreLabel3);
            this.Controls.Add(this.redScoreLabel2);
            this.Controls.Add(this.redScoreLabel1);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.redBox);
            this.DoubleBuffered = true;
            this.Name = "RecordScreen";
            this.Size = new System.Drawing.Size(1300, 700);
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redBox;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redScoreLabel2;
        private System.Windows.Forms.Label redScoreLabel3;
        private System.Windows.Forms.Label blueScoreLabel1;
        private System.Windows.Forms.Label blueScoreLabel3;
        private System.Windows.Forms.Label blueScoreLabel2;
        private System.Windows.Forms.Label redScoreLabel1;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label redWinsLabel;
        private System.Windows.Forms.Label blueWinsLabel;
    }
}
