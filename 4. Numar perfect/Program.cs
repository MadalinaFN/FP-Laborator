using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numar_perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            // Să se verifice dacă numărul n este perfect. (Un număr n este perfect dacă este egal cu suma
            // divizorilor lui diferiţi de n; exemplu: 6 = 1 + 2 + 3).

            int n, suma = 0;

            Console.WriteLine("Introduceti numarul n ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    suma = suma + i;
                }
            }
            if (n == suma)
            {
                Console.WriteLine($"Numarul {n} este perfect");
            }
            else
            {
                Console.WriteLine($"Numarul {n} nu este perfect");
            }
        }
    }
}
