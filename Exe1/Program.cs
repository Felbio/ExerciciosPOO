using System;

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
            Console.ReadKey();
            
        }
    }
}
