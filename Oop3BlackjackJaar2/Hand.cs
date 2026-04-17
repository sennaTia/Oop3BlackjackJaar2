using System.Collections.Generic;

public class Hand
{
    public List<Card> Cards = new List<Card>();

    public void AddCard(Card card)
    {
        Cards.Add(card);
    }

    public int GetScore()
    {
        int score = 0;
        int aces = 0;

        foreach (var card in Cards)
        {
            score += card.GetScore();
            if (card.Value == "A") aces++;
        }

        while (score > 21 && aces > 0)
        {
            score -= 10;
            aces--;
        }

        return score;
    }
}