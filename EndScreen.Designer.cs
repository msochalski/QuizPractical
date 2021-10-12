
namespace QuizPractical
{
    partial class EndScreen
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
            this.QuizOver = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuizOver
            // 
            this.QuizOver.AutoSize = true;
            this.QuizOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizOver.Location = new System.Drawing.Point(414, 122);
            this.QuizOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuizOver.Name = "QuizOver";
            this.QuizOver.Size = new System.Drawing.Size(359, 82);
            this.QuizOver.TabIndex = 0;
            this.QuizOver.Text = "Quiz Over";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(258, 269);
            this.scoreLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(150, 55);
            this.scoreLbl.TabIndex = 1;
            this.scoreLbl.Text = "Score";
            // 
            // PlayAgain
            // 
            this.PlayAgain.Location = new System.Drawing.Point(429, 429);
            this.PlayAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(112, 35);
            this.PlayAgain.TabIndex = 2;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = true;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(660, 429);
            this.Quit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(112, 35);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.QuizOver);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EndScreen";
            this.Text = "EndScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuizOver;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button Quit;
    }
}