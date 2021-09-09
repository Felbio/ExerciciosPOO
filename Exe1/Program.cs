using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a tua idade: ");
            double idade = int.Parse(Console.ReadLine());
            double batida = idade * 365.25 * 24 * 60 *60;
            Console.WriteLine("O coração em " + idade + " anos, irá bater " + batida + " de vezes.");
            
        }
    }
}
