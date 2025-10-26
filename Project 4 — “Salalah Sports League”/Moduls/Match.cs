using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4____Salalah_Sports_League_.Moduls
{
    class Match
    {
        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
        public int ScoreA { get; set; }
        public int ScoreB { get; set; }
        public Team Winner { get; set; }

        public Match(Team teamA, Team teamB, int scoreA, int scoreB)
        {
            TeamA = teamA;
            TeamB = teamB;
            ScoreA = scoreA;
            ScoreB = scoreB;

            if (scoreA > scoreB) Winner = teamA;
            else if (scoreB > scoreA) Winner = teamB;
            else Winner = null; // Draw
        }

        public void PrintResult()
        {
            string winnerName = Winner != null ? Winner.Name : "Draw";
            Console.WriteLine($"{TeamA.Name} {ScoreA} - {ScoreB} {TeamB.Name} | Winner: {winnerName}");
        }
    }
}
