using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.*/
        
        Console.WriteLine("Digite um valor: R$ ");
        double valor = double.Parse(Console.ReadLine());

        double novoValor = valor * 1.05;

        Console.WriteLine($" O valor com reajuste de 5% é: R$ {novoValor:F2}");

        }
    }
}
