using CMP1903M_A01_2223;
using OOP_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Card
    {
        private int value; // This will be used to store the numerical value of the cards (1-13)
        private int suit; // This will be used to store the numerical suit of the cards (1-4)

        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
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

                value = Value;
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
    }
}