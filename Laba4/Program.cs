using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 20);
            }

            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
        }
    }
}