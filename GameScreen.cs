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
            questionTextValue.Text = _quiz.Questions.First().QuestionText;
            questionLabel.Text = "Question " + (_quiz.CurrentQuestionPosition + 1);

            answer1Button.Text = _quiz.Questions.First().Answers[0];
            answer2Button.Text = _quiz.Questions.First().Answers[1];
            answer3Button.Text = _quiz.Questions.First().Answers[2];
            answer4Button.Text = _quiz.Questions.First().Answers[3];
        }

        private void SetupTimer()
        {
            _timer.Interval = 1000;

            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _quiz.Countdown--;
            timerLbl.Text = "Time: " + _quiz.Countdown;

            if(_quiz.Countdown < 0)
            {
                _timer.Stop();
                EndScreen endScreen = new EndScreen();
                endScreen.Show();
                Hide();
            }
        }

        private void answer1Button_Click(object sender, EventArgs e)
        {
            _quiz.CheckAnswer(0);
            NextQuestion();
        }

        private void answer2Button_Click(object sender, EventArgs e)
        {
            _quiz.CheckAnswer(1);
            NextQuestion();
        }

        private void answer3Button_Click(object sender, EventArgs e)
        {
            _quiz.CheckAnswer(2);
            NextQuestion();
        }

        private void answer4Button_Click(object sender, EventArgs e)
        {
            _quiz.CheckAnswer(3);
            NextQuestion();
        }

        private void NextQuestion()
        {
            if(_quiz.HasNextQuestion)
            {
                _quiz.CurrentQuestionPosition++;

                questionTextValue.Text = _quiz.Questions[_quiz.CurrectQuestionPosition].QuestionText;
                questionLabel.Text = "Question " + (_quiz.CurrentQuestionPosition + 1);
                answer1Button.Text = _quiz.Questions[_quiz.CurrectQuestionPosition].Answers[0];
                answer2Button.Text = _quiz.Questions[_quiz.CurrectQuestionPosition].Answers[1];
                answer3Button.Text = _quiz.Questions[_quiz.CurrectQuestionPosition].Answers[2];
                answer4Button.Text = _quiz.Questions[_quiz.CurrectQuestionPosition].Answers[3];
            }
            else
            {
                EndScreen endScreen = new EndScreen();
                _timer.Stop();
                endScreen.Show();
                Hide();
            }
        }
    }
}
