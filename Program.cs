
using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const double Pi = 3.14;

            Console.WriteLine("Введіть r = ");
            string S1 = Console.ReadLine();
            int r = int.Parse(S1);

            Console.WriteLine("Введіть h = ");
            string S2 = Console.ReadLine();
            int h = int.Parse(S2);

            double S = 2 * Pi * r * h;
            double V = Pi * r * r * h;

            S = Math.Round(S, 1);
            V = Math.Round(V, 1);

            Console.WriteLine("Площа бічної поверхні: " + S);
            Console.WriteLine("Об'єм: " + V);
        }
    }
}
