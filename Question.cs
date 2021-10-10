using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPractical
{
    class Question
    {
        private string v;

        public string QuestionText { get; set; }

        public string[] Answers { get; set; }

        public int CorrectAnswerPosition { get; set; }

        public Question(string questionText, string[] answers, int correctAnswerPosition)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerPosition = correctAnswerPosition;
        }

        public Question(string v)
        {
            this.v = v;
        }
    }
}
