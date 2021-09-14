using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {                      
            double L1, L2, hipotenusa;
            Console.WriteLine("Digite dois números:");
            double M = int.Parse(Console.ReadLine());
            double N = int.Parse(Console.ReadLine());
            L1 = Math.Pow(M,2) - Math.Pow(N,2);
            L2 = 2 * M * N;
            hipotenusa = Math.Pow(M,2) + Math.Pow(N,2); 
            Console.WriteLine("L1 = " + L1.ToString("F2"));
            Console.WriteLine("L2 = " + L2.ToString("F2"));
            Console.WriteLine("Hipotenusa = " + hipotenusa.ToString("F2"));
            Console.ReadKey();
        }
    }
}
