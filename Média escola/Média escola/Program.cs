using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Insira as 4 notas de um aluno e calcule a média 
namespace Média_escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            string nome;
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            n4 = double.Parse(Console.ReadLine());

            media = (n1 +  n2 + n3 + n4) / 4;

            Console.WriteLine("O nome do aluno é" + nome + "e a média dele é " + media);
        }
    }
}
