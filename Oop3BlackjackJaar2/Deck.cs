using System.Collections.Generic;

public class Deck
{
    public List<Card> Cards = new List<Card>();

    public Deck()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        foreach (var suit in suits)
        {
            foreach (var value in values)
            {
                Cards.Add(new Card(suit, value));
            }
        }
    }
}