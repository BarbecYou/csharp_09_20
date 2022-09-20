using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladat15();
            Console.Read();
        }

        private static void Feladat15()
        {
            double[] tomb = new double[25];
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.NextDouble() * 100 - 50;
            }

            for (int i = 1; i < tomb.Length; i+=2)
            {
                Console.WriteLine(tomb[i] * tomb[i]);
            }
        }
    }
}
