using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
  
    class program
    {
        static void Main(string[] args)
        {
            // C x = new C();
            // B y = new B();
            //  A z = new A();

            program p = new program();
            //p.Excep();
            int b=27;
            p.Ref(ref b);
            p.Out(out b);
            p.General(b);
        }

        public void Excep()
        {
            try
            {
                int i = -09;
                throw new Exception("Exception");
            }
            catch(MyException e)
            {
                Console.WriteLine("Message"+e.Message);
                Console.WriteLine("Message" + e.StackTrace);
            }
            catch(Exception ex)
            {
                string Path = @"D:\LogFile.txt";
                
                using (StreamWriter sw = File.AppendText(Path))
                {
                    sw.WriteLine(ex.Message);
                    sw.WriteLine(ex.StackTrace);
                }
            }
        }
     
        public void Ref(ref int a)
        {
            Console.WriteLine("ref:" + a);
        }

        public void Out(out int a)
        {
            a = 69;
            Console.WriteLine("out:"+a);
        }
        public void General( int a)
        {
            a = 56;
            Console.WriteLine("General:" + a);
        }

    }
}
