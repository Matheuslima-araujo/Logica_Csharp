using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.
               Fórmula: C = (5 * ( F-32) / 9). */

            double fahrenheit, celsius;

            Console.Write("Digite a temperatura em Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (5 * (fahrenheit - 32)) / 9;

            Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);
            Console.WriteLine("Temperatura em Celsius: " + celsius);

        }
    }
}
