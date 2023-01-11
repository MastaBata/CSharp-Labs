using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nn;
            int nk;
            int k;
            double res = 0;

            Console.WriteLine("Enter nn: ");
            nn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter nk: ");
            nk = int.Parse(Console.ReadLine());

            for (k = nn; k < nk; k++)
            {
                if (0 <= nn & nn <= nk)
                {
                    res += (Math.Pow(k, 2) - 3) / ((Math.Pow(k, 2) - (Math.Pow(-1, k)) * k + 3));

                }

                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }

            Console.WriteLine(res);
        }
    }
}
