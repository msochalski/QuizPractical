
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.timerLbl = new System.Windows.Forms.Label();
            this.questionTextValue = new System.Windows.Forms.Label();
            this.answer1Button = new System.Windows.Forms.Button();
            this.answer2Button = new System.Windows.Forms.Button();
            this.answer3Button = new System.Windows.Forms.Button();
            this.answer4Button = new System.Windows.Forms.Button();
            this.CurrentQuestionPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(468, 158);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(221, 52);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question: ";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLbl.Location = new System.Drawing.Point(1010, 51);
            this.timerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(107, 29);
            this.timerLbl.TabIndex = 1;
            this.timerLbl.Text = "Time: 10";
            // 
            // questionTextValue
            // 
            this.questionTextValue.AutoSize = true;
            this.questionTextValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextValue.Location = new System.Drawing.Point(302, 254);
            this.questionTextValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionTextValue.Name = "questionTextValue";
            this.questionTextValue.Size = new System.Drawing.Size(531, 40);
            this.questionTextValue.TabIndex = 2;
            this.questionTextValue.Text = "Question Text ______________";
            // 
            // answer1Button
            // 
            this.answer1Button.Location = new System.Drawing.Point(309, 363);
            this.answer1Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.answer1Button.Name = "answer1Button";
            this.answer1Button.Size = new System.Drawing.Size(178, 102);
            this.answer1Button.TabIndex = 3;
            this.answer1Button.Text = "Answer 1";
            this.answer1Button.UseVisualStyleBackColor = true;
            this.answer1Button.Click += new System.EventHandler(this.answer1Button_Click);
            // 
            // answer2Button
            // 
            this.answer2Button.Location = new System.Drawing.Point(650, 363);
            this.answer2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.answer2Button.Name = "answer2Button";
            this.answer2Button.Size = new System.Drawing.Size(178, 102);
            this.answer2Button.TabIndex = 4;
            this.answer2Button.Text = "Answer 2";
            this.answer2Button.UseVisualStyleBackColor = true;
            this.answer2Button.Click += new System.EventHandler(this.answer2Button_Click);
            // 
            // answer3Button
            // 
            this.answer3Button.Location = new System.Drawing.Point(309, 494);
            this.answer3Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.answer3Button.Name = "answer3Button";
            this.answer3Button.Size = new System.Drawing.Size(178, 102);
            this.answer3Button.TabIndex = 5;
            this.answer3Button.Text = "Answer 3";
            this.answer3Button.UseVisualStyleBackColor = true;
            this.answer3Button.Click += new System.EventHandler(this.answer3Button_Click);
            // 
            // answer4Button
            // 
            this.answer4Button.Location = new System.Drawing.Point(650, 494);
            this.answer4Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.answer4Button.Name = "answer4Button";
            this.answer4Button.Size = new System.Drawing.Size(178, 102);
            this.answer4Button.TabIndex = 6;
            this.answer4Button.Text = "Answer 4";
            this.answer4Button.UseVisualStyleBackColor = true;
            this.answer4Button.Click += new System.EventHandler(this.answer4Button_Click);
            // 
            // CurrentQuestionPosition
            // 
            this.CurrentQuestionPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentQuestionPosition.Location = new System.Drawing.Point(696, 158);
            this.CurrentQuestionPosition.Name = "CurrentQuestionPosition";
            this.CurrentQuestionPosition.Size = new System.Drawing.Size(75, 52);
            this.CurrentQuestionPosition.TabIndex = 7;
            this.CurrentQuestionPosition.Text = "1";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.CurrentQuestionPosition);
            this.Controls.Add(this.answer4Button);
            this.Controls.Add(this.answer3Button);
            this.Controls.Add(this.answer2Button);
            this.Controls.Add(this.answer1Button);
            this.Controls.Add(this.questionTextValue);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.questionLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Label questionTextValue;
        private System.Windows.Forms.Button answer1Button;
        private System.Windows.Forms.Button answer2Button;
        private System.Windows.Forms.Button answer3Button;
        private System.Windows.Forms.Button answer4Button;
        private System.Windows.Forms.Label CurrentQuestionPosition;
    }
}