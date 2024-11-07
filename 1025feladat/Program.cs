using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1025feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int jelenlegiEv = DateTime.Now.Year;
            string azonosito;
            string azonosito2;

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

            string szulevString = azonosito[3] + azonosito[4];
            int szulevInt = Convert.ToInt32(szulevString);
            int Kor = jelenlegiEv - szulevInt;

            Console.Write("A személy születési sorszáma: " + azonosito[7] + azonosito[8] + azonosito[9]);
            Console.Write($"A személy a {Kor} születésnapját ünnepli ebben az évben");
            do
            {
                Console.WriteLine("Addja meg a személy azonosítója első 10 jegyét: ");
                azonosito2 = Console.ReadLine();

                if (azonosito2.Length != 10)
                {
                    Console.WriteLine("Ez az azonosító érvénytelen.");
                }
                else if (azonosito2[0] % 2 == 0)
                {
                    Console.WriteLine("A személy nő");
                }
                else
                {
                    Console.WriteLine("A személy férfi");
                }

            } while (azonosito2.Length != 10);

            Console.ReadKey();
        }
    }
}
