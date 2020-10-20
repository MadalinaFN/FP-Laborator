using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisare grade celsius in fahrenheit

            double F,C,ca;

            Console.WriteLine("Introduceti numarul 1 pentru grade celsius mai mici decat 50 sau 2 pentru grade celsius mai mari decat 50");
            ca = int.Parse(Console.ReadLine());

            switch (ca)
            {
                case 1:
                    Console.WriteLine("Introduceti un numar mai mic decat 50 care sa reprezinte gradele celsius");
                    C = int.Parse(Console.ReadLine());
                    F = C * 1.8 + 32;
                    if (C < 50)
                    Console.WriteLine("Gradele exprimate in fahrenheit sunt {0}", F);
                    break;
                case 2:
                    Console.WriteLine("Introduceti un numar mai mare decat 50 care sa reprezinte gradele celsius");
                    C = int.Parse(Console.ReadLine());
                    F = C * 1.8 + 32;
                    Console.WriteLine("Gradele exprimate in fahrenheit sunt {0}", F);
                    break;
                default:
                    Console.WriteLine("Numarul introdus nu e corect");
                    break;
            }
        }
    }
}
