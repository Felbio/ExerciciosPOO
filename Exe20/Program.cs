using System;

namespace Exe20
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pi = 3.14159;
            Console.WriteLine("Digite o valor do raio da esfera:");
            double raio = double.Parse(Console.ReadLine());

            double comp = 2 * Pi * raio;
            double area = Pi * Math.Pow(raio,2);
            double vol = ((comp/4)*3) * Pi * Math.Pow(raio,3);

            Console.WriteLine("Dimensão da esfera: " + comp.ToString("F2") + "m.");
            Console.WriteLine("Área da esfera: " + area.ToString("F2") + "m².");
            Console.WriteLine("Volume da esfera: " + vol.ToString("F2") + "m³");
            Console.ReadKey();

        }
    }
}
