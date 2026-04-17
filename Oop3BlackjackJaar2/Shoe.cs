using System;
using System.Collections.Generic;

public class Shoe
{
    private List<Card> cards = new List<Card>();
    private Random rnd = new Random();

    public Shoe()
    {
        for (int i = 0; i < 2; i++)
        {
            Deck deck = new Deck();
            cards.AddRange(deck.Cards);
        }

        Shuffle();
    }

    private void Shuffle()
    {
        for (int i = cards.Count - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            var temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }

    public Card DrawCard()
    {
        var card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}