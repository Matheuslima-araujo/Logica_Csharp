using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo que calcule a quantidade de litros de combustível gastos em uma viagem, sabendo que o carro faz 12km com um litro. Deve-se fornecer ao usuário o tempo que será gasto na viagem a sua velocidade média, distância percorrida e a quantidade de litros utilizados para fazer a viagem.
               Fórmula: distância = tempo x velocidade.
               litros usados = distância / 12. */

            double tempo, velocidadeMedia, distancia, litrosUsados;

            Console.Write("Digite o tempo da viagem (em horas): ");
            tempo = double.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade média (em km/h): ");
            velocidadeMedia = double.Parse(Console.ReadLine());

            distancia = tempo * velocidadeMedia;

            litrosUsados = distancia / 12;

            Console.WriteLine();
            Console.WriteLine($"Distância percorrida: {distancia:F2} km");
            Console.WriteLine($"Litros de combustível utilizados: {litrosUsados:F2} litros");
        
        }
    }
}
