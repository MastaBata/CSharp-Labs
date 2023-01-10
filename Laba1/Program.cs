using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static int TryCatchInt(int r)
        {
            while (true)
            {
                try
                {
                    r = int.Parse(Console.ReadLine());
                    return r;
                   
                }
                catch
                {
                    Console.WriteLine("Enter number!");
                }
            }
            double S = 4 * 3.14 * 2 * r;
            Console.WriteLine("S:");
            return S;
            double V = (4 / 3) * 3.14 * (r * r * r);
            return V;
        }
        
    }
}
