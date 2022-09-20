using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_20
{
    public class Pont
    {
        private int x;
        private int y;
        private static Random rnd = new Random();

        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Pont()
        {
            x = 0;
            y = 0;
        }

        

        public Pont(int n)
        {
            this.x = rnd.Next(-n, n + 1);
            this.y = rnd.Next(-n, n + 1);
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public double TavolsagAzOrigotol
        {
            get
            {
                return Math.Sqrt(this.x * this.x + this.y * this.y);
            }
        }

        public static Pont OrigotolLegtavolabb(Pont[] tomb)
        {
            double tempTavolsag = 0;
            Pont tempPont = null;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i].TavolsagAzOrigotol > tempTavolsag)
                {
                    tempTavolsag = tomb[i].TavolsagAzOrigotol;
                    tempPont = tomb[i];
                }
            }
            return tempPont;
        }

        public override string ToString()
        {
            return $"Koordináták: {{{x}; {y}}}";
        }
    }
}
