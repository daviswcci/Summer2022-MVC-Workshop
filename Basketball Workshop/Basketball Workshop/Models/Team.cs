namespace Basketball_Workshop.Models
{
    public class Team
    {
        public string Name;
        public string City;
        public Coach Coach;
        public List<Player> Players;
        public int PlayerCount 
        {
            // customizing our 'getter' the . operator
            get
            {
                return Players.Count;
            }
        }
        public string Mascot;

        public Team(string name, string city, Coach coach, List<Player> players, string mascot)
        {
            Name = name;
            City = city;
            Coach = coach;
            Players = players;
            Mascot = mascot;
        }
    }
}
