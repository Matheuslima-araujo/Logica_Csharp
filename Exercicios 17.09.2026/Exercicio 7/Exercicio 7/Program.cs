using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores. */

            int A, B, auxiliar;

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            // Guarda o valor de A
            auxiliar = A;

            // Coloca B em A
            A = B;

            // Coloca o valor original de A em B
            B = auxiliar;

            Console.WriteLine("\nValores após a troca:");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

        }
    }
}
