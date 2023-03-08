using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        private static Pack pack;

        public static void TestPack()
        {
            // gets the user input for the shuffle type
            Console.WriteLine("Enter the type of shuffle: (1) Fisher-Yates, (2) Riffle, (3) None");
            int shuffleType = int.Parse(Console.ReadLine());

            // creates a new pack object
            pack = new Pack();

             // shuffles the pack based on user input
            bool shuffleSuccessful = Pack.shuffleCardPack(shuffleType);
            if (!shuffleSuccessful)
            {
                Console.WriteLine("Invalid shuffle type");
                return;
            }

            // gets the user to input the number of cards that they want to be dealed
            Console.WriteLine("Enter the number of cards to deal:");
            int numCards = int.Parse(Console.ReadLine());

            // code that deals the cards and displays them
            Console.WriteLine("Dealt {0} cards:", numCards);
            List<Card> cards = Pack.dealCard(numCards);
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }

        }
    }
    }

