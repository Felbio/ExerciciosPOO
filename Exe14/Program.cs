using System;

namespace Exe14
{
    class Program
    {
        static void Main(string[] args)
        {
            double descDez, txAlug, txDia, txKm, kmRod ;
            int dia; 
            descDez = 10;
            txAlug = 90.00;
            txDia = 25.00;
            txKm = 0.25;
            
            Console.WriteLine("Digite a quantidade de dias: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os quilometros rodados: ");
            kmRod = double.Parse(Console.ReadLine());

            double aluguel = txAlug * dia;
            double valKm = txKm * kmRod;
            double totDia = txDia * dia;
            double desconto = (aluguel + valKm + totDia) * (descDez /100);            
            double valTot = (aluguel + valKm + totDia) - desconto;

             Console.WriteLine("Número de dias: "  + dia);
             Console.WriteLine("Valor das diárias: R$" + totDia);
             Console.WriteLine("Valor do aluguel: R$" + aluguel);
             Console.WriteLine("Valor da quilometragem rodada: R$" + valKm);
             Console.WriteLine("Valor do desconto: R$" + desconto);
             Console.WriteLine("Valor total: R$" + valTot);            
            Console.ReadKey();
        }
    }
}
