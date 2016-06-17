using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsGame
{
    public partial class CrapsGame : Form
    {
        int myPointInt, myDie1Int, myDie2Int;
        //holds the point value

        public CrapsGame()
        {
            InitializeComponent();
        }

        //play the first roll round
        private void playButton_Click(object sender, EventArgs e)
        {
            //initialize values
            pointGroupBox.Text = "Point";
            myPointInt = 0;
            statusLabel.Text = "";
            pointFirstDiePictureBox.Image = null;
            pointSecondDiePictureBox.Image = null;

            int sumInt = RollDice();

            switch(sumInt)
            {
                //winning case of rolling a 7 or an 11
                case 11:
                case 7:
                    statusLabel.Text = "You Win! :)";
                    rollButton.Enabled = false;
                    rollFirstDiePictureBox.Enabled = rollSecondDiePictureBox.Enabled = false; //same as typing them separately
                    break;

                //losing case of rolling a 2, a 3 or a 12
                case 2:
                case 12:
                case 3:
                    statusLabel.Text = "You Lose :(";
                    rollButton.Enabled = false;
                    rollFirstDiePictureBox.Enabled = rollSecondDiePictureBox.Enabled = false; //same as typing them separately
                    break;
                default:
                    myPointInt = sumInt;
                    pointGroupBox.Text = "Point is " + sumInt;
                    statusLabel.Text = "Roll Again.";

                    //set the point dices to the rolled dices
                    DisplayDie(pointFirstDiePictureBox, myDie1Int);
                    DisplayDie(pointSecondDiePictureBox, myDie2Int);

                    //disable the play button, enable the roll buttons
                    playButton.Enabled = false;
                    rollButton.Enabled = rollFirstDiePictureBox.Enabled = rollSecondDiePictureBox.Enabled = true;
                    break;
            }//end switch
        }//end of playButton_Click

        //roll to match pint value
        private void rollButton_Click(object sender, EventArgs e)
        {
            int sumInt = RollDice();

            if(sumInt == myPointInt) //rolled a matching point, player wins
            {
                statusLabel.Text = "You Win! :)";
                rollButton.Enabled = rollFirstDiePictureBox.Enabled = rollSecondDiePictureBox.Enabled = false;
                playButton.Enabled = true;
            }
            else if (sumInt == 7) //rolled a 7, player loses
            {
                statusLabel.Text = "You Lose :(";
                rollButton.Enabled = rollFirstDiePictureBox.Enabled = rollSecondDiePictureBox.Enabled = false;
                playButton.Enabled = true;
            }
        }

        //close the app
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //show about box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Craps Game. Sukhmanbir Kaur", "Craps",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //set the font
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = statusLabel.Font;//initialize dialog
            fontDialog1.ShowDialog();//show dialog
            statusLabel.Font = fontDialog1.Font;//set the new font selected
        }

        //set the color
        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = statusLabel.ForeColor;//initialize dialog
            colorDialog1.ShowDialog();//show color
            statusLabel.ForeColor = colorDialog1.Color;//set the new color
        }

        //display a dice image based on the number passed
        void DisplayDie(PictureBox diePictureBox, int numberInt)
        {
            if(numberInt == 1)
            {
                diePictureBox.Image = Properties.Resources.die1;
            }
            else if(numberInt == 2)
            {
                diePictureBox.Image = Properties.Resources.die2;
            }
            else if (numberInt == 3)
            {
                diePictureBox.Image = Properties.Resources.die3;
            }
            else if (numberInt == 4)
            {
                diePictureBox.Image = Properties.Resources.die4;
            }
            else if (numberInt == 5)
            {
                diePictureBox.Image = Properties.Resources.die5;
            }
            else if (numberInt == 6)
            {
                diePictureBox.Image = Properties.Resources.die6;
            }
        }//end of DisplayDie

        //Simulate a dice roll and return the sum
        int RollDice()
        {
            Random numberRandom = new Random();
            myDie1Int = numberRandom.Next(1, 7);
            myDie2Int = numberRandom.Next(1, 7);
            //obtain two numbers to simulate a dice roll

            DisplayDie(rollFirstDiePictureBox, myDie1Int);
            DisplayDie(rollSecondDiePictureBox, myDie2Int); //display point dice

            return myDie1Int + myDie2Int; //return the sum of both dice
        }
    }
}
