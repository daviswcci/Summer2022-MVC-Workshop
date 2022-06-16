namespace Basketball_Workshop.Models
{
    public class Position
    {
        public string Name;
        public List<Player> Players;

        public Position(string name, List<Player> players)
        {
            Name = name;
            Players = players;
        }
    }
}
