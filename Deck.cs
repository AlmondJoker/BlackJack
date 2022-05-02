using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Deck
    {
        static List<string> decksuit = new List<string>() { "♠", "♥", "♣", "♦" };
        static List<string> deckvalue1 = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "11" };
        static List<string> cardsuit = new List<string>();
        static List<int> cardvalue = new List<int>();

        public static Dictionary<string, int> setDeck_dictionary() //This method creates every card in the deck.
        {
            Dictionary<string, int> deck = new Dictionary<string, int>(); //This variable stores the cards and their values.
            List<int> deckvalue2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 }; //This variable pulls the number values from the dictionary var

            // Dictionary example
            for (int a = 0; a < decksuit.Count; a++) //Loop assigns suits to the card (e.g. 1♠
            {
                for (int b = 0; b < deckvalue2.Count; b++) //Loop assigns card value (e.g. 1,2,3,4,5)
                {
                        string tmp = decksuit[a] + deckvalue1[b]; //Loop assigns suits to the card (e.g. 1♠, 2♥, 3♣)
                        deck.Add(tmp, deckvalue2[b]); //Loop assigns card value (e.g. 1,2,3)
                    
                }
                
            }
            return deck;
        }
    

         /*public static List<string> shuffleCards(List<string> shuffled)
         {
             Random shuffler = new Random();
             int indexOne;
             int indexTwo;
             string tmp1;
             for (int i = 0; i < 52; i++)
             {
                 indexOne = shuffler.Next(0, shuffled.Count);
                 indexTwo = shuffler.Next(0, shuffled.Count);
                 tmp1 = shuffled[indexOne];
                 shuffled[indexOne] = shuffled[indexTwo];
                 shuffled[indexTwo] = tmp1;
             }
             return shuffled;
             //SOURCE:
             //https://github.com/gponimansky/blackjack-casino/blob/master/BlackjackGame/BlackjackGame/Program.cs
         } */
        

       public static List<string> card = new List<string>(); //Array list will store cards from the dictionary variable.
        public static List<string> addCard() //Method will pull a card out of deck every time it is called.
        {
            // A Card with two slots: 0:Suit||Key;  1:value
           List<string> card = new List<string>(); 
            // Create a Dictionary object deck in this function
            Dictionary<string, int> deck = setDeck_dictionary();
            // Generate a Pseudo Random Value
            Random r = new Random();
            // loop through deck and save all into card
           for (int i = 0; i < deck.Count; i++)
           {
                int tmp = r.Next(0, deck.Count - 1);
                string suit = deck.ElementAt(tmp).Key;
                int value = deck.ElementAt(tmp).Value;
                deck.Remove(suit);
                card.Add(suit);
                card.Add(value.ToString());
            }
            return card;
        }
    }
}
