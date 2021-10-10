using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPractical
{
    class ICTQuiz : Quiz
    {

        public ICTQuiz(Player player, int time) : base(player)
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
            Questions.Add(new Question("How many bits are in a byte?", new[] { "B", "6", "2", "4" }, 0));
            Questions.Add(new Question("What is the storage size of a standard DVD", new[] { "1.44Gb", "4.5Gb", "5.2Gb", "4.7Gb" }, 3));
        }

    }
}
