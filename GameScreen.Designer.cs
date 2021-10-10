
namespace QuizPractical
{
    partial class GameScreen
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
            this.QuestionTitle1 = new System.Windows.Forms.Label();
            this.TimeLeft1 = new System.Windows.Forms.Label();
            this.QuestionText1 = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.Button();
            this.Answer2 = new System.Windows.Forms.Button();
            this.Answer3 = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionTitle1
            // 
            this.QuestionTitle1.AutoSize = true;
            this.QuestionTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTitle1.Location = new System.Drawing.Point(312, 103);
            this.QuestionTitle1.Name = "QuestionTitle1";
            this.QuestionTitle1.Size = new System.Drawing.Size(156, 33);
            this.QuestionTitle1.TabIndex = 0;
            this.QuestionTitle1.Text = "Question 1";
            this.QuestionTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLeft1
            // 
            this.TimeLeft1.AutoSize = true;
            this.TimeLeft1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeft1.Location = new System.Drawing.Point(673, 33);
            this.TimeLeft1.Name = "TimeLeft1";
            this.TimeLeft1.Size = new System.Drawing.Size(69, 20);
            this.TimeLeft1.TabIndex = 1;
            this.TimeLeft1.Text = "Time: 10";
            // 
            // QuestionText1
            // 
            this.QuestionText1.AutoSize = true;
            this.QuestionText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionText1.Location = new System.Drawing.Point(201, 165);
            this.QuestionText1.Name = "QuestionText1";
            this.QuestionText1.Size = new System.Drawing.Size(351, 29);
            this.QuestionText1.TabIndex = 2;
            this.QuestionText1.Text = "Question Text ______________";
            // 
            // Answer1
            // 
            this.Answer1.Location = new System.Drawing.Point(206, 236);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(119, 66);
            this.Answer1.TabIndex = 3;
            this.Answer1.Text = "Answer 1";
            this.Answer1.UseVisualStyleBackColor = true;
            // 
            // Answer2
            // 
            this.Answer2.Location = new System.Drawing.Point(433, 236);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(119, 66);
            this.Answer2.TabIndex = 4;
            this.Answer2.Text = "Answer 2";
            this.Answer2.UseVisualStyleBackColor = true;
            // 
            // Answer3
            // 
            this.Answer3.Location = new System.Drawing.Point(206, 321);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(119, 66);
            this.Answer3.TabIndex = 5;
            this.Answer3.Text = "Answer 3";
            this.Answer3.UseVisualStyleBackColor = true;
            // 
            // Answer4
            // 
            this.Answer4.Location = new System.Drawing.Point(433, 321);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(119, 66);
            this.Answer4.TabIndex = 6;
            this.Answer4.Text = "Answer 4";
            this.Answer4.UseVisualStyleBackColor = true;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.QuestionText1);
            this.Controls.Add(this.TimeLeft1);
            this.Controls.Add(this.QuestionTitle1);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionTitle1;
        private System.Windows.Forms.Label TimeLeft1;
        private System.Windows.Forms.Label QuestionText1;
        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.Button Answer4;
    }
}