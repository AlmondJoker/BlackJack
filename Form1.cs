using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        int hitButtonCount = 0; //This variable will be used in the hit button method to track the amount of hits executed.

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void leaveButton_Click(object sender, EventArgs e) //This method closes the game.
        {
           Environment.Exit(0);
        }
        
        List<string> startingCards= Deck.addCard(); //Calls the addCard method to distribute starting cards for player and dealer.

        private void dealButton_Click(object sender, EventArgs e) //This method begins the game by handing out the starting hand for player and dealer
        {
            List<string> playerCards = new List<string>();
            playerCards.Add(startingCards[0]); //Pulls 1st card for player.
            playerCards.Add(startingCards[2]); //Pulls 2nd card for player.

            List<string> dCards = new List<string>();
            dCards.Add(startingCards[4]); //Pulls 1st card for dealer.
            dCards.Add(startingCards[6]); // Pulls 2nd card for dealer.

            int pCount = 0; //Represents the integer value of the players hand.
            int dCount = 0; //Represents the integer value of the dealers hand.
            pCount = Convert.ToInt16(startingCards[1]) + Convert.ToInt16(startingCards[3]);
            dCount = Convert.ToInt16(startingCards[5]) + Convert.ToInt16(startingCards[7]);




            playerHand.Text = playerCards[0] + " " + playerCards[1]; //Prints players hand to the textbox.
            playerCount.Text = pCount.ToString(); //Prints the sum value of the players hand to the textbox.

            dealerHand.Text = dCards[0] + " " + dCards[1]; //Prints dealers hand to the textbox.
            dealerCount.Text = dCount.ToString(); //Prints the sum value of the dealers hand to the textbox.

            if (pCount == 21) //Checks for automatic win for player.
            {
                MessageBox.Show("Player Wins!");
            }
            else if (dCount == 21) //Checks for automatic win for dealer.
            {
                MessageBox.Show("Dealer Wins!");
            }



        }

        private void hitButton_Click(object sender, EventArgs e) //This method will add a card to the players hand each time it is clicked.
        {
            int pCount = Convert.ToInt32(playerCount.Text);
            string pOriginalHand = playerHand.Text;
            List<string> pCards = new List<string>();  //This variable will contain consecutive cards after the starting cards are dealt.

            pCards.Add(startingCards[8]);
            pCards.Add(startingCards[10]);
            pCards.Add(startingCards[12]);
            pCards.Add(startingCards[14]);
            pCount = pCount + Convert.ToInt32(startingCards[9]);


            if (hitButtonCount == 0) //This will both give the player a card and check if they consequently bust.
            {
                playerHand.Text = pOriginalHand + " " + pCards[0];
                playerCount.Text = pCount.ToString();
                if ((Convert.ToInt16(playerCount.Text) != 21) && (Convert.ToInt16(playerCount.Text) > 21))
                {
                    MessageBox.Show("Player Busted!\n Dealer Wins!");
                }
            }
            if ((hitButtonCount == 1) && (Convert.ToInt16(playerCount.Text) < 22)) //This will both give the player a card and check if they consequently bust.
            {
                {
                    pOriginalHand = playerHand.Text;
                    playerHand.Text = pOriginalHand + " " + pCards[1];
                    pCount = Convert.ToInt32(playerCount.Text);
                    pCount = pCount + Convert.ToInt32(startingCards[11]);
                    playerCount.Text = pCount.ToString();
                    if ((Convert.ToInt16(playerCount.Text) != 21) && (Convert.ToInt16(playerCount.Text) > 21))
                    {
                        MessageBox.Show("Player Busts!\n Dealer Wins");
                    }
                }
                if ((hitButtonCount == 2) && (Convert.ToInt16(playerCount.Text) < 22)) //This will both give the player a card and check if they consequently bust.
                {
                    pOriginalHand = playerHand.Text;
                    playerHand.Text = pOriginalHand + " " + pCards[2];
                    pCount = Convert.ToInt32(playerCount.Text);
                    pCount = pCount + Convert.ToInt32(startingCards[13]);
                    playerCount.Text = pCount.ToString();
                    if ((Convert.ToInt16(playerCount.Text) != 21) && (Convert.ToInt16(playerCount.Text) > 21))
                    {
                        MessageBox.Show("Player Busts!\n Dealer Wins");
                    }
                }
                if ((hitButtonCount == 3) && (Convert.ToInt16(playerCount.Text) < 22)) //This will both give the player a card and check if they consequently bust.
                {
                    pOriginalHand = playerHand.Text;
                    playerHand.Text = pOriginalHand + " " + pCards[3];
                    pCount = Convert.ToInt32(playerCount.Text);
                    pCount = pCount + Convert.ToInt32(startingCards[15]);
                    playerCount.Text = pCount.ToString();
                    if ((Convert.ToInt16(playerCount.Text) != 21) && (Convert.ToInt16(playerCount.Text) > 21))
                    {
                        MessageBox.Show("Player Busts!\n Dealer Wins");
                    }
                }
            }
        }

        public void standButton_Click(object sender, EventArgs e) //This method will distribute cards to the dealer until they have a hand of 17 or greater, 21, or over 21.
        {
            
            List<String> dHand = new List<string>();
            String dOriginalHand = dealerHand.Text;
            int dCount = 0; //Used to keep track of the integer value of the dealers hand.
            dHand.Add(startingCards[16]);
            dHand.Add(startingCards[18]);
            dHand.Add(startingCards[20]);
            dHand.Add(startingCards[22]);

            int i = 17;
            int k = 0;
           
            while (Convert.ToInt16(dealerCount.Text) < 17) //Loop will execute to add cards to dealers hand until stand or bust.
            {
                dOriginalHand = dealerHand.Text;
                dealerHand.Text = dOriginalHand + " " + dHand[k];
                dCount = Convert.ToInt32(dealerCount.Text) + Convert.ToInt16(startingCards[i]);
                dealerCount.Text = dCount.ToString();
                i += 2;
                k += 1;
       
                if (Convert.ToInt16(dealerCount.Text) > 21)
                {
                    MessageBox.Show("Dealer Busts!\n Player Wins!");
                }

            }

            int pCount = Convert.ToInt16(playerCount.Text); // checks if the game results in a dealer win.
            if ((Convert.ToInt16(dealerCount.Text) > pCount) && (pCount <=21) && (Convert.ToInt16(dealerCount.Text) <= 21))
            {
                MessageBox.Show("Dealer Wins!");

            }
            if (Convert.ToInt16(dealerCount.Text) < pCount) //Checks if the game results in a player win
            {
                MessageBox.Show("Player Wins!");

            }
            if (Convert.ToInt16(dealerCount.Text) == pCount) //Checks if the game result is a tie/push.
            {
                MessageBox.Show("Push!");
                
            }



           //return endGame;



        }

        

        private void playerHand_TextChanged(object sender, EventArgs e)
        {

        }

        private void playerCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dealerCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dealerHand_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        } 

        private void hitButton_MouseClick(object sender, MouseEventArgs e)
        {
            hitButtonCount++;
        }

        private void standButton_MouseClick(object sender, MouseEventArgs e)
        {
        }

    }
}
