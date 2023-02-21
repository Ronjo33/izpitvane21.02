using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._2023_izpitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ArrayMas(num);
            Edinred(num);
        }

        private static void Edinred(int[] num)
        {
            Console.WriteLine(num+ ",");
        }

        private static void ArrayMas(int[] array)
        {
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < array.Length; i++)
            {


                sum = sum + array[i];
                
            }
            avg= sum / array.Length;
            Console.WriteLine($"{avg}");
        }
    }
}
