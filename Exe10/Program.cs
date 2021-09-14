using System;

namespace Exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distancia percorrida, em km: ");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de combustível consumido, em litros: ");
            double lt = double.Parse(Console.ReadLine());
            double cm = km / lt;
            Console.WriteLine("O consumo médio é " + cm.ToString("F2") 
            + " kilometros por cada um litro de combustível");


            Console.ReadKey();
        }
    }
}
