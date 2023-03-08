using CMP1903M_A01_2223;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {

        static List<Card> pack = new List<Card>();

        public Pack()
        {
            pack = new List<Card>();

            // Code that will loop through each suit 
            for (int suit = 1; suit <= 4; suit++)
            {
                // Code that will loop through each value
                for (int value = 1; value <= 13; value++)
                {
                    // this code will create a new card and add it to the pack
                    Card card = new Card(value, suit);
                    pack.Add(card);
                }
            }
        }



        public static bool shuffleCardPack(int typeOfShuffle)
        {
            // code that will shuffle the pack based on the type of shuffle it is
            switch (typeOfShuffle)
            {
                case 1:
                    FisherYatesShuffle();
                    break;
                case 2:
                    RiffleShuffle();
                    break;
                case 3:
                    // Do not shuffle
                    break;
                default:
                    // Invalid shuffle type
                    return false;
            }
            // Shuffle successful
            return true;
        }

        public static Card deal()
        {
            // following code deals one card from the pack and removes it from the list
            if (pack.Count == 0)
            {
                // code validating that the pack is empty 
                throw new InvalidOperationException("The pack is empty");
            }
            Card card = pack[0];
            pack.RemoveAt(0);
            return card;
        }

        public static List<Card> dealCard(int amount)
        {
            // following code deals the specified number of cards from the pack and removes them from the list 
            if (amount > pack.Count)
            {
                // validates that there are not enough cards in the pack to deal
                throw new InvalidOperationException("There are not enough cards in the pack to deal");
            }
            List<Card> cards = pack.GetRange(0, amount);
            pack.RemoveRange(0, amount);
            return cards;
        }

        private static void FisherYatesShuffle()
        {
            // Performs the Fisher-Yates shuffle on the pack
            Random rng = new Random();
            int n = pack.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = pack[k];
                pack[k] = pack[n];
                pack[n] = card;
            }
        }
        // performs the RiffleShuffle method on the pack
        public static void RiffleShuffle()
        {
            List<Card> newPack = new List<Card>();
            int half = pack.Count / 2;
            int index1 = 0;
            int index2 = half;

            for (int i = 0; i < half; i++)
            {
                newPack.Add(pack[index1++]);
                newPack.Add(pack[index2++]);
            }

            if (index2 < pack.Count)
            {
                newPack.Add(pack[index2]);
            }

            pack = newPack;
        }
    }
}
