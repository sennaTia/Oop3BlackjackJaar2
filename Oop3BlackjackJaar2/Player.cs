public class Player
{
    public string Name;
    public Hand Hand = new Hand();

    public Player(string name)
    {
        Name = name;
    }
}