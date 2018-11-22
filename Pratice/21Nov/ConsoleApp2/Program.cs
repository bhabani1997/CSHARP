using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{

    abstract class Employee
    {
        public abstract void salary();
        public abstract void bonus();
    }
        
    class Salesman : Employee
    {
        public int sal1;
        
        public Salesman(int sal1)
        {
            this.sal1 = sal1;
        }

        public override void Bonus();
    {
        public int bon2;
              bon2 = sal2/10;
    }
    class Manager : Employee
    {
        public int sal2;

        public Manager(int sal2)
        {
            this.sal2 = sal2;
        }


        public override void bonus()
        {
              public int bon2;
              bon2 = sal2/5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        SalesMan s1 = new SalesMan(1000);
        Manager m1 = new Manager(1000);
    }
    }
}

