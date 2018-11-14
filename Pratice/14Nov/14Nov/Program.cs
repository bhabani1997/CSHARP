using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Nov
{
    class details
    {

        public string name;
        public int score;
        public int id;
        public details()
        {
        }
        public details(int score)
        {
            Console.WriteLine("278");
        }
        public details(string name)
        {
            Console.WriteLine("arthur");
        }

        //public string Name { /*set { this.name = value; }*/ get { return this.name; } }
    }
    class player : details
    {
        public player()
        {
            Console.WriteLine("empty constructor");
        }
        public player(int score) : base(score)
        {
            Console.WriteLine("scored 278 runs");
        }
        public player(string name) : base(name)
        {
            Console.WriteLine("Remember the name ABD");
        }



        public player(string name, int score)
        {
            this.name = "messi";
            Console.WriteLine("ABD scored 278 runs" + this.name);
        }
        public player(int score, string name)
        {
            Console.WriteLine("278 run is made by ABD");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            player p1 = new player();
            player p2 = new player(78);
            player p3 = new player("puig");
            player p4 = new player("messi", 10);
            player p5 = new player(10, "messi");
            
            

            person p6 = new person();
            p6.print_detail();

            doctor d1 = new doctor();
            d1.print_detail();
            person p7 = new doctor();
            p7.print_detail();
            p7.display_detail();





            Console.ReadLine();

        }
    }
}    
class person
{
    public int age;
    public string gender;
    public string address;

    public  virtual void print_detail()
    {
        Console.WriteLine("MEESI, MALE, BARCELONA");
        
    }
    public void display_detail()
    {
        Console.WriteLine("ARTHUR, MALE, BARCELONA");
    }
}
class doctor : person
{
    public string specialization;

    public  override void print_detail()
    {
        Console.WriteLine("MESSI, MALE, BARCELONA, ATTACK");
    }
    public new void  display_detail()
    {
        Console.WriteLine("ARTHUR, MALE, BARCELONA, MIDFIELD");
    }

}
class patient : person
{
    public string disease;

    public void print_detail()
    {
        Console.WriteLine("MESSI, MALE, BARCELONA, SCORING GOALS");
    }
    public new void display_detail()
    {
        Console.WriteLine("ARTHUR, MALE, BARCELONA, PASSING BALLS");
    }

}
