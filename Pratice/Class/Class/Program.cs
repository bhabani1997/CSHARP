using System;

namespace Class
{
    class pratice
    {
        static void Main(string[] args)
        {
           Teams t1= new Teams();
            t1.team_details();
            players p1 = new players();
            p1.players_details();
        }
    }
    class Teams
    {
        public string[] TeamName = new string[2];
        public int TeamScore;
        public int TeamAvgScore;
        public int  NoOfPlayers;
        public int TeamScorecard;
        public void team_details()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter the team" + (i+1) + "name");
                string Team1 = Console.ReadLine();
                Console.WriteLine("Enter the no of players");
                string Team2 = Console.ReadLine();
                players p1 = new players();
                p1.players_details();
            }
        }
    }
 
    class players
    {
        public string[] PlyersName=new string[5];
        public int[] PlayerScore = new int[11];
        public void players_details()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ENTER THE PLAYERS" + (i+1) + "NAME");
                PlyersName[i] = Console.ReadLine();
                Console.WriteLine("ENTER THE  PLAYERS" + (i+1) + "SCORE");
                PlayerScore[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Scorecard1 = 0;
            int[] Team1PlayersScore = new int[5];
            for (int i = 0; i < Team1PlayersScore.Length; i++)
            {
                Console.WriteLine("Enter the score of " + Team1PlayersName[i]);
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
        }


