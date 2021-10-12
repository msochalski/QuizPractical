
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.CodeQuiz = new System.Windows.Forms.Button();
            this.ICTQuiz = new System.Windows.Forms.Button();
            this.lastScoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuizName
            // 
            this.QuizName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizName.Location = new System.Drawing.Point(339, 78);
            this.QuizName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuizName.Name = "QuizName";
            this.QuizName.Size = new System.Drawing.Size(549, 217);
            this.QuizName.TabIndex = 0;
            this.QuizName.Text = "Take the Quiz";
            this.QuizName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuizName.Click += new System.EventHandler(this.label1_Click);
            // 
            // enterName
            // 
            this.enterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterName.Location = new System.Drawing.Point(520, 295);
            this.enterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(184, 58);
            this.enterName.TabIndex = 1;
            this.enterName.Text = "Enter Your Name";
            this.enterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(471, 358);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(280, 26);
            this.nameTxtBox.TabIndex = 2;
            // 
            // CodeQuiz
            // 
            this.CodeQuiz.Location = new System.Drawing.Point(471, 440);
            this.CodeQuiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CodeQuiz.Name = "CodeQuiz";
            this.CodeQuiz.Size = new System.Drawing.Size(112, 35);
            this.CodeQuiz.TabIndex = 3;
            this.CodeQuiz.Text = "Code Quiz";
            this.CodeQuiz.UseVisualStyleBackColor = true;
            this.CodeQuiz.Click += new System.EventHandler(this.CodeQuiz_Click);
            // 
            // ICTQuiz
            // 
            this.ICTQuiz.Location = new System.Drawing.Point(639, 438);
            this.ICTQuiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ICTQuiz.Name = "ICTQuiz";
            this.ICTQuiz.Size = new System.Drawing.Size(112, 35);
            this.ICTQuiz.TabIndex = 4;
            this.ICTQuiz.Text = "ICT Quiz";
            this.ICTQuiz.UseVisualStyleBackColor = true;
            this.ICTQuiz.Click += new System.EventHandler(this.ICTQuiz_Click);
            // 
            // lastScoreLbl
            // 
            this.lastScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastScoreLbl.Location = new System.Drawing.Point(63, 608);
            this.lastScoreLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastScoreLbl.Name = "lastScoreLbl";
            this.lastScoreLbl.Size = new System.Drawing.Size(150, 35);
            this.lastScoreLbl.TabIndex = 5;
            this.lastScoreLbl.Text = "Last Score:";
            this.lastScoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lastScoreLbl);
            this.Controls.Add(this.ICTQuiz);
            this.Controls.Add(this.CodeQuiz);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.enterName);
            this.Controls.Add(this.QuizName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuizName;
        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Button CodeQuiz;
        private System.Windows.Forms.Button ICTQuiz;
        private System.Windows.Forms.Label lastScoreLbl;
    }
}

