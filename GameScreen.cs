using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizPractical
{
    public partial class GameScreen : Form
    {
        private int quizNumber;

        public GameScreen(string text)
        {
            InitializeComponent();
        }

        public GameScreen(string text, int quizNumber) : this(text)
        {
            this.quizNumber = quizNumber;
        }

        public static Quiz _quiz;
        private Timer _timer = new Timer();

        public GameScreen(string name, int quizSelection)
        {
            InitializeComponent();
            CenterToScreen();
            SetupQuiz(name, quizSelection);
        }

        private void SetupQuiz(string name, int quizSelection)
        {
            Player player -new Player(name);
            Text = player.Name + @"'s Quiz";

            switch (quizSelection)
            {
                case 1:
                    _quiz = new CodingQuiz(player, 15);
                    break;
                case 2:
                    _quiz = new ICTQuiz(player, 20);
                    break;
            }

            FirstQuestion();

            SetupTimer();
            _timer.Start();
        }

        private void FirstQuestion()
        {
            questionTextValue.Text = _quiz.Quesions.First().QuestionText;

        }
    }
}
