using Project_4____Salalah_Sports_League_.Moduls;

namespace Project_4____Salalah_Sports_League_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create teams and players
            Team team1 = new Team("Salalah Eagles", "Coach Ali");
            Team team2 = new Team("Dhofar Lions", "Coach Fatima");

            team1.AddPlayer(new Player("Ahmed", 20, "Forward"));
            team1.AddPlayer(new Player("Omar", 22, "Midfielder"));

            team2.AddPlayer(new Player("Sultan", 21, "Forward"));
            team2.AddPlayer(new Player("Nasser", 23, "Defender"));

            // Create league
            League league = new League("Salalah Annual Football League");
            league.AddTeam(team1);
            league.AddTeam(team2);

            // Record matches
            Match match1 = new Match(team1, team2, 2, 1);
            Match match2 = new Match(team1, team2, 0, 0);

            league.AddMatch(match1);
            league.AddMatch(match2);

            // Display match results
            Console.WriteLine("Match Results:");
            match1.PrintResult();
            match2.PrintResult();

            // Show league standings
            Console.WriteLine("\nLeague Standings:");
            league.ShowStandings();
        }
    }
}
