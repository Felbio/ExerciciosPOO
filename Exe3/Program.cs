using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.WriteLine("Digite o valor de a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de a:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de a:");
            c = double.Parse(Console.ReadLine());
            delta = Math.Pow(b , 2.00) - 4.00 * a * c;
            
            if(delta < 0.00){
                Console.WriteLine("Delta inexistente!");
            }else{
                Console.WriteLine("O valor de Delta é: " + delta.ToString("F2"));
            }
            Console.ReadKey();
        }
    }
}
