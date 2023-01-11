using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number a: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Number b: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Number c: ");
            double c = int.Parse(Console.ReadLine());


            if (a == -b || a == -c || c == -b)
            {
                Console.Write("true ");
            }
            else
            {
                Console.Write("false ");
            }
        }
    }
}
