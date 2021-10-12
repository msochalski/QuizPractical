using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizPractical
{
    public partial class EndScreen : Form
    {
        public EndScreen()
        {
            InitializeComponent();
            CenterToScreen();

            scoreLbl.Text = GameScreen._quiz.Player.Name + ", you scored " + GameScreen._quiz.Player.Score + "/" + GameScreen._quiz.Questions.Count + " points";
            AttemptWriteScore();
        }

        private static void AttemptWriteScore()
        {
            try
            {
                BinaryWriter b = new BinaryWriter(File.Open("C:\\Users\\patry\\Desktop\\Passwords\\scores.bin", FileMode.Create));

                b.Write(GameScreen._quiz.Player.Score);
                b.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            GameScreen._quiz.ResetQuiz();
            Form startScreen = new Form();
            startScreen.Show();
            Hide();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
