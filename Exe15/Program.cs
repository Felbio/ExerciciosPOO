using System;

namespace Exe15
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, P, n, valor_acumulado, lucro;
            //i é a taxa; P é a aplicação mensal e n é o nº de meses
            Console.WriteLine("Rendimento de depoósitos fixos numa aplicação financeira");
            Console.WriteLine("Digite o valor CONSTANTE da aplicação mensal, em R$:");
            P = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da taxa, em % :");
            i = double.Parse(Console.ReadLine());
            i = i / 100; //transformando a porcetagem
            Console.WriteLine("Digite o nº de meses, para calcular o rendimento:");
            n = double.Parse(Console.ReadLine());
            valor_acumulado = (Math.Pow(1 + i, n) - 1) * P / i;
            Console.WriteLine("Rendimento acumulado = R$ " + Math.Round(valor_acumulado,2));
            lucro = valor_acumulado - P *n;
            Console.WriteLine("Lucro = R$ " + Math.Round(lucro,2));
            Console.ReadKey();
        }
    }
}
