using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.Cub_Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti o functie care să se verifice dacă un număr natural este sau nu cub perfect.

            int n;
            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());

            Program t = new Program();

            Console.WriteLine(t.CubPerfect(n));
        }
        public int CubPerfect(int num)
        {
            double p, e = 0.00000001;
            p = Math.Pow(num * 1.0, 1.0 / 3);
            
            int x = (int)p;
            if (x + 1 - p < e)
                x++;

            if (x * x * x == num)
                Console.WriteLine("Numarul este cub perfect");
            else
                Console.WriteLine("Numarul nu este cub perfect");
            return num;
        }
    }
}
