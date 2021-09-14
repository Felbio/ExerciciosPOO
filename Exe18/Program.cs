using System;


namespace Exe18
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14159;
            Console.WriteLine("Digite o ângulo: ");
            double an = double.Parse(Console.ReadLine());            
            
            double rad = an * (PI/180);            
            double seno = Math.Sin(rad);
            double coseno = Math.Cos(rad);
            double tangen = Math.Tan(rad);

            
            Console.WriteLine("Seno: " + seno.ToString("F2") + ", Cosseno: "+ coseno.ToString("F2") 
            +" e Tangente: "+ tangen.ToString("F2"));
            
           //Math.Sin() Math.Cos() Math.Atan()          
            Console.ReadKey();        
        }
    }
}
