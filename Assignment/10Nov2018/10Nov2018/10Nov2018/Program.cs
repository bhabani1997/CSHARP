using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Nov2018
{
    class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Enter the first team name");
            string Team1 = Console.ReadLine();
            Console.WriteLine("Enter the second team name");
            string Team2 = Console.ReadLine();
            Console.WriteLine("Enter the players name of Team1 ");
            string[] Team1PlayersName = new string[5];
            for (int i = 0; i < Team1PlayersName.Length; i++)
                Team1PlayersName[i] = Console.ReadLine();
            Console.WriteLine("Enter the players name of Team2 ");
            string[] Team2PlayersName = new string[5];
            for (int i = 0; i < Team1PlayersName.Length; i++)
                Team2PlayersName[i] = Console.ReadLine();
            int Scorecard1 = 0;
            int[] Team1PlayersScore= new int[5];
            for (int i = 0; i < Team1PlayersScore.Length; i++)
            {
                Console.WriteLine("Enter the score of "+Team1PlayersName[i] );
                Team1PlayersScore[i] = Convert.ToInt32(Console.ReadLine());
                Scorecard1 = Scorecard1 + Team1PlayersScore[i];
            }
            int Scorecard2 = 0;
            int[] Team2PlayersScore = new int[5];
            for (int i = 0; i < Team2PlayersScore.Length; i++)
            {
                Console.WriteLine("Enter the score of " + Team2PlayersName[i]);
                Team2PlayersScore[i] = Convert.ToInt32(Console.ReadLine());
                Scorecard2 = Scorecard2 + Team2PlayersScore[i];
            }

            
            Console.WriteLine(" The total score of " + Team1 + " is " + Scorecard1);
            
            
            
            Console.WriteLine(" The total score of " + Team2 + " is " + Scorecard2);
            if (Scorecard1 > Scorecard2)
                Console.WriteLine(Team1 + " won the match");
            else if (Scorecard1 < Scorecard2)
                Console.WriteLine(Team2 + " won the match");
            else
                Console.WriteLine("the match tied");
            int x = Team1PlayersScore.Max();
            int ManOfTheTeam1 = Array.IndexOf(Team1PlayersScore, x);
            Console.WriteLine("The man of the " + Team1 + " is " +Team1PlayersName[ManOfTheTeam1] );
            int y = Team2PlayersScore.Max();
            int ManOfTheTeam2 = Array.IndexOf(Team2PlayersScore, y);
            Console.WriteLine("The man of the " + Team2 + " is " + Team2PlayersName[ManOfTheTeam2]);
            if(ManOfTheTeam1 > ManOfTheTeam2)
                Console.WriteLine("The man of the match is " + Team1PlayersName[ManOfTheTeam1]);
            else
                Console.WriteLine("The man of the match is " + Team2PlayersName[ManOfTheTeam2]);
            int AverageRunOfTeam1 = Scorecard1 / 5;
            int AverageRunOfTeam2 = Scorecard2 / 5;
            Console.WriteLine("Average run of "+ Team1 + " is " + AverageRunOfTeam1);
            Console.WriteLine("Average run of " + Team2 + " is " + AverageRunOfTeam2);
            Console.Read();
        }
    }
}
