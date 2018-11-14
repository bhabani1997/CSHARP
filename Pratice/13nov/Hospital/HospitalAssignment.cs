using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports

{
    class team
    {
        public string TeamName;
        public int TeamId;
        void team_details()
        {
            Console.WriteLine("Enter the team name");
            TeamName = Console.ReadLine();
            Console.WriteLine("Enter the team id");
            TeamId = Convert.ToInt32(Console.ReadLine());
            player p = new player();
            p.player_details();
        }

    }
    class player
    {
        public string PlayerName;
        public int PlayerId;
        public int PlayerScore;
        public void player_details()
        {
            Console.WriteLine("Enter the player name");
            PlayerName = Console.ReadLine();
            Console.WriteLine("Enter the player id");
            PlayerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the player score");
            PlayerScore = Convert.ToInt32(Console.ReadLine());
        }

    }
    class Sport
    {
        static void Main(string[] args)
        {
            team t1 = new team();
            team t2 = new team();
        }
    }
}

