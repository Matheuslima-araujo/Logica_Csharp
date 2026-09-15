using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_maior_ou_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, maior, menor;
            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            maior = n1 + 1;
            menor = n1 - 1;
            Console.WriteLine("O antessesor é " + menor);
            Console.WriteLine("O sucessor é " + maior);  











        }
    }
}
