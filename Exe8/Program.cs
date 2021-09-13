using System;

namespace Exe8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de dias: ");
            int idade = int.Parse(Console.ReadLine());
            int ano = idade / 365;
            int mes = (idade % 365) / 30;
            int dia = ((idade % 365) % 30) ;

            Console.WriteLine("Você têm " + ano + " anos, " + mes + " meses e " + dia + " dias.");

        }
    }
}
