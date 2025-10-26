using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4____Salalah_Sports_League_.Moduls
{

    class League
    {
        public string Name { get; set; }
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Match> Matches { get; set; } = new List<Match>();

        public League(string name)
        {
            Name = name;
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public void AddMatch(Match match)
        {
            Matches.Add(match);
        }

        public void ShowStandings()
        {
            Console.WriteLine($"League: {Name} Standings");
            Dictionary<Team, int> points = new Dictionary<Team, int>();
            foreach (var team in Teams)
                points[team] = 0;

            foreach (var match in Matches)
            {
                if (match.Winner != null)
                    points[match.Winner] += 3; // 3 points for win
                else
                {
                    points[match.TeamA] += 1; // 1 point each for draw
                    points[match.TeamB] += 1;
                }
            }

            foreach (var kvp in points)
                Console.WriteLine($"{kvp.Key.Name} - {kvp.Value} points");
        }
    }
}
