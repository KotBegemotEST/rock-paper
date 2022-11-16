using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper
{
    public partial class Form1 : Form
    {

        string playerChoice;
        string computerChoice;
        string[] Options = { "R", "P", "S"};
        Random random = new Random();
        int computerScore;
        int playerScore;
        string draw;

        public Form1()
        {
            InitializeComponent();
        }

        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;

            int i = random.Next(0, 3);
            computerChoice = Options[i];

           label5.Text = "Player is: " + UpdateTextandImage(playerChoice, pictureBox1);
           label4.Text = "Computer is: " + UpdateTextandImage(computerChoice, pictureBox2);
           CheckGame();
        }

        private string UpdateTextandImage(string text, PictureBox pic)
        {
            string word = null;

            switch (text)
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.rock1;
                    break;
                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.paper1;
                    break;
                case "S":
                    word = "Scissors";
                    pic.Image = Properties.Resources.scissors1;
                    break;
            }
            return word;
        }

        private void CheckGame()
        {
            if (computerChoice == playerChoice)
            {
                draw = " Draw!";
            }
            else if (playerChoice == "R" && computerChoice == "P" || playerChoice == "S" && computerChoice == "R" || playerChoice == "P" && computerChoice == "S")
            {
                computerScore++;
                draw = null;
            }
            else
            {
                playerScore++;
                draw = null;
            }

            label4.Text = "Computer Score: " + computerScore + Environment.NewLine + draw;
            label5.Text = "Player Score: " + playerScore + Environment.NewLine + draw;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}