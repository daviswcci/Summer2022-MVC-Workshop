namespace Basketball_Workshop.Models
{
    public class Player
    {
        public string Name;
        public Team Team;
        public List<Position> Positions;
        public double PPG;
        public bool IsRetired;

        public Player(string name, Team team, List<Position> positions, double ppg, bool isRetired)
        {
            Name = name;
            Team = team;
            Positions = positions;
            PPG = ppg;
            IsRetired = isRetired;
        }
    }
}
