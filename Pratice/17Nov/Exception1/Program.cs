using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{

    //[Serializable]
    //public class MyException : System.Exception
    //{
    //    public MyException() { }
    //    public MyException(string message) : base(message) { }
    //    public MyException(string message, System.Exception inner) : base(message, inner) { }
    //    protected MyException(
    //      System.Runtime.Serialization.SerializationInfo info,
    //      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    //}
    //class practice
    //{
    //    public void handle_exception()
    //    {
    //        try
    //        {
    //            int x = 10;
    //            int y = 0;
    //            int z = x / y;
    //        }

    //        catch (ArithmeticException e)
    //        {
    //            Console.WriteLine("Arithmetic Exception occurs");
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Messi is the greatest footballer of all time");
    //        }
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //practice p1 = new practice();
            //p1.handle_exception();
            Console.ReadLine();
        }
    }


    class MyException : ApplicationException
    {
        public void MyExceptiona()
        {
            Console.WriteLine("An exception occured");
        }
        public void MyDivideException()
        {
            Console.WriteLine("Exception occured, divisor should not be zero");
        }
    }

    class TestMyException
    {
        public static void Main(String[] arg)
        {
            int d, div, res;
            div = Int32.Parse(Console.ReadLine());
            d = Int32.Parse(Console.ReadLine());
            try
            {
                if (div == 0)
                {
                    throw new MyException();
                }
            }
            catch (MyException e)
            {
                e.MyDivideException();
            }

            res = d / div;
            Console.WriteLine("Result" + res);
        }
    }
}