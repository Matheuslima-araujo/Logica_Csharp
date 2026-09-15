using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_entre_10_e_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Digite um número: ");
            n1 = double.Parse(Console.ReadLine());
            if (n1 >= 10 && n1 <= 50)
            {
                Console.WriteLine("O número está entre 10 e 50.");
            }
            else
            {
                Console.WriteLine("O número não está entre 10 e 50.");
            }








        }
    }
}
