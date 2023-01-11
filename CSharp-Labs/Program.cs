using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter R: ");
            double R = int.Parse(Console.ReadLine());

            double S = 4 * Math.PI * Math.Pow(R, 2);
            Console.WriteLine($"Result {S}");
            double V = (4/3) * Math.PI * Math.Pow(R, 3);
            Console.WriteLine($"Result {V}");
        }
    }
}
