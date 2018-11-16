using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{
    public class Assembly1class1
    {
        internal int id = 10;
        protected internal int Age = 31;
    }

    public class Assembly1class2 
    {
        public void details()
        {
            Assembly1class1 ac1 = new Assembly1class1();
            Console.WriteLine(ac1.id);

            Assembly1class1 ac11 = new Assembly1class1();
            Console.WriteLine(ac11.Age);
        }
    }

}
