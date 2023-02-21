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

            //a
            Console.WriteLine("sredno aretmeti4no");
            ArrayMas(num);
            Console.WriteLine();
            //b
            Console.WriteLine("Cislata na edin red");
            Edinred(num);
            Console.WriteLine();
            //v
            Console.WriteLine("broi nuli ");
            BroinaNuli(num);
            Console.WriteLine();
            //d
            Console.WriteLine("vsi4ki 4isla ot array na edin red");
            Novred(num);
            Console.WriteLine();
        }

        private static void Novred(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i + 1}] = {array[i]}");
            }
        }

        private static void BroinaNuli(int[] nula)
        {
            int numnula = 0;
            for (int i = 0; i < nula.Length; i++)
            {
                if (nula[i]==0)
                {
                    numnula++;
                }
                
            }
            Console.WriteLine(numnula);
        }

        private static void Edinred(int[] array)
        {
            Console.Write(string.Join(",",array));
            Console.WriteLine();
        }

        private static void ArrayMas(int[] array)
        {
            float sum = 0;
            float avg = 0;
            for (int i = 0; i < array.Length; i++)
            {


                sum = sum + array[i];
                
            }
            avg= sum / array.Length;
            Console.WriteLine($"{avg:f2}");
        }
    }
}
