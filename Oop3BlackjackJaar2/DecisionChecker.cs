public class DecisionChecker
{
    public string GetCorrectMove(Hand hand)
    {
        int score = hand.GetScore();

        if (score < 17)
            return "hit";
        else
            return "stand";
    }

    public bool Check(Hand hand, string keuze)
    {
        return GetCorrectMove(hand) == keuze;
    }
}