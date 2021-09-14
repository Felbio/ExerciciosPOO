using System;

namespace Exe19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade total de prestações:");
            int quantPrest = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de prestações pagas:");
            int prestPagas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor das prestações, em R$:");
            double valPrest = double.Parse(Console.ReadLine());

            double valorTotal = valPrest * quantPrest;
            double valorPago = prestPagas * valPrest;
            double valorDev = (quantPrest - prestPagas) * valPrest;

            Console.WriteLine("Quantidade de Prestações: " + quantPrest);
            Console.WriteLine("Quantidade de Prestações pagas: " + prestPagas);
            Console.WriteLine("Valor das Prestações: " + valPrest);
            Console.WriteLine("Valor do Consórcio: " + valorTotal);
            Console.WriteLine("Valor pago: " + valorPago);
            Console.WriteLine("Valor a pagar: " + valorDev);
            Console.ReadKey();
        }
    }
}
