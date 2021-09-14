using System;

namespace Exe17
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Média ponderada de 4 notas...");           
            Console.WriteLine("Digite a 1º nota (peso 2):");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2º nota (peso 4):");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 3º nota (peso 6):");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 4º nota (peso 8):");
            nota4 = double.Parse(Console.ReadLine());
            media = (nota1 * 2  + nota2 * 4 + nota3 * 6 + nota4 * 8) / (2 + 4 + 6 + 8);
            Console.WriteLine("A média final do aluno é: " + media.ToString("F2"));
            if (media >= 6.0){
                Console.WriteLine("Aluno Aprovado!");
            }else{
                 Console.WriteLine("Aluno Reprovado!");
            }
            Console.ReadKey();

        }
    }
}
