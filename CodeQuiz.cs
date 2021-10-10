using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPractical
{
    class CodeQuiz : Quiz
    {
        public CodingQuiz(Player player, int time) : base(player)
        {
            AddQuestions();
            SetTimeOfQuiz(time);
        }

        public override void SetTimeOfQuiz(int time)
        {
            Countdown = time;
        }

        public override void AddQuestions()
        {
            Questions.Add(new Question("What is the sign for Modulus?", new[] { "+", "%", "-", "/" }, 1));
        }
    }
}
