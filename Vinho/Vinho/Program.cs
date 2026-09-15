using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Construa um programa que permita fazer o levantamento do estoque de vinhos de uma adega, tendo como dados de entrada tipos de vinho, sendo:
            "t" para tinto e "b" para branco. Como a quantidade de vinhos é desconhecida, ultilize a letra
            "f" para finalizar. Após finalizar o programa deve mostrar a quantidade de cada vinho da adega. */
        
        int tintos = 0;
        int brancos = 0;
        string tipo;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@"
░█████╗░██████╗░███████╗░██████╗░░█████╗░  ██████╗░███████╗  ██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░░██████╗
██╔══██╗██╔══██╗██╔════╝██╔════╝░██╔══██╗  ██╔══██╗██╔════╝  ██║░░░██║██║████╗░██║██║░░██║██╔══██╗██╔════╝
███████║██║░░██║█████╗░░██║░░██╗░███████║  ██║░░██║█████╗░░  ╚██╗░██╔╝██║██╔██╗██║███████║██║░░██║╚█████╗░
██╔══██║██║░░██║██╔══╝░░██║░░╚██╗██╔══██║  ██║░░██║██╔══╝░░  ░╚████╔╝░██║██║╚████║██╔══██║██║░░██║░╚═══██╗
██║░░██║██████╔╝███████╗╚██████╔╝██║░░██║  ██████╔╝███████╗  ░░╚██╔╝░░██║██║░╚███║██║░░██║╚█████╔╝██████╔╝
╚═╝░░╚═╝╚═════╝░╚══════╝░╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═════╝░");
            Console.ResetColor();
            
            Console.WriteLine("Digite o tipo de vinho: ");
            Console.WriteLine("t = Tinto");
            Console.WriteLine("b = Branco");
            Console.WriteLine("f = Finalizar");

        tipo = Console.ReadLine();

            while (tipo != "f")
            {
                if (tipo == "t")
                {
                    tintos++;
                }
                else if (tipo == "b")
                {
                    brancos++;
                }
                else
                {
                    Console.WriteLine("Tipo inválido!");
                }
                tipo = Console.ReadLine();
            }
            Console.WriteLine("\nEstoque da adega:");
            Console.WriteLine("Vinhos tintos: " + tintos);
            Console.WriteLine("Vinhos brancos: " + brancos);

        }
    }
}
