using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Bandas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Se / enquanto / para / caso
               if / while    / for / switch
            Crie um sistema de cadastro de Àlbuns de um artista / banda em que será possivel cadastrar um numero x de musicas informada pelo usuario.
            Crie um menu de opções para isso */

            
            int opcao = 0;
            while (opcao != 4) // Fazendo ficar em repetição até o usuario digitar o 4
            {


                Console.Clear(); // limpa a tela
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" 1 - Cadastrar Album da Banda");
                Console.WriteLine(" 2 - Cadastrar Album do Artista"); // Ano, Nome artista, qtd album, qtd vendas
                Console.WriteLine(" 3 - Cadastrar Músicas"); // digitar a qtd musicas (nome musica, duração, premiação)
                Console.WriteLine(" 4 - Sair do Programa");
                Console.WriteLine(" -----> ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(" Saindo do Programa !!! Tchau Tchau !! :)");
                        break;
                }


            }

        }
        static void Cadastro_Bandas()
        {
            string nomeBanda, nomeAlbum, anoAlbum, nomeArtista, premiacoes, nomeMusica;
            int qtdMusicas, qtdAlbum, qtdVendas, duracao, qtd_musicas;
            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");

            Console.ResetColor();

            Console.WriteLine(" Digite o nome da Banda: ");
            nomeBanda = Console.ReadLine();

            Console.WriteLine(" Digite o nome do Album: ");
            nomeAlbum = Console.ReadLine();

            Console.WriteLine(" Digite o numero de músicas: ");
            qtdAlbum = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a quantidade de músicas: ");
            qtdMusicas = int.Parse(Console.ReadLine());

            
            Console.WriteLine(" Cadastro realizado com Sucesso!!");
            Console.WriteLine(nomeBanda);
            Console.WriteLine(nomeAlbum);
            Console.WriteLine(qtdMusicas);


            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░░╚════╝░

░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║
███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝");

            Console.ResetColor();

            Console.WriteLine(" Digite o ano do Album: ");
            anoAlbum = Console.ReadLine();

            Console.WriteLine(" Digite o nome do Artista: ");
            nomeArtista = Console.ReadLine();

            Console.WriteLine(" Digite quantos Albuns lançados: ");
            qtdAlbum = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite quantos foram vendidos: ");
            qtdVendas = int.Parse(Console.ReadLine());



            Console.WriteLine(" Cadastro realizado com Sucesso!!");
            Console.WriteLine(anoAlbum);
            Console.WriteLine(nomeArtista);
            Console.WriteLine(qtdAlbum);
            Console.WriteLine(qtdVendas);


            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░█████╗░░██████╗
████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗██╔════╝
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝███████║╚█████╗░
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██╔══██║░╚═══██╗
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██║░░██║██████╔╝
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝╚═════╝░");
            
            Console.ResetColor();

            Console.WriteLine(" Digite quantas músicas serão cadastradas: ");
            qtd_musicas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdMusicas; i++)
            {

                Console.WriteLine(" Digite o nome da Música: ");
                nomeMusica = Console.ReadLine();

                Console.WriteLine(" Digite a duração da Música: ");
                duracao = int.Parse(Console.ReadLine());

                Console.WriteLine(" Digite quantos premios essa Música ganhou: ");
                premiacoes = Console.ReadLine();



                Console.WriteLine(" Cadastro realizado com Sucesso!!");
                Console.WriteLine(nomeMusica);
                Console.WriteLine(duracao);
                Console.WriteLine(premiacoes);
            }
        }
    }
}
