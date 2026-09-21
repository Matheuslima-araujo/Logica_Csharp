using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        { /* Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.*/

            Console.WriteLine("Digite o primeiro valor (True ou False):");
            bool valor1 = bool.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor (True ou False):");
            bool valor2 = bool.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Resultado ---");


            if (valor1 && valor2)
            {
                Console.WriteLine("Ambos os valores são **VERDADEIRO**.");
            }
            else if (!valor1 && !valor2)
            {
                Console.WriteLine("Ambos os valores são **FALSO**.");
            }
            else
            {
                Console.WriteLine("Os valores são **diferentes** (um é verdadeiro e o outro é falso).");

            }

        }
    }
}
