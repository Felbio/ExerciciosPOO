using System;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3, t, area;
            
            Console.WriteLine("Digite os lados do triângulo:");
            l1 = double.Parse(Console.ReadLine());
            l2 = double.Parse(Console.ReadLine());
            l3 = double.Parse(Console.ReadLine());
            t = (l1 + l2 + l3) / 2;
            area = Math.Sqrt(t * (t - l1)*(t - l2)*(t - l3));
            Console.WriteLine("A área do triângulo é: " + area.ToString("F2"));
            Console.ReadKey();
        }
    }
}
