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
            //Operatii: adunare, scadere, inmultire, impartire, radical, modul

            double ca, a, b, r;

            Console.WriteLine("Introduceti 1 pentru a realiza o adunare, 2 pentru a realiza o scadere, 3 pentru a realiza o inmultire, 4 pentru a realiza o impartire, 5 pentru a realiza un radical sau 6 pentru a realiza un modul");
            ca = int.Parse(Console.ReadLine());

            switch (ca)
            {
                case 1:
                    Console.WriteLine("Introduceti doua numere");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    r = a + b;
                    Console.WriteLine("Adunarea numerelor este {0}", r);
                    break;
                case 2:
                    Console.WriteLine("Introduceti doua numere");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    if (a > b)
                        r = a - b;
                    else
                        r = b - a;
                    Console.WriteLine("Scaderea numerelor este {0}", r);
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
                case 5:
                    Console.WriteLine("Introduceti un numar");
                    a = int.Parse(Console.ReadLine());
                    r = Math.Sqrt(a);
                    Console.WriteLine("Rezultatul radicalului numarului este {0}", r);
                    break;
                case 6:
                    Console.WriteLine("Introduceti un numar");
                    a = int.Parse(Console.ReadLine());
                    r = Math.Abs(a);
                    Console.WriteLine("Rezultatul modulului numarului este {0}", r);
                    break;
                default:
                    Console.WriteLine("Numarul introdus nu e corect");
                    break;
            }
        }
    }
}
