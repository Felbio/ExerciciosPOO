using System;

/*Teorema de Pitágoras: H² = L1² + L²
2. Tem uma infinidade de números com essa combinação. Dado dois números inteiros
positivos, M e N, onde M é maior do que N, desenvolver um algoritmo para entrar com dois números 
positivos e fornecer os valores, dos lados e hipotenusa do triângulo gerados combinando M e N. 
Onde: L1 = M² − N² , L2 = 2 ∗ M ∗ N e Hipotenusa = M² * N².*/

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
        }
    }
}
