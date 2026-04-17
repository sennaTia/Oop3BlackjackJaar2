using System.Collections.Generic;

namespace Oop3BlackjackJaar2
{
    public class GameManager
    {
        public List<Player> Players = new List<Player>();
        public Player CurrentPlayer;
        public Shoe Shoe = new Shoe();

        public void AddPlayer(string name)
        {
            Players.Add(new Player(name));
        }

        public void DealCards()
        {
            foreach (var player in Players)
            {
                player.Hand.AddCard(Shoe.DrawCard());
                player.Hand.AddCard(Shoe.DrawCard());
            }
        }

        public void NextPlayer()
        {
            if (Players.Count > 0)
            {
                CurrentPlayer = Players[0];
                Players.RemoveAt(0);
            }
            else
            {
                CurrentPlayer = null;
            }
        }
    }
}