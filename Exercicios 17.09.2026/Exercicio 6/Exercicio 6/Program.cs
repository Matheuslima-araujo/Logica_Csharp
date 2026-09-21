using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6-	Faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a escolha da forma de pagamento
               pelo comprador e imprima na tela o valor final do produto a ser pago. Utilize os códigos da tabela de condições de pagamento para efetuar o cálculo adequado.

               Tabela de Código de Condições de Pagamento

               1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto
               2 - À Vista no cartão de crédito, recebe 10% de desconto
               3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros
               4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10% */

            double valorProduto, valorFinal;
            int codigo;

            Console.Write("Digite o valor do produto: R$ ");
            valorProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nFormas de pagamento:");
            Console.WriteLine("1 - À Vista em Dinheiro ou Pix (15% de desconto)");
            Console.WriteLine("2 - À Vista no cartão de crédito (10% de desconto)");
            Console.WriteLine("3 - Parcelado em 2 vezes (preço normal)");
            Console.WriteLine("4 - Parcelado em 3 vezes ou mais (10% de juros)");

            Console.Write("\nDigite o código da forma de pagamento: ");
            codigo = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                valorFinal = valorProduto - (valorProduto * 0.15);
            }
            else if (codigo == 2)
            {
                valorFinal = valorProduto - (valorProduto * 0.10);
            }
            else if (codigo == 3)
            {
                valorFinal = valorProduto;
            }
            else if (codigo == 4)
            {
                valorFinal = valorProduto + (valorProduto * 0.10);
            }
            else
            {
                Console.WriteLine("Código de pagamento inválido.");
                return;
            }

            Console.WriteLine($"\nValor final a pagar: R$ {valorFinal:F2}");

        }
    }
}
