using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shimon_moshe_2024.sport_app
{
    using System;

    public class Team
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string CurrentLeague { get; set; }
        public int TotalGames { get; set; } 
        public int GamesPlayed { get; set; } 
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int Points { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }

        
        public int GoalDifferential
        {
            get
            {
                return GoalsFor - GoalsAgainst;
            }
        }

       
        public Team(string name, string city, string currentLeague, int totalGames, int gamesPlayed,
                    int wins, int losses, int draws, int points, int goalsFor, int goalsAgainst)
        {
            Name = name;
            City = city;
            CurrentLeague = currentLeague;
            TotalGames = totalGames;
            GamesPlayed = gamesPlayed;
            Wins = wins;
            Losses = losses;
            Draws = draws;
            Points = points;
            GoalsFor = goalsFor;
            GoalsAgainst = goalsAgainst;
        }

        public void DisplayTeamInfo()
        {
            Console.WriteLine($"Team: {Name}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"League: {CurrentLeague}");
            Console.WriteLine($"Total Games (Season): {TotalGames}");
            Console.WriteLine($"Games Played (Season): {GamesPlayed}");
            Console.WriteLine($"Wins: {Wins}");
            Console.WriteLine($"Losses: {Losses}");
            Console.WriteLine($"Draws: {Draws}");
            Console.WriteLine($"Points: {Points}");
            Console.WriteLine($"Goals For: {GoalsFor}");
            Console.WriteLine($"Goals Against: {GoalsAgainst}");
            Console.WriteLine($"Goal Differential: {GoalDifferential}");
        }
    }

    

}
