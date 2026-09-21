using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo que efetue o cálculo do salário líquido de um professor. As informações fornecidas serão: valor da hora aula, número de aulas lecionadas no mês e percentual de desconto do INSS. 
            Imprima na tela o salário líquido final. */

            double valorHora, numeroAulas, percentualInss;
            double salarioBruto, descontoInss, salarioLiquido;

            Console.Write("Digite o valor da hora aula: R$ ");
            valorHora = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de aulas lecionadas no mês: ");
            numeroAulas = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de desconto do INSS: ");
            percentualInss = double.Parse(Console.ReadLine());

            salarioBruto = valorHora * numeroAulas;

            descontoInss = salarioBruto * percentualInss / 100;

            salarioLiquido = salarioBruto - descontoInss;

            Console.WriteLine("Salário líquido: R$ " + salarioLiquido.ToString("F2"));
        }

    }
}
