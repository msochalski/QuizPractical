
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
            this.ScoreResult = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuizOver
            // 
            this.QuizOver.AutoSize = true;
            this.QuizOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizOver.Location = new System.Drawing.Point(276, 79);
            this.QuizOver.Name = "QuizOver";
            this.QuizOver.Size = new System.Drawing.Size(239, 55);
            this.QuizOver.TabIndex = 0;
            this.QuizOver.Text = "Quiz Over";
            // 
            // ScoreResult
            // 
            this.ScoreResult.AutoSize = true;
            this.ScoreResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreResult.Location = new System.Drawing.Point(172, 175);
            this.ScoreResult.Name = "ScoreResult";
            this.ScoreResult.Size = new System.Drawing.Size(100, 37);
            this.ScoreResult.TabIndex = 1;
            this.ScoreResult.Text = "Score";
            // 
            // PlayAgain
            // 
            this.PlayAgain.Location = new System.Drawing.Point(286, 279);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(75, 23);
            this.PlayAgain.TabIndex = 2;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = true;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(440, 279);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.ScoreResult);
            this.Controls.Add(this.QuizOver);
            this.Name = "EndScreen";
            this.Text = "EndScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuizOver;
        private System.Windows.Forms.Label ScoreResult;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button Quit;
    }
}