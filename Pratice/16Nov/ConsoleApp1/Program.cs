using Assembly2;
using Assembly1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly2class1 ac4 = new Assembly2class1();
            Assembly1class2 ac1 = new Assembly1class2();
            Assembly2class3 ac15 = new Assembly2class3();
            ac15.display_details();
            ac1.details();
            Console.ReadLine();
        }
    }
}
