using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.Functii_Diferenta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieţi o funcţie care să determine diferenţa dintre două momente de timp, date prin ore, minute şi secunde
            
            int a, b, c, a1, b1, c1;
            Console.WriteLine("Introduceti 2 ore");
            a = int.Parse(Console.ReadLine());
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti 2 minute");
            b = int.Parse(Console.ReadLine());
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti 2 secunde");
            c = int.Parse(Console.ReadLine());
            c1 = int.Parse(Console.ReadLine());

            Program n = new Program();

            Console.WriteLine("Diferenta orelor este {0}", n.DifMom(a, a1));
            Console.WriteLine("Diferenta minutelor este {0}", n.DifMom(b, b1));
            Console.WriteLine("Diferenta secundelor este {0}", n.DifMom(c, c1));
        }
        public int DifMom(int num1, int num2)
        {
            int diferenta;
            diferenta = num1 - num2;
            return diferenta;
        }
    }
}
