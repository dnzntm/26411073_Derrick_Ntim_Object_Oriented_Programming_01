using CMP1903M_A01_2223;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        private int value; // This will be used to store the numerical value of the cards (1-13)
        private int suit; // This will be used to store the suit of the cards (1-4)

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public int Value
        {
            get { return value; }
            set
            {
                // Code that will be used to validate the card value input
                if (value < 1 || value > 13)
                {
                    throw new ArgumentException("Card value must be between 1 and 13.");
                }

                value = value;
            }
        }

        public int Suit
        {
            get { return suit; }
            set
            {
                 // code that will be used to validate the card suit input 
                if (value < 1 || value > 4)
                {
                    throw new ArgumentException("Card suit must be between 1 and 4.");
                }

                suit = value;
            }
        }
        public override string ToString()
        {
            string valueString = "";

            switch (Value)
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
                    valueString = Value.ToString();
                    break;
            }

            string suitString = "";

            switch (Suit)
            {
                case 1:
                    suitString = "Spades";
                    break;
                case 2:
                    suitString = "Hearts";
                    break;
                case 3:
                    suitString = "Diamonds";
                    break;
                case 4:
                    suitString = "Clubs";
                    break;
            }

            return valueString + " of " + suitString;
        }

    }
}