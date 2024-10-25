using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1025feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string azonosito;
            int szulsorszam;

            do
            {
                Console.WriteLine("Addja meg a személy azonosítója első 10 jegyét: ");
                azonosito = Console.ReadLine();

                if (azonosito.Length != 10)
                {
                    Console.WriteLine("Ez az azonosító érvénytelen.");
                }
                else if (azonosito[0] % 2 == 0)
                {
                    Console.WriteLine("A személy nő");
                }
                else
                {
                    Console.WriteLine("A személy férfi");
                }

            } while(azonosito.Length != 10);

            szulsorszam = azonosito[7];

            Console.Write("A személy születési sorszáma: "+szulsorszam);
            Console.ReadKey();

        }
    }
}
