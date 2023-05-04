using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class DiceGame : Form
    {
        Dice roll;
        int round1 = 12;
        int round2 = 13;
        int round3 = 13;
        int round4 = 13;
        int round5 = 13;
        int upperTotal = 0;
        int lowerTotal = 0;
        int grandTotal = 0;
        public DiceGame()
        {
            InitializeComponent();
            roll = new Dice();
            txtDiceReminder.ReadOnly = true;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            var instructions = MessageBox.Show("\t\t***SINGLE PLAYER YAHTZEE*** \n\n\t\t------INSTRUCTIONS------" +
                "\n\nThe game consists of a number of rounds." +
                " In each round, the player gets to roll the die." +
                "The Yahtzee scorecard contains 13 different category boxes and in each round, after the third roll, " +
                "the player must choose one of these categories. The score entered in the box depends on how well the five " +
                "dice match the scoring rule for the category. Details of the scoring rules for each category are given below. " +
                "As an example, one of the categories is called Three of a Kind. " +
                "The scoring rule for this category means that you, the player only scores if at least three of the five dice are the same " +
                "value. The game is completed after 13 rounds by the player, with each of the 13 boxes filled. " +
                "The total score is calculated by summing all thirteen boxes, together with any bonuses." + 
                "\n\n***MAKE SURE YOU CLICK WHICH BOX TO PUT YOUR SCORE IN BEFORE YOU ROLL AGAIN OR THAT ROLL WILL BE CONSIDERED As A PASS " +
                "BUT YOU STILL LOSE THAT ROUND AS PART OF THE GAME***");
            var guide = MessageBox.Show("First roll to start the game " + roll.Rolls());
            txtDiceReminder.Text = roll.Rolls().Replace("\n", Environment.NewLine);
            txtDiceReminder.Visible = true;
            btnPlay.Visible = false;
            btnRoll.Visible = true;
            btnExit.Visible = true;
            lblTitle.Visible = false;
            lblSecondTitle.Visible = false;
            picChallenge1.Visible = true;
            picChallenge2.Visible = true;
            picScoreBoard.Visible = true;
            picCup.Visible = true;
            picScoreBoard.SendToBack();
            
            if (roll.Aces() != 0)
            {
                picDice1.Visible = true;
            }
            if (roll.Twos() != 0)
            {
                picDice2.Visible = true;
            }
            if (roll.Threes() != 0)
            {
                picDice3.Visible = true;
            }
            if (roll.Fours() != 0)
            {
                picDice4.Visible = true;
            }
            if (roll.Fives() != 0)
            {
                picDice5.Visible = true;
            }
            if (roll.Sixes() != 0)
            {
                picDice6.Visible = true;
            }

            //Labels
            //Each label is coordinated with a space on the scoreboard
            //Aces are below:
            lblAces1.Visible = true;
            lblAces2.Visible = true;
            lblAces3.Visible = true;
            lblAces4.Visible = true;
            lblAces5.Visible = true;

            //Twos are below:
            lblTwos1.Visible = true;
            lblTwos2.Visible = true;
            lblTwos3.Visible = true;
            lblTwos4.Visible = true;
            lblTwos5.Visible = true;

            //Threes are below:
            lblThrees1.Visible = true;
            lblThrees2.Visible = true;
            lblThrees3.Visible = true;
            lblThrees4.Visible = true;
            lblThrees5.Visible = true;

            //Fours are below:
            lblFours1.Visible = true;
            lblFours2.Visible = true;
            lblFours3.Visible = true;
            lblFours4.Visible = true;
            lblFours5.Visible = true;

            //Fives are below:
            lblFives1.Visible = true;
            lblFives2.Visible = true;
            lblFives3.Visible = true;
            lblFives4.Visible = true;
            lblFives5.Visible = true;

            //Sixes are below:
            lblSixes1.Visible = true;
            lblSixes2.Visible = true;
            lblSixes3.Visible = true;
            lblSixes4.Visible = true;
            lblSixes5.Visible = true;

            //Upper total scores:
            lblTotalScore1a.Visible = true;
            lblTotalScore1b.Visible = true;
            lblTotalScore1c.Visible = true;
            lblTotalScore1d.Visible = true;
            lblTotalScore1e.Visible = true;

            //Upper bonuses:
            lblBonus1.Visible = true;
            lblBonus2.Visible = true;
            lblBonus3.Visible = true;
            lblBonus4.Visible = true;
            lblBonus5.Visible = true;

            //Total Score of Upper:
            lblTotalScore2a.Visible = true;
            lblTotalScore2b.Visible = true;
            lblTotalScore2c.Visible = true;
            lblTotalScore2d.Visible = true;
            lblTotalScore2e.Visible = true;

            //3 Of a Kind below:
            lbl3OfAKind1.Visible = true;
            lbl3OfAKind2.Visible = true;
            lbl3OfAKind3.Visible = true;
            lbl3OfAKind4.Visible = true;
            lbl3OfAKind5.Visible = true;

            //4 Of a Kind below:
            lbl4OfAKind1.Visible = true;
            lbl4OfAKind2.Visible = true;
            lbl4OfAKind3.Visible = true;
            lbl4OfAKind4.Visible = true;
            lbl4OfAKind5.Visible = true;

            //Full house below:
            lblFullHouse1.Visible = true;
            lblFullHouse2.Visible = true;
            lblFullHouse3.Visible = true;
            lblFullHouse4.Visible = true;
            lblFullHouse5.Visible = true;

            //Small straight below:
            lblSS1.Visible = true;
            lblSS2.Visible = true;
            lblSS3.Visible = true;
            lblSS4.Visible = true;
            lblSS5.Visible = true;

            //Large straight below:
            lblLS1.Visible = true;
            lblLS2.Visible = true;
            lblLS3.Visible = true;
            lblLS4.Visible = true;
            lblLS5.Visible = true;

            //Yahtzee below:
            lblYahtzee1.Visible = true;
            lblYahtzee2.Visible = true;
            lblYahtzee3.Visible = true;
            lblYahtzee4.Visible = true;
            lblYahtzee5.Visible = true;

            //Chance below:
            lblChance1.Visible = true;
            lblChance2.Visible = true;
            lblChance3.Visible = true;
            lblChance4.Visible = true;
            lblChance5.Visible = true;

            //Yahtzee bonus below:
            lblYahtzeeBonus1.Visible = true;
            lblYahtzeeBonus2.Visible = true;
            lblYahtzeeBonus3.Visible = true;
            lblYahtzeeBonus4.Visible = true;
            lblYahtzeeBonus5.Visible = true;

            //Lower section total below:
            lblTotalScore3a.Visible = true;
            lblTotalScore3b.Visible = true;
            lblTotalScore3c.Visible = true;
            lblTotalScore3d.Visible = true;
            lblTotalScore3e.Visible = true;

            //Upper section total below:
            lblTotalScore4a.Visible = true;
            lblTotalScore4b.Visible = true; 
            lblTotalScore4c.Visible = true;
            lblTotalScore4d.Visible = true;
            lblTotalScore4e.Visible = true;

            //Grand total:
            lblTotalOverall1.Visible = true;
            lblTotalOverall2.Visible = true;
            lblTotalOverall3.Visible = true;
            lblTotalOverall4.Visible = true;
            lblTotalOverall5.Visible = true;
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            roll = new Dice();
            var guide = MessageBox.Show(roll.Rolls());
            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;
            picDice6.Visible = false;
            txtDiceReminder.Visible = true;

            //Makes the dice that are rolled show
            //Since there is only one picture for a specific dice, duplicate dice DON'T SHOW
            if (roll.Aces() != 0)
            {
                picDice1.Visible = true;
            }
            if(roll.Twos() != 0)
            {
                picDice2.Visible = true;
            }
            if(roll.Threes() != 0)
            {
                picDice3.Visible = true;
            }
            if(roll.Fours() != 0)
            {
                picDice4.Visible = true;
            }
            if(roll.Fives() != 0)
            {
                picDice5.Visible = true;
            }
            if(roll.Sixes() != 0)
            {
                picDice6.Visible = true;
            }
            if(round1 > -1)
            {
                round1 = round1 - 1;
            }
            if(round1 == 0)
            {
                if(upperTotal >= 63)
                {
                    upperTotal = upperTotal + 35;
                    grandTotal = upperTotal + lowerTotal;
                    lblTotalScore2a.Text = upperTotal.ToString();
                    lblTotalScore4a.Text = upperTotal.ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                    lblTotalOverall1.Text = grandTotal.ToString();
                }
                else
                {
                    grandTotal = upperTotal + lowerTotal;
                    lblTotalScore2a.Text = upperTotal.ToString();
                    lblTotalScore4a.Text = upperTotal.ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                    lblTotalOverall1.Text = grandTotal.ToString();
                }
                var round1End = MessageBox.Show("That completes game 1 on to game 2");
                upperTotal = 0;
                lowerTotal = 0;
                grandTotal = 0;
            }
            if(round1 <= -1 && round2 > -1)
            {
                round2 = round2 - 1;
            }
            if (round2 == 0)
            {
                if (upperTotal >= 63)
                {
                    upperTotal = upperTotal + 35;
                    grandTotal = upperTotal + lowerTotal;
                    lblTotalScore2b.Text = upperTotal.ToString();
                    lblTotalScore4b.Text = upperTotal.ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                    lblTotalOverall2.Text = grandTotal.ToString();
                }
                else
                {
                    grandTotal = upperTotal + lowerTotal;
                    lblTotalScore2b.Text = upperTotal.ToString();
                    lblTotalScore4b.Text = upperTotal.ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                    lblTotalOverall2.Text = grandTotal.ToString();
                }
                var round2End = MessageBox.Show("That completes game 2 on to game 3");
                upperTotal = 0;
                lowerTotal = 0;
                grandTotal = 0;
            }
            if (round1 <= -1 && round2 <= -1 && round3 > -1 )
            {
                round3 = round3 - 1;
            }
            if (round3 == 0)
            {
                if (upperTotal >= 63)
                {
                    upperTotal = upperTotal + 35;
                    grandTotal = upperTotal + lowerTotal;
                    lblTotalScore2c.Text = upperTotal.ToString();
                    lblTotalScore4c.Text = upperTotal.ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                    lblTotalOverall3.Text = grandTotal.ToString();
                }
                else
                {
                    grandTotal = upperTotal + lowerTotal;
                    lblTotalScore2c.Text = upperTotal.ToString();
                    lblTotalScore4c.Text = upperTotal.ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                    lblTotalOverall3.Text = grandTotal.ToString();
                }
                var round3End = MessageBox.Show("That completes game 3 on to game 4");
                upperTotal = 0;
                lowerTotal = 0;
                grandTotal = 0;
            }
            if (round1 <= -1 && round2 <= -1 && round3 <= -1 && round4 > -1)
            {
                round4 = round4 - 1;
            }
            if (round4 == 0)
            {
                if (upperTotal >= 63)
                {
                    upperTotal = upperTotal + 35;
                    grandTotal = upperTotal + lowerTotal;
                    lblTotalScore2d.Text = upperTotal.ToString();
                    lblTotalScore4d.Text = upperTotal.ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                    lblTotalOverall4.Text = grandTotal.ToString();
                }
                else
                {
                    grandTotal = upperTotal + lowerTotal;
                    lblTotalScore2d.Text = upperTotal.ToString();
                    lblTotalScore4d.Text = upperTotal.ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                    lblTotalOverall4.Text = grandTotal.ToString();
                }
                var round4End = MessageBox.Show("That completes game 4 on to game 5");
                upperTotal = 0;
                lowerTotal = 0;
                grandTotal = 0;
            }
            if (round1 <= -1 && round2 <= -1 && round3 <= -1 && round4 <= -1 && round5 > -1)
            {
                round5 = round5 - 1;
            }
            if (round5 == -1)
            {
                if (upperTotal >= 63)
                {
                    upperTotal = upperTotal + 35;
                    grandTotal = upperTotal + lowerTotal;
                    lblTotalScore2e.Text = upperTotal.ToString();
                    lblTotalScore4e.Text = upperTotal.ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                    lblTotalOverall5.Text = grandTotal.ToString();
                }
                else
                {
                    grandTotal = upperTotal + lowerTotal;
                    lblTotalScore2e.Text = upperTotal.ToString();
                    lblTotalScore4e.Text = upperTotal.ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                    lblTotalOverall5.Text = grandTotal.ToString();
                }
                var round3End = MessageBox.Show("That completes game 5. Thanks for playing!");
                upperTotal = 0;
                lowerTotal = 0;
                grandTotal = 0;
                picDice1.Visible = false;
                picDice2.Visible = false;
                picDice3.Visible = false;
                picDice4.Visible = false;
                picDice5.Visible = false;
                picDice6.Visible = false;
                txtDiceReminder.Visible = false;

                lblAces1.Text = "0";
                lblAces2.Text = "0";
                lblAces3.Text = "0";
                lblAces4.Text = "0";
                lblAces5.Text = "0";

                lblTwos1.Text = "0";
                lblTwos2.Text = "0";
                lblTwos3.Text = "0";
                lblTwos4.Text = "0";
                lblTwos5.Text = "0";

                lblThrees1.Text = "0";
                lblThrees2.Text = "0";
                lblThrees3.Text = "0";
                lblThrees4.Text = "0";
                lblThrees5.Text = "0";

                lblFours1.Text = "0";
                lblFours2.Text = "0";
                lblFours3.Text = "0";
                lblFours4.Text = "0";
                lblFours5.Text = "0";

                lblFives1.Text = "0";
                lblFives2.Text = "0";
                lblFives3.Text = "0";
                lblFives4.Text = "0";
                lblFives5.Text = "0";

                lblSixes1.Text = "0";
                lblSixes2.Text = "0";
                lblSixes3.Text = "0";
                lblSixes4.Text = "0";
                lblSixes5.Text = "0";

                lblTotalScore1a.Text = "0";
                lblTotalScore1b.Text = "0";
                lblTotalScore1c.Text = "0";
                lblTotalScore1d.Text = "0";
                lblTotalScore1e.Text = "0";

                lblBonus1.Text = "0";
                lblBonus2.Text = "0";
                lblBonus3.Text = "0";
                lblBonus4.Text = "0";
                lblBonus5.Text = "0";

                lblTotalScore2a.Text = "0";
                lblTotalScore2b.Text = "0";
                lblTotalScore2c.Text = "0";
                lblTotalScore2d.Text = "0";
                lblTotalScore2e.Text = "0";

                lbl3OfAKind1.Text = "0";
                lbl3OfAKind2.Text = "0";
                lbl3OfAKind3.Text = "0";
                lbl3OfAKind4.Text = "0";
                lbl3OfAKind5.Text = "0";

                lbl4OfAKind1.Text = "0";
                lbl4OfAKind2.Text = "0";
                lbl4OfAKind3.Text = "0";
                lbl4OfAKind4.Text = "0";
                lbl4OfAKind5.Text = "0";

                lblFullHouse1.Text = "0";
                lblFullHouse2.Text = "0";
                lblFullHouse3.Text = "0";
                lblFullHouse4.Text = "0";
                lblFullHouse5.Text = "0";

                lblSS1.Text = "0";
                lblSS2.Text = "0";
                lblSS3.Text = "0";
                lblSS4.Text = "0";
                lblSS5.Text = "0";

                lblLS1.Text = "0";
                lblLS2.Text = "0";
                lblLS3.Text = "0";
                lblLS4.Text = "0";
                lblLS5.Text = "0";

                lblYahtzee1.Text = "0";
                lblYahtzee2.Text = "0";
                lblYahtzee3.Text = "0";
                lblYahtzee4.Text = "0";
                lblYahtzee5.Text = "0";

                lblChance1.Text = "0";
                lblChance2.Text = "0";
                lblChance3.Text = "0";
                lblChance4.Text = "0";
                lblChance5.Text = "0";

                lblYahtzeeBonus1.Text = "0";
                lblYahtzeeBonus2.Text = "0";
                lblYahtzeeBonus3.Text = "0";
                lblYahtzeeBonus4.Text = "0";
                lblYahtzeeBonus5.Text = "0";

                lblTotalScore3a.Text = "0";
                lblTotalScore3b.Text = "0";
                lblTotalScore3c.Text = "0";
                lblTotalScore3d.Text = "0";
                lblTotalScore3e.Text = "0";

                lblTotalScore4a.Text = "0";
                lblTotalScore4b.Text = "0";
                lblTotalScore4c.Text = "0";
                lblTotalScore4d.Text = "0";
                lblTotalScore4e.Text = "0";

                lblTotalOverall1.Text = "0";
                lblTotalOverall2.Text = "0";
                lblTotalOverall3.Text = "0";
                lblTotalOverall4.Text = "0";
                lblTotalOverall5.Text = "0";

                //Resetting the values for the rounds
                round1 = 13;
                round2 = 13;
                round3 = 13;
                round4 = 13;
                round5 = 13;
            }
            txtDiceReminder.Text = roll.Rolls().Replace("\n", Environment.NewLine); ;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = true;
            btnRoll.Visible = false;
            btnExit.Visible = false;
            lblTitle.Visible = true;
            txtDiceReminder.Visible = false;
            lblSecondTitle.Visible = true;
            picChallenge1.Visible = false;
            picChallenge2.Visible = false;
            picScoreBoard.Visible = false;
            picCup.Visible = false;

            picDice1.Visible = false;
            picDice2.Visible = false;
            picDice3.Visible = false;
            picDice4.Visible = false;
            picDice5.Visible = false;
            picDice6.Visible = false;

            //Labels
            //Each label is coordinated with a space on the scoreboard
            //Aces are below:
            lblAces1.Visible = false;
            lblAces2.Visible = false;
            lblAces3.Visible = false;
            lblAces4.Visible = false;
            lblAces5.Visible = false;
            lblAces1.Text = "0";
            lblAces2.Text = "0";
            lblAces3.Text = "0";
            lblAces4.Text = "0";
            lblAces5.Text = "0";

            //Twos are below:
            lblTwos1.Visible = false;
            lblTwos2.Visible = false;
            lblTwos3.Visible = false;
            lblTwos4.Visible = false;
            lblTwos5.Visible = false;
            lblTwos1.Text = "0";
            lblTwos2.Text = "0";
            lblTwos3.Text = "0";
            lblTwos4.Text = "0";
            lblTwos5.Text = "0";

            //Threes are below:
            lblThrees1.Visible = false;
            lblThrees2.Visible = false;
            lblThrees3.Visible = false;
            lblThrees4.Visible = false;
            lblThrees5.Visible = false;
            lblThrees1.Text = "0";
            lblThrees2.Text = "0";
            lblThrees3.Text = "0";
            lblThrees4.Text = "0";
            lblThrees5.Text = "0";

            //Fours are below:
            lblFours1.Visible = false;
            lblFours2.Visible = false;
            lblFours3.Visible = false;
            lblFours4.Visible = false;
            lblFours5.Visible = false;
            lblFours1.Text = "0";
            lblFours2.Text = "0";
            lblFours3.Text = "0";
            lblFours4.Text = "0";
            lblFours5.Text = "0";

            //Fives are below:
            lblFives1.Visible = false;
            lblFives2.Visible = false;
            lblFives3.Visible = false;
            lblFives4.Visible = false;
            lblFives5.Visible = false;
            lblFives1.Text = "0";
            lblFives2.Text = "0";
            lblFives3.Text = "0";
            lblFives4.Text = "0";
            lblFives5.Text = "0";

            //Sixes are below:
            lblSixes1.Visible = false;
            lblSixes2.Visible = false;
            lblSixes3.Visible = false;
            lblSixes4.Visible = false;
            lblSixes5.Visible = false;
            lblSixes1.Text = "0";
            lblSixes2.Text = "0";
            lblSixes3.Text = "0";
            lblSixes4.Text = "0";
            lblSixes5.Text = "0";

            //Upper total scores:
            lblTotalScore1a.Visible = false;
            lblTotalScore1b.Visible = false;
            lblTotalScore1c.Visible = false;
            lblTotalScore1d.Visible = false;
            lblTotalScore1e.Visible = false;
            lblTotalScore1a.Text = "0";
            lblTotalScore1b.Text = "0";
            lblTotalScore1c.Text = "0";
            lblTotalScore1d.Text = "0";
            lblTotalScore1e.Text = "0";

            //Upper bonuses:
            lblBonus1.Visible = false;
            lblBonus2.Visible = false;
            lblBonus3.Visible = false;
            lblBonus4.Visible = false;
            lblBonus5.Visible = false;
            lblBonus1.Text = "0";
            lblBonus2.Text = "0";
            lblBonus3.Text = "0";
            lblBonus4.Text = "0";
            lblBonus5.Text = "0";

            //Total Score of Upper:
            lblTotalScore2a.Visible = false;
            lblTotalScore2b.Visible = false;
            lblTotalScore2c.Visible = false;
            lblTotalScore2d.Visible = false;
            lblTotalScore2e.Visible = false;
            lblTotalScore2a.Text = "0";
            lblTotalScore2b.Text = "0";
            lblTotalScore2c.Text = "0";
            lblTotalScore2d.Text = "0";
            lblTotalScore2e.Text = "0";

            //3 Of a Kind below:
            lbl3OfAKind1.Visible = false;
            lbl3OfAKind2.Visible = false;
            lbl3OfAKind3.Visible = false;
            lbl3OfAKind4.Visible = false;
            lbl3OfAKind5.Visible = false;
            lbl3OfAKind1.Text = "0";
            lbl3OfAKind2.Text = "0";
            lbl3OfAKind3.Text = "0";
            lbl3OfAKind4.Text = "0";
            lbl3OfAKind5.Text = "0";

            //4 Of a Kind below:
            lbl4OfAKind1.Visible = false;
            lbl4OfAKind2.Visible = false;
            lbl4OfAKind3.Visible = false;
            lbl4OfAKind4.Visible = false;
            lbl4OfAKind5.Visible = false;
            lbl4OfAKind1.Text = "0";
            lbl4OfAKind2.Text = "0";
            lbl4OfAKind3.Text = "0";
            lbl4OfAKind4.Text = "0";
            lbl4OfAKind5.Text = "0";

            //Full house below:
            lblFullHouse1.Visible = false;
            lblFullHouse2.Visible = false;
            lblFullHouse3.Visible = false;
            lblFullHouse4.Visible = false;
            lblFullHouse5.Visible = false;
            lblFullHouse1.Text = "0";
            lblFullHouse2.Text = "0";
            lblFullHouse3.Text = "0";
            lblFullHouse4.Text = "0";
            lblFullHouse5.Text = "0";

            //Small straight below:
            lblSS1.Visible = false;
            lblSS2.Visible = false;
            lblSS3.Visible = false;
            lblSS4.Visible = false;
            lblSS5.Visible = false;
            lblSS1.Text = "0";
            lblSS2.Text = "0";
            lblSS3.Text = "0";
            lblSS4.Text = "0";
            lblSS5.Text = "0";

            //Large straight below:
            lblLS1.Visible = false;
            lblLS2.Visible = false;
            lblLS3.Visible = false;
            lblLS4.Visible = false;
            lblLS5.Visible = false;
            lblLS1.Text = "0";
            lblLS2.Text = "0";
            lblLS3.Text = "0";
            lblLS4.Text = "0";
            lblLS5.Text = "0";

            //Yahtzee below:
            lblYahtzee1.Visible = false;
            lblYahtzee2.Visible = false;
            lblYahtzee3.Visible = false;
            lblYahtzee4.Visible = false;
            lblYahtzee5.Visible = false;
            lblYahtzee1.Text = "0";
            lblYahtzee2.Text = "0";
            lblYahtzee3.Text = "0";
            lblYahtzee4.Text = "0";
            lblYahtzee5.Text = "0";

            //Chance below:
            lblChance1.Visible = false;
            lblChance2.Visible = false;
            lblChance3.Visible = false;
            lblChance4.Visible = false;
            lblChance5.Visible = false;
            lblChance1.Text = "0";
            lblChance2.Text = "0";
            lblChance3.Text = "0";
            lblChance4.Text = "0";
            lblChance5.Text = "0";

            //Yahtzee bonus below:
            lblYahtzeeBonus1.Visible = false;
            lblYahtzeeBonus2.Visible = false;
            lblYahtzeeBonus3.Visible = false;
            lblYahtzeeBonus4.Visible = false;
            lblYahtzeeBonus5.Visible = false;
            lblYahtzeeBonus1.Text = "0";
            lblYahtzeeBonus2.Text = "0";
            lblYahtzeeBonus3.Text = "0";
            lblYahtzeeBonus4.Text = "0";
            lblYahtzeeBonus5.Text = "0";

            //Lower section total below:
            lblTotalScore3a.Visible = false;
            lblTotalScore3b.Visible = false;
            lblTotalScore3c.Visible = false;
            lblTotalScore3d.Visible = false;
            lblTotalScore3e.Visible = false;
            lblTotalScore3a.Text = "0";
            lblTotalScore3b.Text = "0";
            lblTotalScore3c.Text = "0";
            lblTotalScore3d.Text = "0";
            lblTotalScore3e.Text = "0";

            //Upper section total below:
            lblTotalScore4a.Visible = false;
            lblTotalScore4b.Visible = false;
            lblTotalScore4c.Visible = false;
            lblTotalScore4d.Visible = false;
            lblTotalScore4e.Visible = false;
            lblTotalScore4a.Text = "0";
            lblTotalScore4b.Text = "0";
            lblTotalScore4c.Text = "0";
            lblTotalScore4d.Text = "0";
            lblTotalScore4e.Text = "0";

            //Grand total:
            lblTotalOverall1.Visible = false;
            lblTotalOverall2.Visible = false;
            lblTotalOverall3.Visible = false;
            lblTotalOverall4.Visible = false;
            lblTotalOverall5.Visible = false;
            lblTotalOverall1.Text = "0";
            lblTotalOverall2.Text = "0";
            lblTotalOverall3.Text = "0";
            lblTotalOverall4.Text = "0";
            lblTotalOverall5.Text = "0";

            //Resetting the values for the rounds
            round1 = 13;
            round2 = 13;
            round3 = 13;
            round4 = 13;
            round5 = 13;
        }

        //---ALL EVENTS BELOW RESPOND TO 1ST COLUMN LABELS---
        private void lblAces1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblAces1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblAces1.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Aces();
                    lblAces1.Text = roll.Aces().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Aces();
                    lblAces1.Text = roll.Aces().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
            }
            
        }

        private void lblTwos1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblTwos1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1) { 
                if (lblTwos1.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Twos();
                    lblTwos1.Text = roll.Twos().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Twos();
                    lblTwos1.Text = roll.Twos().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
            }
        }

        private void lblThrees1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblThrees1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblThrees1.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Threes();
                    lblThrees1.Text = roll.Threes().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Threes();
                    lblThrees1.Text = roll.Threes().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
            }
        }

        private void lblFours1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFours1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblFours1.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Fours();
                    lblFours1.Text = roll.Fours().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Fours();
                    lblFours1.Text = roll.Fours().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
            }
        }

        private void lblFives1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFives1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblFives1.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Fives();
                    lblFives1.Text = roll.Fives().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Fives();
                    lblFives1.Text = roll.Fives().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
            }
        }

        private void lblSixes1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblSixes1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblSixes1.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Sixes();
                    lblSixes1.Text = roll.Sixes().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Sixes();
                    lblSixes1.Text = roll.Sixes().ToString();
                    lblTotalScore1a.Text = upperTotal.ToString();
                }
            }
        }

        private void lbl3OfAKind1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbl3OfAKind1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lbl3OfAKind1.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.ThreeOfAKind();
                    lbl3OfAKind1.Text = roll.ThreeOfAKind().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.ThreeOfAKind();
                    lbl3OfAKind1.Text = roll.ThreeOfAKind().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
            }
        }

        private void lbl4OfAKind1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbl4OfAKind1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lbl4OfAKind1.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FourOfAKind();
                    lbl4OfAKind1.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FourOfAKind();
                    lbl4OfAKind1.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblFullHouse1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFullHouse1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblFullHouse1.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FullHouse();
                    lblFullHouse1.Text = roll.FullHouse().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FullHouse();
                    lblFullHouse1.Text = roll.FullHouse().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblSS1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblSS1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblSS1.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.SmallStraight();
                    lblSS1.Text = roll.SmallStraight().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.SmallStraight();
                    lblSS1.Text = roll.SmallStraight().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblLS1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblLS1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblLS1.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.LargeStraight();
                    lblLS1.Text = roll.LargeStraight().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.LargeStraight();
                    lblLS1.Text = roll.LargeStraight().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblYahtzee1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblYahtzee1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblYahtzee1.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.Yahtzee();
                    lblYahtzee1.Text = roll.Yahtzee().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.Yahtzee();
                    lblYahtzee1.Text = roll.Yahtzee().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblChance1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblChance1.Text);
            if (round1 >= 0 && round2 >= -1 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblChance1.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.Chance();
                    lblChance1.Text = roll.Chance().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.Chance();
                    lblChance1.Text = roll.Chance().ToString();
                    lblTotalScore3a.Text = lowerTotal.ToString();
                }
            }
        }


        //---ALL EVENTS BELOW RESPOND TO 2ND COLUMN LABELS---- 
        private void lblAces2_Click(object sender, EventArgs e)
        {
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                int temp = int.Parse(lblAces2.Text);
                if (lblAces2.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Aces();
                    lblAces2.Text = roll.Aces().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Aces();
                    lblAces2.Text = roll.Aces().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
            }
        }

        private void lblTwos2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblTwos2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            { 
                if (lblTwos2.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Twos();
                    lblTwos2.Text = roll.Twos().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Twos();
                    lblTwos2.Text = roll.Twos().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
            }
        }

        private void lblThrees2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblThrees2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblThrees2.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Threes();
                    lblThrees2.Text = roll.Threes().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Threes();
                    lblThrees2.Text = roll.Threes().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
            }
        }

        private void lblFours2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFours2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblFours2.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Fours();
                    lblFours2.Text = roll.Fours().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Fours();
                    lblFours2.Text = roll.Fours().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
            }
        }

        private void lblFives2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFives2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblFives2.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Fives();
                    lblFives2.Text = roll.Fives().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Fives();
                    lblFives2.Text = roll.Fives().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
            }
        }

        private void lblSixes2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblSixes2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblSixes2.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Sixes();
                    lblSixes2.Text = roll.Sixes().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Sixes();
                    lblSixes2.Text = roll.Sixes().ToString();
                    lblTotalScore1b.Text = upperTotal.ToString();
                }
            }
        }

        private void lbl3OfAKind2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbl3OfAKind2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lbl3OfAKind2.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.ThreeOfAKind();
                    lbl3OfAKind2.Text = roll.ThreeOfAKind().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.ThreeOfAKind();
                    lbl3OfAKind2.Text = roll.ThreeOfAKind().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
            }
        }

        private void lbl4OfAKind2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbl4OfAKind2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lbl4OfAKind2.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FourOfAKind();
                    lbl4OfAKind2.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FourOfAKind();
                    lbl4OfAKind2.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblFullHouse2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFullHouse2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblFullHouse2.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FullHouse();
                    lblFullHouse2.Text = roll.FullHouse().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FullHouse();
                    lblFullHouse2.Text = roll.FullHouse().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblSS2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblSS2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblSS2.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.SmallStraight();
                    lblSS2.Text = roll.SmallStraight().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.SmallStraight();
                    lblSS2.Text = roll.SmallStraight().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblLS2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblLS2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblLS2.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.LargeStraight();
                    lblLS2.Text = roll.LargeStraight().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.LargeStraight();
                    lblLS2.Text = roll.LargeStraight().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblYahtzee2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblYahtzee2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblYahtzee2.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.Yahtzee();
                    lblYahtzee2.Text = roll.Yahtzee().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.Yahtzee();
                    lblYahtzee2.Text = roll.Yahtzee().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblChance2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblChance2.Text);
            if (round1 <= 0 && round3 >= -1 && round4 >= -1 && round5 >= -1)
            {
                if (lblChance2.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.Chance();
                    lblChance2.Text = roll.Chance().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.Chance();
                    lblChance2.Text = roll.Chance().ToString();
                    lblTotalScore3b.Text = lowerTotal.ToString();
                }
            }
        }
        //---ALL EVENTS BELOW RESPOND TO 3RD COLUMN LABELS---
        private void lblAces3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblAces3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblAces3.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Aces();
                    lblAces3.Text = roll.Aces().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Aces();
                    lblAces3.Text = roll.Aces().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
            }
        }

        private void lblTwos3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblTwos3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblTwos3.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Twos();
                    lblTwos3.Text = roll.Twos().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Twos();
                    lblTwos3.Text = roll.Twos().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
            }
        }

        private void lblThrees3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblThrees3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblThrees3.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Threes();
                    lblThrees3.Text = roll.Threes().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Threes();
                    lblThrees3.Text = roll.Threes().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
            }
        }

        private void lblFours3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFours3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblFours3.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Fours();
                    lblFours3.Text = roll.Fours().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Fours();
                    lblFours3.Text = roll.Fours().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
            }
        }

        private void lblFives3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFives3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblFives3.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Fives();
                    lblFives3.Text = roll.Fives().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Fives();
                    lblFives3.Text = roll.Fives().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
            }
        }

        private void lblSixes3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblSixes3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblSixes3.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Sixes();
                    lblSixes3.Text = roll.Sixes().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Sixes();
                    lblSixes3.Text = roll.Sixes().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
            }
        }

        private void lbl3OfAKind3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbl3OfAKind3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lbl3OfAKind3.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.ThreeOfAKind();
                    lbl3OfAKind3.Text = roll.ThreeOfAKind().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.ThreeOfAKind();
                    lbl3OfAKind3.Text = roll.ThreeOfAKind().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
            }
        }

        private void lbl4OfAKind3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbl4OfAKind3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lbl4OfAKind3.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FourOfAKind();
                    lbl4OfAKind3.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FourOfAKind();
                    lbl4OfAKind3.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblFullHouse3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFullHouse3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblFullHouse3.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FullHouse();
                    lblFullHouse3.Text = roll.FullHouse().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FullHouse();
                    lblFullHouse3.Text = roll.FullHouse().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblSS3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblSS3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblSS3.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.SmallStraight();
                    lblSS3.Text = roll.SmallStraight().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.SmallStraight();
                    lblSS3.Text = roll.SmallStraight().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblLS3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblLS3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblLS3.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.LargeStraight();
                    lblLS3.Text = roll.LargeStraight().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.LargeStraight();
                    lblLS3.Text = roll.LargeStraight().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblYahtzee3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblYahtzee3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblYahtzee3.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.Yahtzee();
                    lblYahtzee3.Text = roll.Yahtzee().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.Yahtzee();
                    lblYahtzee3.Text = roll.Yahtzee().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblChance3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblChance3.Text);
            if (round1 <= 0 && round2 <= 0 && round4 >= -1 && round5 >= -1)
            {
                if (lblChance3.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.Chance();
                    lblChance3.Text = roll.Chance().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.Chance();
                    lblChance3.Text = roll.Chance().ToString();
                    lblTotalScore3c.Text = lowerTotal.ToString();
                }
            }
        }

        //---ALL EVENTS BELOW RESPOND TO 4TH COLUMN LABELS---
        private void lblAces4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblAces4.Text);
            if (round1 <= 0 && round2 <= -0 && round3 <= 0 && round5 >= -1)
            {
                if (lblAces4.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Aces();
                    lblAces4.Text = roll.Aces().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Aces();
                    lblAces4.Text = roll.Aces().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
            }
        }

        private void lblTwos4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblTwos4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lblTwos4.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Twos();
                    lblTwos4.Text = roll.Twos().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Twos();
                    lblTwos4.Text = roll.Twos().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
            }
        }

        private void lblThrees4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblThrees4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lblThrees4.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Threes();
                    lblThrees4.Text = roll.Threes().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Threes();
                    lblThrees4.Text = roll.Threes().ToString();
                    lblTotalScore1c.Text = upperTotal.ToString();
                }
            }
        }

        private void lblFours4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFours4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lblFours4.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Fours();
                    lblFours4.Text = roll.Fours().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Fours();
                    lblFours4.Text = roll.Fours().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
            }
        }

        private void lblFives4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFives4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lblFives4.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Fives();
                    lblFives4.Text = roll.Fives().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Fives();
                    lblFives4.Text = roll.Fives().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
            }
        }

        private void lblSixes4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblSixes4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lblSixes4.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Sixes();
                    lblSixes4.Text = roll.Sixes().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Sixes();
                    lblSixes4.Text = roll.Sixes().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
            }
        }

        private void lbl3OfAKind4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbl3OfAKind4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= -1 && round5 >= -1)
            {
                if (lbl3OfAKind4.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FourOfAKind();
                    lbl3OfAKind4.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FourOfAKind();
                    lbl3OfAKind4.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
            }
        }

        private void lbl4OfAKind4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbl4OfAKind4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lbl4OfAKind4.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FourOfAKind();
                    lbl4OfAKind4.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FourOfAKind();
                    lbl4OfAKind4.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblFullHouse4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFullHouse4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lblFullHouse4.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FullHouse();
                    lblFullHouse4.Text = roll.FullHouse().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FullHouse();
                    lblFullHouse4.Text = roll.FullHouse().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblSS4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblSS4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lblSS4.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.SmallStraight();
                    lblSS4.Text = roll.SmallStraight().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.SmallStraight();
                    lblSS4.Text = roll.SmallStraight().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblLS4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblLS4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lblLS4.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.SmallStraight();
                    lblLS4.Text = roll.SmallStraight().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.SmallStraight();
                    lblLS4.Text = roll.SmallStraight().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblYahtzee4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblYahtzee4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lblYahtzee4.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.Yahtzee();
                    lblYahtzee4.Text = roll.Yahtzee().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.Yahtzee();
                    lblYahtzee4.Text = roll.Yahtzee().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblChance4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblChance4.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round5 >= -1)
            {
                if (lblChance4.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.Chance();
                    lblChance4.Text = roll.Chance().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.Chance();
                    lblChance4.Text = roll.Chance().ToString();
                    lblTotalScore3d.Text = lowerTotal.ToString();
                }
            }
        }

        //---ALL EVENTS BELOW RESPOND TO 5TH COLUMN LABELS---
        private void lblAces5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblAces5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblAces5.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Aces();
                    lblAces5.Text = roll.Aces().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Aces();
                    lblAces5.Text = roll.Aces().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
            }
        }

        private void lblTwos5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblTwos5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblTwos5.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Twos();
                    lblTwos5.Text = roll.Twos().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Twos();
                    lblTwos5.Text = roll.Twos().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
            }
        }

        private void lblThrees5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblThrees5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblThrees5.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Threes();
                    lblThrees5.Text = roll.Threes().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Threes();
                    lblThrees5.Text = roll.Threes().ToString();
                    lblTotalScore1d.Text = upperTotal.ToString();
                }
            }
        }

        private void lblFours5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFours5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblFours5.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Fours();
                    lblFours5.Text = roll.Fours().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Fours();
                    lblFours5.Text = roll.Fours().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
            }
        }

        private void lblFives5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFives5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblFives5.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Fives();
                    lblFives5.Text = roll.Fives().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Fives();
                    lblFives5.Text = roll.Fives().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
            }
        }

        private void lblSixes5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblSixes5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblSixes5.Text.Contains("0"))
                {
                    upperTotal = upperTotal + roll.Sixes();
                    lblSixes5.Text = roll.Sixes().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
                else
                {
                    upperTotal = upperTotal - temp + roll.Sixes();
                    lblSixes5.Text = roll.Sixes().ToString();
                    lblTotalScore1e.Text = upperTotal.ToString();
                }
            }
        }

        private void lbl3OfAKind5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbl3OfAKind5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lbl3OfAKind5.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FourOfAKind();
                    lbl3OfAKind5.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FourOfAKind();
                    lbl3OfAKind5.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
            }
        }

        private void lbl4OfAKind5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbl4OfAKind5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lbl4OfAKind5.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FourOfAKind();
                    lbl4OfAKind5.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FourOfAKind();
                    lbl4OfAKind5.Text = roll.FourOfAKind().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblFullHouse5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblFullHouse5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblFullHouse5.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.FullHouse();
                    lblFullHouse5.Text = roll.FullHouse().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.FullHouse();
                    lblFullHouse5.Text = roll.FullHouse().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblSS5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblSS5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblSS5.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.SmallStraight();
                    lblSS5.Text = roll.SmallStraight().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.SmallStraight();
                    lblSS5.Text = roll.SmallStraight().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblLS5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblLS5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblLS5.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.SmallStraight();
                    lblLS5.Text = roll.SmallStraight().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.SmallStraight();
                    lblLS5.Text = roll.SmallStraight().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblYahtzee5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblYahtzee5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblYahtzee5.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.Yahtzee();
                    lblYahtzee5.Text = roll.Yahtzee().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.Yahtzee();
                    lblYahtzee5.Text = roll.Yahtzee().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
            }
        }

        private void lblChance5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lblChance5.Text);
            if (round1 <= 0 && round2 <= 0 && round3 <= 0 && round4 <= 0)
            {
                if (lblChance5.Text.Contains("0"))
                {
                    lowerTotal = lowerTotal + roll.Chance();
                    lblChance5.Text = roll.Chance().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
                else
                {
                    lowerTotal = lowerTotal - temp + roll.Chance();
                    lblChance5.Text = roll.Chance().ToString();
                    lblTotalScore3e.Text = lowerTotal.ToString();
                }
            }
        }
    }
}
