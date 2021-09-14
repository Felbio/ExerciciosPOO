using System;

namespace Exe21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da prestação");
            double valPrest = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de juros:");
            double taxaJuros =  double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de dias em atraso:");
            double atraso = double.Parse(Console.ReadLine());
            
            double valorAtualizado = valPrest + (valPrest * (taxaJuros/100) * atraso);

            Console.WriteLine("O valor atualizado da fatura é R$" + valorAtualizado.ToString("F2"));            
            
            Console.ReadKey();
        }
    }
}
