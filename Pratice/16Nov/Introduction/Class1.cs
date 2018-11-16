using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{

    public class person1
    {
        static void details()
        {
            string name;
            int age;
        }
    }
    class salesperson1 : person1
    {
        static void details(string name)
        {
            string address;
            int id;
        }
    }

    //We can overload static methods.
    class Circle
    {
        private double PI;

        public void Area(double r)
        {

            Console.WriteLine(String.Format("Area of Circle :", Math.PI * r * r));
        }
    }
    class Sphere : Circle
    {
        public new void Area(double r)
        {
            Console.WriteLine(String.Format("Area of Circle :", 4 * Math.PI * r * r));
        }
    }
    // This is called method hiding and we can achieve it by using new keyword. 

    class Circle1
    {
        private double PI;

        virtual static void Area(double r)
        {

            Console.WriteLine(String.Format("Area of Circle :", Math.PI * r * r));
        }
    }
    class Sphere1 : Circle1
    {
        override static void Area(double r)
        {
            Console.WriteLine(String.Format("Area of Circle :", 4 * Math.PI * r * r));
        }
    } //--We can not override static methods.



    }
    