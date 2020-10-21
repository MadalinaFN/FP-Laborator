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

            Console.WriteLine("Introduceti numarul 1 pentru a converti grade celsius in fahrenheit sau 2 pentru a converti grade fahrenheit in celsius");
            ca = int.Parse(Console.ReadLine());

            switch (ca)
            {
                case 1:
                    Console.WriteLine("Introduceti un numar care sa reprezinte gradele celsius");
                    C = int.Parse(Console.ReadLine());
                    F = C * 1.8 + 32;
                    Console.WriteLine("Gradele exprimate in fahrenheit sunt {0}", F);
                    break;
                case 2:
                    Console.WriteLine("Introduceti un numar care sa reprezinte gradele fahrenheit");
                    F = int.Parse(Console.ReadLine());
                    C = (F - 32) / 1.8;
                    Console.WriteLine("Gradele exprimate in celsius sunt {0}", C);
                    break;
                default:
                    Console.WriteLine("Numarul introdus nu e corect");
                    break;
            }
        }
    }
}
