using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, 
    caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
    imprimir seu valor na tela. */



            int A, B, C;

            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
            }
            else
            {
                C = A * B;
            }
            Console.WriteLine(" O valor de C é: " + C);


        }
    }
}
