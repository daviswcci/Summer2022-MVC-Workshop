namespace Basketball_Workshop.Models
{
    public class Coach
    {
        public string Name;
        public Team Team;
        public List<Team> PastTeams;
        public DateTime StartYear;
        public int Wins;
        public int Losses;
        public string FavoriteFood;

        public Coach(string name, Team team, List<Team> pastTeams, DateTime startYear, int wins, int losses, string favoriteFood)
        {
            Name = name;
            Team = team;
            PastTeams = pastTeams;
            StartYear = startYear;
            Wins = wins;
            Losses = losses;
            FavoriteFood = favoriteFood;
        }
    }
}
