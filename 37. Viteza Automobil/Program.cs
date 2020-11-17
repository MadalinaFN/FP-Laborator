using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.Viteza_Automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viteza unui automobil este de v km/h. Scrieti o functie prin care sa exprimaţi această viteză în m/s.

            double v;
            Console.WriteLine("Introduceti viteza automobilului in km/h");
            v = double.Parse(Console.ReadLine());

            Program n = new Program();

            Console.WriteLine("Viteza automobilului este de {0} m/s", n.VitAut(v));
        }
        public double VitAut(double num1)
        {
            double mps;
            mps = num1 * 5/18;
            return mps;
        }
    }
}
