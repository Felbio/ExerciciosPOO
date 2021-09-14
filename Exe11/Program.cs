using System;

namespace Exe11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor para compra do dolar:");
            double dolar  = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da cotação do dolar:");
            double cotDolar  = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual do ICMS:");
            double icms  = double.Parse(Console.ReadLine());

            double valorPagar = (dolar * cotDolar) + (dolar * cotDolar * (icms/100));

            Console.WriteLine("O valor a pagar será R$" + valorPagar.ToString("F2") + ".");
            Console.ReadKey();
        }
    }
}
