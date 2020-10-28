using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numar_prim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisare numar prim

            int n, i;
            bool prim = true;

            Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());

            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    prim = false;
            }

            if (prim == true)
                Console.WriteLine("Numarul introdus este un numar prim");
            else
                Console.WriteLine("Numarul introdus nu este un numar prim");
        }
    }
}
