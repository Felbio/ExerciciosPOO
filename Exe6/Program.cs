using System;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            Console.WriteLine("Digite o raio do cilindro em metros:");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do cilindro em metros:");
            double alt = double.Parse(Console.ReadLine());
            double area = Math.Pow(PI,2) * raio *(alt + raio);
            double vol = PI * Math.Pow(raio,2) * alt;
                        
            Console.WriteLine("Área é igual a " + area.ToString("F2") + "m³");
            Console.WriteLine("Volume é igual a " + vol.ToString("F2") + "m³");
            Console.ReadKey();
        }
    }
}
