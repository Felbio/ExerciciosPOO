using System;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Dado a Matriz, digite os dados para se obter a Determinante:");
            Console.WriteLine("a11:");
            double a11 = double.Parse(Console.ReadLine());
            Console.WriteLine("a12:");
            double a12 = double.Parse(Console.ReadLine());
            Console.WriteLine("a21:");
            double a21 = double.Parse(Console.ReadLine());
            Console.WriteLine("a22:");
            double a22 = double.Parse(Console.ReadLine());

            double det = (a11 * a22) - (a21 * a12);
            Console.WriteLine("Determinante é igual a:" + det.ToString("F2")); 
            Console.ReadKey();

        }
    }
}
