using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_que_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Digite um número: ");
            n1 = double.Parse(Console.ReadLine());
            if (n1 > 100)
            {
                Console.WriteLine("O número é maior que 100");
            }
            else
            {
                Console.WriteLine("O número é menor que 100");
            }










        }
    }
}
