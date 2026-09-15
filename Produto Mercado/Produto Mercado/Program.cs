using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crie um algorítimo para cadastro de produto: Código, Fabricante, categoria, preço, estoque e valor total //
namespace Produto_Mercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int codigo, estoque;
        double preco, total;
        string fabricante, categoria;
            Console.WriteLine("Digite o código: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o fabricante: ");
            fabricante = Console.ReadLine();
            Console.WriteLine("Digite a categoria: ");
            categoria = Console.ReadLine();
            Console.WriteLine("Digite o preço: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o estoque: ");
            estoque = int.Parse(Console.ReadLine());

            total = preco * estoque;

            Console.WriteLine("O valor total em estoque é " + total);

        }
    }
}
