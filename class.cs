using System;

public class Class1
{
	public Class1()
	{
	}
	public Card()
	{
        List<Card> pack = new List<Card>(); // Create a new empty list of cards

        // Add each card to the pack
        for (int suit = 1; suit <= 4; suit++)
        {
            for (int rank = 1; rank <= 13; rank++)
            {
                pack.Add(new Card(rank, suit)); // Creates a new card object with the current rank and suit and then adds it to the pack list
            }
        }

        // Print out each card in the pack
        foreach (Card card in pack)
        {
            Console.WriteLine(card);
        }
    }
}
