using System;
using Assembly1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly2
{
    public class Assembly2class1
    {
         internal string name = "messi";
        Assembly1class1 ac1 = new Assembly1class1();

    }
    public class Assembly2class2
    {
        public void print_details()
        {
            Assembly2class1 ac2 = new Assembly2class1();
            Console.WriteLine(ac2.name);
            Assembly1class1 ac3 = new Assembly1class1();
           // Console.WriteLine(ac3.id); -- It shows error due to it's protection level.
            

        }
    }
    
    public class Assembly2class3 : Assembly1class1
    {
        public void display_details()
        {
            Assembly2class3 ac15 = new Assembly2class3();
            Console.WriteLine(ac15.Age);
        }
    }
}
;