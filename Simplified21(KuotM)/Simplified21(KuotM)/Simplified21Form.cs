using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21_KuotM_
{
    public partial class frmSimplified21 : Form
    {
        const int MIN_NUM = 1;
        const int MAX_NUM = 10;
        int userCard1;
        int userCard2;
        int userCard3;
        int DealerCard1;
        int DealerCard2;
        int DealerCard3;
        int userScore;
        int dealerScore;
        double Bet;
        System.IO.Stream Jazzy = Properties.Resources.Casino_music;
        System.IO.Stream CasinoNight = Properties.Resources.Casino_Night;
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();

        public frmSimplified21()
        {
            InitializeComponent();

            // This plays music when the form is loaded
            System.Media.SoundPlayer music = new System.Media.SoundPlayer(Jazzy);
            music.Play();

            // This creates a random number generator
            Random Cards = new Random();

            // This declares and assigns the card variables to a number between the Min_NUM and MAX_NUM
            
            userCard1 = Cards.Next(MIN_NUM, MAX_NUM + 1);
            userCard2 = Cards.Next(MIN_NUM, MAX_NUM + 1);
            userCard3 = Cards.Next(MIN_NUM, MAX_NUM + 1);
            DealerCard1 = Cards.Next(MIN_NUM, MAX_NUM + 1);
            DealerCard2 = Cards.Next(MIN_NUM, MAX_NUM + 1);
            DealerCard3 = Cards.Next(MIN_NUM, MAX_NUM + 1);

            // This converts the card variables to a string and assigns it to the text in the label
            lblUserCard1.Text = userCard1.ToString();
            lblUserCard2.Text = userCard2.ToString();
            lblUserCard3.Text = userCard3.ToString();
            lblDealerCard1.Text = DealerCard1.ToString();
            lblDealerCard2.Text = DealerCard2.ToString();
            lblDealerCard3.Text = DealerCard3.ToString();


        }

        public void ResetGame()
        {
            // This hides the labels a.k.a cards
            lblDealerCard1.Hide();
            lblDealerCard2.Hide();
            lblDealerCard3.Hide();
            lblUserCard1.Hide();
            lblUserCard3.Hide();
            lblUserCard2.Hide();
            lblUserScore.Hide();
            lblDealerScore.Hide();
            btnHit.Hide();
            btnStay.Hide();

            // This shows the play button
            btnPlay.Show();

            // This clears and enables the button and text box
            txtBet.Text = "";
            btnBet.Enabled = true;
            txtBet.Enabled = true;
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            // This creates a random number generator
            Random Cards = new Random();

            // This declares and assigns the card variables to a number between the Min_NUM and MAX_NUM

            userCard1 = Cards.Next(MIN_NUM, MAX_NUM + 1);
            userCard2 = Cards.Next(MIN_NUM, MAX_NUM + 1);
            userCard3 = Cards.Next(MIN_NUM, MAX_NUM + 1);
            DealerCard1 = Cards.Next(MIN_NUM, MAX_NUM + 1);
            DealerCard2 = Cards.Next(MIN_NUM, MAX_NUM + 1);
            DealerCard3 = Cards.Next(MIN_NUM, MAX_NUM + 1);

            // This converts the card variables to a string and assigns it to the text in the label
            lblUserCard1.Text = userCard1.ToString();
            lblUserCard2.Text = userCard2.ToString();
            lblUserCard3.Text = userCard3.ToString();
            lblDealerCard1.Text = DealerCard1.ToString();
            lblDealerCard2.Text = DealerCard2.ToString();
            lblDealerCard3.Text = DealerCard3.ToString();


        }

        public void CheckWinner(double user, double dealer)
        {
            // This checks the score of the user and the dealer's and compares them to determine who wins
            if (user > 21)
            {
                MessageBox.Show("You lose $" + Bet + "!");
            }
            else if (dealer > 21)
            {
                // This calculates how much the user wins with a 3:2 payout ratio (paid 3 dollars for every 2 dollars bet)
                Bet = (Bet / 2) * 3;
                MessageBox.Show("You win $" + Bet + "!");
            }
            else if (user <= dealer)
            {
                MessageBox.Show("You lose $" + Bet + "!");
            }
            else if (user == 21)
            {
                // This calculates how much the user wins by a 3:2 payout ratio (paid 3 dollars for every 2 dollars bet)
                Bet = (Bet / 2) * 3;
                MessageBox.Show("You win $" + Bet + "!");
            }
            else if (dealer == 21)
            {
                MessageBox.Show("You lose $" + Bet + "!");
            }
            else
            {
                // This calculates how much the user wins by a 3:2 payout ratio (paid 3 dollars for every 2 dollars bet)
                Bet = (Bet / 2) * 3;
                MessageBox.Show("You win $" + Bet + "!");
            }
        }


        public void frmSimplified21_Load(object sender, EventArgs e)
        {

            // This hides the labels a.k.a cards
            lblDealerCard1.Hide();
            lblDealerCard2.Hide();
            lblDealerCard3.Hide();
            lblUserCard1.Hide();
            lblUserCard3.Hide();
            lblUserCard2.Hide();
            lblUserScore.Hide();
            lblDealerScore.Hide();
            btnHit.Hide();
            btnStay.Hide();

            

        }

        private void btnBet_Click(object sender, EventArgs e)
        {

            // This declares the local variables
            double outdouble;

            
            // This checks if value entered into textbox is a number then converts it to a double
            if (Double.TryParse(txtBet.Text, out outdouble))
            {
                // This disables the button and textbox
                txtBet.Enabled = false;
                btnBet.Enabled = false;

                // This converts the textbox's string to a double
                Bet = Convert.ToDouble(txtBet.Text);
            }
            // This checks if the user enters nothing in the textbox and displays a messagebox
            else if (txtBet.Text == "")
            {
                MessageBox.Show("Enter a valid number");
            }
            else
            {
                MessageBox.Show("Enter a valid number");
            }
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // This checks if the bet button is disabled/greyed out
            if (btnBet.Enabled == false)
            {
                // This hides and shows the labels and buttons
                btnPlay.Hide();
                btnHit.Show();
                btnStay.Show();
                lblUserCard1.Show();
                lblUserCard2.Show();
                lblDealerCard1.Show();
                lblDealerCard2.Show();
                lblUserScore.Show();
                lblDealerScore.Show();

                // This calculates the User and Dealer's score
                userScore = userCard1 + userCard2;
                dealerScore = DealerCard1 + DealerCard2;

                // This converts 
                lblDealerScore.Text = "Dealer: " + dealerScore.ToString();
                lblUserScore.Text = "You: " + userScore.ToString();

            }
            // This displays a messagebox if the bet button is enabled
            else
            {
                MessageBox.Show("Please enter a bet before playing!");
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            

            // This checks if the dealer's score is less than 16 and makes the dealer hit
            if (dealerScore < 16)
            {
                // This shows the label
                lblDealerCard3.Show();
                lblUserCard3.Show();

                // This calculates the user's and dealer's score
                dealerScore = DealerCard1 + DealerCard2 + DealerCard3;
                userScore = userCard1 + userCard2 + userCard3;

                // This converts the dealer's score to string and displays it in the label
                lblDealerScore.Text = "Dealer: " + dealerScore.ToString();
                lblUserScore.Text = "You: " + userScore.ToString();
            }
            else
            {
                // This shows the last card
                lblUserCard3.Show();

                // This calculates the User and Dealer's score
                userScore = userCard1 + userCard2 + userCard3;
                dealerScore = DealerCard1 + DealerCard2;

                // This converts the dealer's and user's score to string and displays it in the label
                lblDealerScore.Text = "Dealer: " + dealerScore.ToString();
                lblUserScore.Text = "You: " + userScore.ToString();
            }

            // This disables the hit button
            btnStay.Enabled = false;

            // This calls the check winner procedure
            this.CheckWinner(userScore, dealerScore);


        }

        private void btnStay_Click(object sender, EventArgs e)
        {

            // This checks the dealer's score
            if(dealerScore < 16)
            {
                // This shows the label
                lblDealerCard3.Show();

                // This calculates the user's and dealer's score
                dealerScore = DealerCard1 + DealerCard2 + DealerCard3;
                userScore = userCard1 + userCard2;

                // This converts the dealer's and user's score to string and displays it in the label
                lblDealerScore.Text = "Dealer: " + dealerScore.ToString();
                lblUserScore.Text = "You: " + userScore.ToString();
            }
            else
            {
                // This calculates the User and Dealer's score
                userScore = userCard1 + userCard2;
                dealerScore = DealerCard1 + DealerCard2;

                // This converts the dealer's and user's score to string and displays it in the label 
                lblDealerScore.Text = "Dealer: " + dealerScore.ToString();
                lblUserScore.Text = "You: " + userScore.ToString();
 
            }

            // This disables the hit button
            btnHit.Enabled = false;

            // This calls the check winner procedure
            this.CheckWinner(userScore, dealerScore);

        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            // This calls the reset game procedure
            this.ResetGame();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // This closes the program
            this.Close();
        }

        private void mniJazzy_Click(object sender, EventArgs e)
        {
            // This plays the music
            System.Media.SoundPlayer music = new System.Media.SoundPlayer(Jazzy);
            music.Play();
        }

        private void mniCasinoNight_Click(object sender, EventArgs e)
        {
            // This plays the music
            System.Media.SoundPlayer music = new System.Media.SoundPlayer(CasinoNight);
            music.Play();
        }

        private void picMusic_Click(object sender, EventArgs e)
        {
            music.Stop();
            
        }
    }
}
