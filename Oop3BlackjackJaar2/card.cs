public class Card
{
    public string Suit;
    public string Value;

    public Card(string suit, string value)
    {
        Suit = suit;
        Value = value;
    }

    public int GetScore()
    {
        if (int.TryParse(Value, out int num)) return num;
        if (Value == "J" || Value == "Q" || Value == "K") return 10;
        return 11;
    }
}