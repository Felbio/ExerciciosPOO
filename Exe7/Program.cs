using System;

namespace Exe7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double r, s, d;
            Console.WriteLine("Digite os valores de A, B e C:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            r = Math.Pow((a + b),2.0);
            s = Math.Pow((b + c),2.0);
            d = (r + s) / 2.0;

            Console.WriteLine("O resultado da sentença é " + d.ToString("F2") + ".");
        }
    }
}
