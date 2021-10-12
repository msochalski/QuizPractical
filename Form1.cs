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
    public class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PopulateNameFromPrevious()
        {
            if(GameScreen._quiz !=null)
            {
                if(GameScreen._quiz.Player.Name.Any())
                {
                    nameTxtBox.Text = GameScreen._quiz.Player.Name;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ICTQuiz_Click(object sender, EventArgs e)
        {
            StartQuiz(2);
        }

        private void CodeQuiz_Click(object sender, EventArgs e)
        {
            StartQuiz(1);
        }

        private void StartQuiz(int quizNumber)
        {
            if (nameTxtBox.Text.Any())
            {
                GameScreen gameScreen = new GameScreen(nameTxtBox.Text, quizNumber);

                gameScreen.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please enter your name", "Player Name missing");
            }
        }

        private void GetLastScore()
        {
            try
            {
                BinaryReader b = new BinaryReader(File.OpenRead("C:\Users\patry\Desktop\Passwords\scores.bin", FileMode.Open));

                int pos = 0;
                int length = (int)b.BaseStream.Length;

                while (pos < length)
                {
                    int score = b.ReadInt32();

                    lastScoreLbl.Text += " " + score;
                    lastScoreLbl.Visible = true;

                    pos += sizeof(int);
                }

                b.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("General Exception: " + ex);
                lastScoreLbl.Visible = false;
            }
        }

        public StartScreen()
        {
            InitializeComponent();
            CenterToScreen();
            PopulateNameFromPrevious();
            GetLastScore();
        }
    }
}
