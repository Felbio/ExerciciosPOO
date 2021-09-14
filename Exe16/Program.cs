using System;

namespace Exe16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b , aux;
            Console.WriteLine("Troca de valores de variáveis inteiras");
            Console.WriteLine("Digite A: ");
            a = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite B: ");
            b = int.Parse(Console.ReadLine());            
            Console.WriteLine("Você digitou: " + a + " e " + b);

            aux = a;
            a = b;
            b = aux;              

            Console.WriteLine("Variáveis invertidas: " + a + " e " + b);
            
            Console.ReadKey();


        }
    }
}
