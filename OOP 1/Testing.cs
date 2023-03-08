using System;
using OOP_1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223

{

    // This is a class that'll represent a card in a normal deck of cards
    internal class Card
    {
        private int value; // The numerical value of the card is 1-13
        private int suit; // The suit of the card is 1-4


        // The following code is properties for the value and suit fields to validate that they are wihin proper range
        public int Value
        {
            get { return value; }
            set
            {
                if (value < 1 || value > 13)  // This code ensures that the value is within the valid range 
                    throw new ArgumentException("Invalid card value.");
                else
                    this.value = value;
            }
        }
        public int Suit
        {
            get { return suit; }
            set
            {
                if (value < 1 || value > 4) // This code is so the suit is within valid range as with the value 
                    throw new ArgumentException("Invalid card suit.");
                else
                    this.suit = value;
            }
        }


        // Following code is a constructer to create a new card with the value and suit
        public Card(int value, int suit)
        {
            this.Value = value;
            this.Suit = suit;
        }


        //Following method is to et a string representation of the card 
        public override string ToString()
        {
            string valueString;
            switch (this.value)
            {
                case 1:
                    valueString = "Ace";
                    break;
                case 11:
                    valueString = "Jack";
                    break;
                case 12:
                    valueString = "Queen";
                    break;
                case 13:
                    valueString = "King";
                    break;
                default:
                    valueString = this.value.ToString();
                    break;
            }

            string suitString;
            switch (this.suit)
            {
                case 1:
                    suitString = "Hearts";
                    break;
                case 2:
                    suitString = "Diamonds";
                    break;
                case 3:
                    suitString = "Clubs";
                    break;
                case 4:
                    suitString = "Spades";
                    break;
                default:
                    suitString = "";
                    break;
            }

            return valueString + " of " + suitString;
        }
    }
}
