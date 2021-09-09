using System;
/*O coração humano bate em média uma vez por segundo. Desenvolva um algoritmo para calcular e escrever quantas vezes o
coração de uma pessoa baterá se viver X anos. Dado de entrada: idade da pessoa (inteiro em anos). 
onsiderações: 1 ano = 365,25 dias, 1 dia = 24 horas, 1 hora = 60 minutos e 1 minuto = 60 segundos.*/
namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a tua idade: ");
            double anos = int.Parse(Console.ReadLine());
            double batida = anos * 365.25 * 24 * 60 *60;
            Console.WriteLine("O coração em " + anos + " anos, terá batido " + batida + " vezes.");
            
        }
    }
}
