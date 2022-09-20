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
            //Feladat15();

            PontFeladat();

            Console.Read();
        }

        private static void PontFeladat()
        {
            Pont pont1 = new Pont();
            Pont pont2 = new Pont(3, 4);
            Pont pont3 = new Pont(100);

            Console.WriteLine(pont1);
            Console.WriteLine(pont2);
            Console.WriteLine(pont3);

            Pont[] tomb = new Pont[100];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = new Pont(10);
            }
            foreach (Pont pont in tomb)
            {
                Console.WriteLine(pont);
            }

            Console.WriteLine($"{Pont.OrigotolLegtavolabb(tomb)} tavolsaga: {Pont.OrigotolLegtavolabb(tomb).TavolsagAzOrigotol:0.000}");

            Console.WriteLine(tomb.First(x => x.TavolsagAzOrigotol == tomb.Max(y => y.TavolsagAzOrigotol)));
            
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
