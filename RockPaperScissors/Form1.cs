using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }
        
        string user_choice;
      
        private void rockButton_Click(object sender, EventArgs e)
        {
            //reset if previously played
            this.BackgroundImage = Properties.Resources.rock_paper_scissors;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            outcomeLabel.Text = "";
            outcomeLabel.ForeColor = Color.LightSeaGreen;
            computerChoiceRevealLabel.Visible = false;

            user_choice = "ROCK";
            rockButton.BackColor = Color.CornflowerBlue;
            paperButton.BackColor = Color.LightSteelBlue;
            scissorsButton.BackColor = Color.LightSteelBlue;
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            //reset if previously played
            this.BackgroundImage = Properties.Resources.rock_paper_scissors;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            outcomeLabel.Text = "";
            outcomeLabel.ForeColor = Color.LightSeaGreen;
            computerChoiceRevealLabel.Visible = false;

            user_choice = "PAPER";
            paperButton.BackColor = Color.CornflowerBlue;
            rockButton.BackColor = Color.LightSteelBlue;
            scissorsButton.BackColor = Color.LightSteelBlue;
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            //reset if previously played
            this.BackgroundImage = Properties.Resources.rock_paper_scissors;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            outcomeLabel.Text = "";
            outcomeLabel.ForeColor = Color.LightSeaGreen;
            computerChoiceRevealLabel.Visible = false;

            user_choice = "SCISSORS";
            scissorsButton.BackColor = Color.CornflowerBlue;
            rockButton.BackColor = Color.LightSteelBlue;
            paperButton.BackColor = Color.LightSteelBlue;
        }

        //on play
        private void playButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.rock_paper_scissors;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //generate computer choice
            Random randomNumGen = new Random();
            int randomNum = randomNumGen.Next(1, 4);
            string computer_choice;
            switch (randomNum)
            {
                case 1:
                    computer_choice = "ROCK";
                    break;
                case 2:
                    computer_choice = "PAPER";
                    break;
                case 3:
                    computer_choice = "SCISSORS";
                    break;
                default:
                    computer_choice = "";
                    break;
            }

            //compute winner
            string winningPhrase;
            if (user_choice == "ROCK")
            {
                if (computer_choice == "ROCK")
                {
                    winningPhrase = "It's a tie!";
                }
                else if (computer_choice == "PAPER")
                {
                    winningPhrase = "Computer wins! Paper covers Rock!";
                    outcomeLabel.ForeColor = Color.Black;
                    this.BackgroundImage = Properties.Resources.sadFaceEmoji;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else
                {
                    winningPhrase = "You win! Rock crushes Scissors!";
                    outcomeLabel.ForeColor = Color.Black;
                    this.BackgroundImage = Properties.Resources.smilingFaceEmoji;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            else if (user_choice == "PAPER")
            {
                if (computer_choice == "ROCK")
                {
                    winningPhrase = "You win! Paper covers Rock!";
                    outcomeLabel.ForeColor = Color.Black;
                    this.BackgroundImage = Properties.Resources.smilingFaceEmoji;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else if (computer_choice == "PAPER")
                {
                    winningPhrase = "It's a tie!";
                }
                else
                {
                    winningPhrase = "The computer wins! Scissors cut Paper!";
                    outcomeLabel.ForeColor = Color.Black;
                    this.BackgroundImage = Properties.Resources.sadFaceEmoji;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            else
            {
                if (computer_choice == "ROCK")
                {
                    winningPhrase = "Computer wins! Rock crushes Scissors!";
                    outcomeLabel.ForeColor = Color.Black;
                    this.BackgroundImage = Properties.Resources.sadFaceEmoji;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else if (computer_choice == "PAPER")
                {
                    winningPhrase = "You win! Scissors cut Paper!";
                    outcomeLabel.ForeColor = Color.Black;
                    this.BackgroundImage = Properties.Resources.smilingFaceEmoji;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else
                {
                    winningPhrase = "It's a tie!";
                }
            }

            //display computer choice
            computerChoiceRevealLabel.Visible = true;
            computerChoiceRevealLabel.Text = computer_choice;

            //output game outcome
            outcomeLabel.Text = winningPhrase;
            
            
        }
    }
}
