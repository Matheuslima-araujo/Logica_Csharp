using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 2-	Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse 
        usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00). */
        

        double salarioMinimo = 1518.00;

            Console.Write("Digite o seu salário: R$ ");
            double salarioUsuario = double.Parse(Console.ReadLine());
            double quantidade = salarioUsuario / salarioMinimo; 
            Console.WriteLine($"Você ganha aproximadamente {quantidade:F2} salários mínimos.");

        }
    }
}
