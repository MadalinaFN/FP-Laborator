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
            //Afisare grade celsius in fahrenheit si invers

            double ca, a, b, r;

            Console.WriteLine("Introduceti 1 pentru a realiza o suma, 2 pentru a realiza o resta, 3 pentru a realiza o inmultire sau 4 pentru a realiza o impartire");
            ca = int.Parse(Console.ReadLine());

            switch (ca)
            {
                case 1:
                    Console.WriteLine("Introduceti doua numere");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    r = a + b;
                    Console.WriteLine("Suma numerelor este {0}", r);
                    break;
                case 2:
                    Console.WriteLine("Introduceti doua numere");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    if (a > b)
                        r = a - b;
                    else
                        r = b - a;
                    Console.WriteLine("Resta numerelor este {0}", r);
                    break;
                case 3:
                    Console.WriteLine("Introduceti doua numere");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    r = a * b;
                    Console.WriteLine("Inmultirea numerelor este {0}", r);
                    break;
                case 4:
                    Console.WriteLine("Introduceti doua numere");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    if (a > b)
                        r = a / b;
                    else
                        r = b / a;
                    Console.WriteLine("Impartirea numerelor este {0}", r);
                    break;
                default:
                    Console.WriteLine("Numarul introdus nu e corect");
                    break;
            }
        }
    }
}
