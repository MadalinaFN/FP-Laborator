using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Vectori_Patrat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Să se scrie o funcție care calculează pătratul elementelor memorate într-un tablou.

            int n;
            Console.WriteLine("Cate elemente sa aiba vectorul?");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            Program t = new Program();

            Console.WriteLine(t.Patrat(v, n));
        }
        public int Patrat(int[] v, int n)
        {
            int i, patrat;
            int[] b = new int[n];

            for (i = 0; i < n; i++)
            {
                patrat = v[i] * v[i];
                b[i] = patrat;
                Console.Write($"{b[i]} ");
            }
            Console.WriteLine();
            Console.Write("Program finalizat ");
            return 0;
        }
    }
}
