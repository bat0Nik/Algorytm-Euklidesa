using System;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Algorytm Euklidesa
        /// </summary>
        /// <param name="a">Pierwsza liczba</param>
        /// <param name="b">Druga liczba</param>
        /// <returns>Najwyższy wspólny dzielnik</returns>
        static int NWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int a, b;
            try
            {
                Console.WriteLine("Podaj a");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj b");
                b = int.Parse(Console.ReadLine());

                int wynik = NWD(a, b);
                Console.WriteLine("Wynik: " + wynik);
            }
            catch (FormatException Ex)
            {
                Console.WriteLine("Podano zmienną w złym formacie");
            }
        }
    }
}
