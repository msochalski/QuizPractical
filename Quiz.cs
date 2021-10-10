using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPractical
{
    class Quiz
    {

        public Player Player { get; set; }

        public int Countdown { get; set; }

        public List<Question> Questions = new List<Question>();

        public Quiz(Player player)
        {
            Player = player;
        }

        public int CurrectQuestionPosition { get; set; }

        public virtual void SetTimeOfQuiz(int time)
        {
            //Override the question bank in each quiz
        }

        public virtual void AddQuestions()
        {
            //Override the question bank in each quiz
        }

        public Boolean HasNextQuestion
        {
            get { return CurrectQuestionPosition < (Questions.Count - 1); }
        }

        public void CheckAnswer(int selectedIndex)
        {
            if (selectedIndex == Questions[CurrectQuestionPosition].CorrectAnswerPosition)
            {
                Player.Score++;
            }
        }

        public void ResetQuiz()
        {
            CurrectQuestionPosition = 0;
            Player.Score = 0;
        }

    }
}
