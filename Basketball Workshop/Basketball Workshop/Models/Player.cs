namespace Basketball_Workshop.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public string UserId { get; set; }
        public virtual User User {get; set; }
        public virtual List<PlayerPosition> Positions { get; set; }
        public double PPG { get; set; }
        public bool IsRetired { get; set; }

        //public Player(string name, Team team, List<Position> positions, double ppg, bool isRetired)
        //{
        //    Name = name;
        //    Team = team;
        //    Positions = positions;
        //    PPG = ppg;
        //    IsRetired = isRetired;
        //}
    }
}
