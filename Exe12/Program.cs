using System;

namespace Exe12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, dig1, dig2, dig3, nInvert;            
            
            Console.WriteLine("Inversão de um número de 3 dígitos...");
            Console.WriteLine("Digite um número de 3 dígitos (CDU):");
            n = int.Parse(Console.ReadLine());
            
            dig1 = n / 100;
            dig2 = (n % 100) / 10;
            dig3 = (n % 100) % 10;
            nInvert = dig1 + 10 * dig2 + 100 * dig3;

            Console.WriteLine("Nº original = " + n);
            Console.WriteLine("Nº invertido = " + nInvert);
            Console.ReadKey();

        }
    }
}
