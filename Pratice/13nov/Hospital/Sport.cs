using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class player
    {
        public string PlayerName;
        public int PlayerId;
        public int PlayerScore;
        public void player_input_details()
        {
            Console.WriteLine("Enter the player name");
            PlayerName = Console.ReadLine();
            Console.WriteLine("Enter the player id");
            PlayerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the player score");
            PlayerScore = Convert.ToInt32(Console.ReadLine());
        }
        public void player_output_details()
        {
            Console.WriteLine("player name     " + "          player id      " + "          player score");
            Console.WriteLine(PlayerName + PlayerId + PlayerScore);
        }


    }
   
    class team
    {
        public string TeamName;
        public int TeamId;
        public player p = new player();

       
        public void team_input_details()
        {
            Console.WriteLine("Enter the team name");
            TeamName = Console.ReadLine();
            Console.WriteLine("Enter the team id");
            TeamId = Convert.ToInt32(Console.ReadLine());
            p.player_input_details();
            
        }
       public void team_output_details()
        {
            Console.WriteLine("team name     "+"          team id      ");
            Console.WriteLine(TeamName         +           TeamId);
            p.player_output_details();
        }
            

    }
   
    class Sport
    {
        static void Main(string[] args)
        {
            team t1 = new team();
            team t2 = new team();
            t1.team_input_details();
            t2.team_input_details();
            t1.team_output_details();
            t2.team_output_details();
            void result()
            {
                if (t1.p.PlayerScore > t2.p.PlayerScore)
                {
                    Console.WriteLine("Team1 won the match");
                }
                if (t1.p.PlayerScore < t2.p.PlayerScore)
                {
                    Console.WriteLine("Team2 won the match");
                }
            }
            result();

        }
    }
}
