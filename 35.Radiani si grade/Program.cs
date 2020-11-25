using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Radiani_si_grade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieţi o funcţie care să transforme un unghi exprimat în radiani în valoarea sa exprimată în
            // grade şi una care să facă transformarea inversă.

            int n, x;
            Console.WriteLine("Introduceti un numar exprimat in radiani");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar exprimat in grade");
            x = int.Parse(Console.ReadLine());

            Program t = new Program();

            Console.WriteLine("Radianii exprimati in grade sunt {0}", t.RadInGrade(n));
            Console.WriteLine("Gradele exprimate in radiani sunt {0}", t.GradeInRad(x));
        }

        public const double PI = 3.1415926535897931;

        public double RadInGrade(int num)
        {
            double g;
            g = num * (180 / Math.PI);
            return g;
        }

        public double GradeInRad(int num)
        {
            double r;
            r = num * (Math.PI / 180);
            return r;
        }
    }
}
