// created by hannah
//oct 2023
//simple war card game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//header info

namespace War
{
    public partial class Form1 : Form
    {
        //random generator for picking new cards
        Random rangen = new Random();

        //variables to hold card values 
        int playercard, computercard;

        //variables to hold scores, initialized to 0
        int playerscore = 0;
        int computerscore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void warButton_Click(object sender, EventArgs e)
        {
            //clear card back images
            playerCardLabel.Image = null;
            cpuCardLabel.Image = null;

            //get random value between 1 and 10 for both player and cpu
            playercard = rangen.Next(1,11);
            computercard = rangen.Next(1, 11);
            //display card values to the labels
            playerCardLabel.Text = playercard.ToString();
            cpuCardLabel.Text=computercard.ToString();

            // if player value is greater then cpu card
            //    add to player score 
            //    show new player score 
            //    show message saying player won

            // if player value is less then cpu card
            //    add to cpu score
            //    show new cpu score
            //    show message saying cpu won
            if (playercard > computercard)
            {
                playerscore++;
                playerScoreLabel.Text = playerscore.ToString();
                outputLabel.Text = $"YOU WIN!!!";
            }
            // if player value is equal to cpu value 
            //    show message that this round is a tie.
            else if (computercard > playercard)
            {
                computerscore++;
                cpuCardLabel.Text = computerscore.ToString();
                outputLabel.Text = $"YOU lose :(";
            }
            else 
            {
                outputLabel.Text = $"Its a tie";
            }
           
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
