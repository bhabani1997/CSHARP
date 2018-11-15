using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _15Nov
{
    public abstract class details
    {
        string _gender;
        public int _age;
        public string name;
        public int id;
        public int score = 0;
        public string _firstname;
        string _lastname;

        public abstract void Print_details();
        public abstract string Gender { get; }

    }
    public class players : details
        {

        public override void Print_details()
        {
            Console.WriteLine("Enter the name of the player");
            name = Console.ReadLine();
            Console.WriteLine("Enter the id of the player");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the score of the player");
            score = Convert.ToInt32(Console.ReadLine());
        }

            public int Age
        {
            get
            {
                return _age;
            }
            set

            {
                _age = value;
            }
        }
        public override string Gender { get { return Gender; } }
    
    }
    public class team : details
        {
            players[] p = new players[3];
            public override void Print_details()
            {
                Console.WriteLine("Enter the name of the team");
                name = Console.ReadLine();
                Console.WriteLine("Enter the id of the team");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the score of the team");
                score = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the score of the team");

                for(int i=0;i<3;i++)
                {
                    p[i].Print_details();
                } 

            }
        public override string Gender { get { return Gender; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            team t1 = new team();
            t1.Print_details();
            Console.ReadLine();

            players p = new players();
            p._age = 31;
            Console.WriteLine(p.Age);

        }
    }
}
