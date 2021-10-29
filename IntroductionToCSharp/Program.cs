using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To C Sharp");
            Console.WriteLine("Enter Your Name:");
            //Console.ReadLine();
            string user = Console.ReadLine();
            Console.WriteLine("Hello {0}", user);
            Console.WriteLine("Hello " + user);
            Console.WriteLine(""  + user);

            int i = 0;
            Console.WriteLine("Min value :{0} ", int.MinValue);
            Console.WriteLine("Min value :{0} ", int.MaxValue);

            string Name = "Samu";
            Console.WriteLine(Name);

            string Name1="\"Samu1\"";
            Console.WriteLine(Name1);

            int p = 100;
            float f = p;

            Console.WriteLine(f);
            float a = 100.25F;
            int b = (int)f;
            Console.WriteLine(b);

            int[] array1 = new int[3] ;
            int[] array2 = new int[4];
            string[] arraystring = new string[7];

                                 
        }
    }
}
