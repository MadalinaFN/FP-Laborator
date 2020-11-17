using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CMmN_si_CMMN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieţi un program care să citească mai multe numere întregi, până la întâlnirea lui zero, 
            // şi să determine cel mai mic număr şi cel mai mare număr citit.

            int max = 0, min = 0, n;

            do
            {
                Console.WriteLine("Dati un numar");
                n = int.Parse(Console.ReadLine());

                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
            }
            while (n != 0);

            Console.WriteLine($"Cel mai mic numar este {min} si cel mai mare numar este {max}");
        }
    }
}
