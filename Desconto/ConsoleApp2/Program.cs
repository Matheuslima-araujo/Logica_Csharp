using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5. Calcular desconto
            Um produto com preço acima de 100 reais tem um desconto de 10%. Caso contrario, o desconto é de 5%.
            Dado o preço, calcule o valor do desconto.
            - Entrada: 120
            - Saída esperada: 12 reais de desconto
            */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
██████╗░███████╗░██████╗░█████╗░░█████╗░███╗░░██╗████████╗░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗
██║░░██║█████╗░░╚█████╗░██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██║░░██║
██║░░██║██╔══╝░░░╚═══██╗██║░░██╗██║░░██║██║╚████║░░░██║░░░██║░░██║
██████╔╝███████╗██████╔╝╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░╚█████╔╝
╚═════╝░╚══════╝╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();
            
            double preco, desconto;

            Console.WriteLine("Digite o preço do produto para saber o desconto: ");
            preco = double.Parse(Console.ReadLine());

            if (preco > 100)
            {
                desconto = preco * 0.10;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine("Valor do desconto: R$ " + desconto);





        }
    }
}
