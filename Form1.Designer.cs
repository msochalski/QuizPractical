
namespace QuizPractical
{
    partial class Form1
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
            this.QuizName = new System.Windows.Forms.Label();
            this.enterName = new System.Windows.Forms.Label();
            this.NameEntry = new System.Windows.Forms.TextBox();
            this.CodeQuiz = new System.Windows.Forms.Button();
            this.ICTQuiz = new System.Windows.Forms.Button();
            this.LastScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuizName
            // 
            this.QuizName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizName.Location = new System.Drawing.Point(226, 51);
            this.QuizName.Name = "QuizName";
            this.QuizName.Size = new System.Drawing.Size(366, 141);
            this.QuizName.TabIndex = 0;
            this.QuizName.Text = "Take the Quiz";
            this.QuizName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuizName.Click += new System.EventHandler(this.label1_Click);
            // 
            // enterName
            // 
            this.enterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterName.Location = new System.Drawing.Point(347, 192);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(123, 38);
            this.enterName.TabIndex = 1;
            this.enterName.Text = "Enter Your Name";
            this.enterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameEntry
            // 
            this.NameEntry.Location = new System.Drawing.Point(314, 233);
            this.NameEntry.Name = "NameEntry";
            this.NameEntry.Size = new System.Drawing.Size(188, 20);
            this.NameEntry.TabIndex = 2;
            // 
            // CodeQuiz
            // 
            this.CodeQuiz.Location = new System.Drawing.Point(314, 286);
            this.CodeQuiz.Name = "CodeQuiz";
            this.CodeQuiz.Size = new System.Drawing.Size(75, 23);
            this.CodeQuiz.TabIndex = 3;
            this.CodeQuiz.Text = "Code Quiz";
            this.CodeQuiz.UseVisualStyleBackColor = true;
            // 
            // ICTQuiz
            // 
            this.ICTQuiz.Location = new System.Drawing.Point(426, 285);
            this.ICTQuiz.Name = "ICTQuiz";
            this.ICTQuiz.Size = new System.Drawing.Size(75, 23);
            this.ICTQuiz.TabIndex = 4;
            this.ICTQuiz.Text = "ICT Quiz";
            this.ICTQuiz.UseVisualStyleBackColor = true;
            // 
            // LastScore
            // 
            this.LastScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastScore.Location = new System.Drawing.Point(42, 395);
            this.LastScore.Name = "LastScore";
            this.LastScore.Size = new System.Drawing.Size(100, 23);
            this.LastScore.TabIndex = 5;
            this.LastScore.Text = "Last Score:";
            this.LastScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LastScore);
            this.Controls.Add(this.ICTQuiz);
            this.Controls.Add(this.CodeQuiz);
            this.Controls.Add(this.NameEntry);
            this.Controls.Add(this.enterName);
            this.Controls.Add(this.QuizName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuizName;
        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.TextBox NameEntry;
        private System.Windows.Forms.Button CodeQuiz;
        private System.Windows.Forms.Button ICTQuiz;
        private System.Windows.Forms.Label LastScore;
    }
}

