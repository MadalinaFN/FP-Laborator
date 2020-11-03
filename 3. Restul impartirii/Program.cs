using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Restul_impartirii
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fie i,j,k. Să se determine restul împărţirii numărului natural i^j la k

            double i, j, k, numnat, restimp;

            Console.WriteLine("Introduceti valoarea pentru i ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru j ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea pentru k ");
            k = int.Parse(Console.ReadLine());

            numnat = Math.Pow(i, j);
            restimp = numnat % k;

            Console.WriteLine($"Restul impartirii numarului natural {numnat} este {restimp}");
        }
    }
}
