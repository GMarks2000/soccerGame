namespace soccerGame.Screens
{
    partial class leftNet
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.redScoreLabel = new System.Windows.Forms.Label();
            this.blueScoreLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 16;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.DimGray;
            this.timeLabel.Font = new System.Drawing.Font("Liberation Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(611, 23);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(87, 35);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "300";
            // 
            // redScoreLabel
            // 
            this.redScoreLabel.BackColor = System.Drawing.Color.DarkRed;
            this.redScoreLabel.Font = new System.Drawing.Font("Liberation Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redScoreLabel.ForeColor = System.Drawing.Color.White;
            this.redScoreLabel.Location = new System.Drawing.Point(578, 26);
            this.redScoreLabel.Name = "redScoreLabel";
            this.redScoreLabel.Size = new System.Drawing.Size(33, 28);
            this.redScoreLabel.TabIndex = 1;
            this.redScoreLabel.Text = "0";
            // 
            // blueScoreLabel
            // 
            this.blueScoreLabel.BackColor = System.Drawing.Color.DarkBlue;
            this.blueScoreLabel.Font = new System.Drawing.Font("Liberation Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueScoreLabel.ForeColor = System.Drawing.Color.White;
            this.blueScoreLabel.Location = new System.Drawing.Point(698, 27);
            this.blueScoreLabel.Name = "blueScoreLabel";
            this.blueScoreLabel.Size = new System.Drawing.Size(33, 28);
            this.blueScoreLabel.TabIndex = 3;
            this.blueScoreLabel.Text = "0";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputLabel.Font = new System.Drawing.Font("Eras Bold ITC", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.outputLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outputLabel.Location = new System.Drawing.Point(429, 293);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(441, 111);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "SOCCER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::soccerGame.Properties.Resources.LookAtThisNetThatI_veJustFound;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(76, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 117);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::soccerGame.Properties.Resources.LookAtThisNetThatI_veJustFound1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1147, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 117);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // leftNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::soccerGame.Properties.Resources.soccerField;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.blueScoreLabel);
            this.Controls.Add(this.redScoreLabel);
            this.Controls.Add(this.timeLabel);
            this.DoubleBuffered = true;
            this.Name = "leftNet";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label redScoreLabel;
        private System.Windows.Forms.Label blueScoreLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
