using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int max = arr[0, 0];
            int min = arr[0, 0];
            int[] min_max_location = new int[2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        min_max_location[0] = i;
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        min_max_location[1] = i;
                    }
                }
            }

            int temp;
            for (int i = 0; i < m; i++)
            {
                temp = arr[min_max_location[0], i];
                arr[min_max_location[0], i] = arr[min_max_location[1], i];
                arr[min_max_location[1], i] = temp;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
