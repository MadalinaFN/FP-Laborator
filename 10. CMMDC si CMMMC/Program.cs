using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CMMDC_si_CMMMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Să se determine cel mai mare divizor comun şi cel mai mic multiplu comun pentru două numere întregi a şi b.

            int a, b, a1, b1, cmmmc;

            Console.WriteLine("Introduceti doua numere");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            a1 = a;
            b1 = b;

            while (a1 != b1)
            {
                if (a1 > b1) a1 = a1 - b1;
                else b1 = b1 - a1;
            }

            cmmmc = (a * b) / a1;

            Console.WriteLine($"Cel mai mare divizor comun este {a1} si cel mai mic multiplu comun este {cmmmc}");
        }
    }
}
