using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_autocodegrader.A系列其他
{
    internal class A0002
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer number:");// don't change
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer number:");//don' changet
            int j = Convert.ToInt32(Console.ReadLine());
            long k = (long)i * j;
            double d = (double)i / j;
            float f = 3.14159f;
            Console.WriteLine("k={0}", k);//should output correct product
            Console.WriteLine("d={0:0.000}", d);//should output correct result
            Console.WriteLine("f={0:0.000}", f);//should output 3.142
            Console.WriteLine("Type of f is {0}.", f.GetType().ToString()); //f should be float
            Console.ReadLine();
        }
    }
}
