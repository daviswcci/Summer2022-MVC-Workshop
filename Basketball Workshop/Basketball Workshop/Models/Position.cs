namespace Basketball_Workshop.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Player> Players;

        public Position(string name) //, List<Player> players)
        {
            Name = name;
            //Players = players;
        }

        public Position()
        {

        }
    }
}
