using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int tempo;
        Console.WriteLine("Digite o tempo da entrega: ");
        tempo = int.Parse(Console.ReadLine());
            if (tempo <= 15)
            {
                Console.WriteLine("Entrega perfeita! Bônus garantido.");
            }
            if (tempo > 15 && tempo < 30)
            {
                Console.WriteLine("Pizza entregue a tempo, sem bônus.");
            }
            if (tempo >= 30)
            {
                Console.WriteLine("A pizza esfriou! Peter foi demitido!");
            }

        }
    }
}
