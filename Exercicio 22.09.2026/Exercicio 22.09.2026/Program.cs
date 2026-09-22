using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;
            while (opcao != 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

░██████╗░███████╗░██████╗████████╗░█████╗░░█████╗░  ██████╗░███████╗
██╔════╝░██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░██╗░█████╗░░╚█████╗░░░░██║░░░███████║██║░░██║  ██║░░██║█████╗░░
██║░░╚██╗██╔══╝░░░╚═══██╗░░░██║░░░██╔══██║██║░░██║  ██║░░██║██╔══╝░░
╚██████╔╝███████╗██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚═════╝░╚══════╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░██╗██████╗░██╗░░░░░██╗░█████╗░████████╗███████╗░█████╗░░█████╗░
██╔══██╗██║██╔══██╗██║░░░░░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██╔══██╗
██████╦╝██║██████╦╝██║░░░░░██║██║░░██║░░░██║░░░█████╗░░██║░░╚═╝███████║
██╔══██╗██║██╔══██╗██║░░░░░██║██║░░██║░░░██║░░░██╔══╝░░██║░░██╗██╔══██║
██████╦╝██║██████╦╝███████╗██║╚█████╔╝░░░██║░░░███████╗╚█████╔╝██║░░██║
╚═════╝░╚═╝╚═════╝░╚══════╝╚═╝░╚════╝░░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" 1 - Para cadastrar um livro: ");
                Console.WriteLine(" 2 - Para cadastrar um jogo: ");
                Console.WriteLine(" 3 - Para cadastrar um cliente: ");
                Console.WriteLine(" 4 - Para cadastrar um fornecedor: ");
                Console.WriteLine(" 5 - Realizar emprestimo do livro: ");
                Console.WriteLine(" 0 - Digite 0 para sair. ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        livro();
                        break;
                    case 2:
                        jogos();
                        break;
                    case 3:
                        cliente();
                        break;
                    case 4:
                        fornecedor();
                        break;
                    case 5:
                        emprestimo();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine(" Saindo do Programa! Obrigado! :)");
                        break;


                }
            }
        }
        static void livro()
        {

            int id, ano_lancamento, qtd_exemplares, isbn;
            string titulo, autor, genero;

            Console.Clear();
            Console.WriteLine(@"
██╗░░░░░██╗██╗░░░██╗██████╗░░█████╗░░██████╗
██║░░░░░██║██║░░░██║██╔══██╗██╔══██╗██╔════╝
██║░░░░░██║╚██╗░██╔╝██████╔╝██║░░██║╚█████╗░
██║░░░░░██║░╚████╔╝░██╔══██╗██║░░██║░╚═══██╗
███████╗██║░░╚██╔╝░░██║░░██║╚█████╔╝██████╔╝
╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═════╝░");
            Console.ResetColor();

            Console.WriteLine(" Digite o ID do livro: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o titulo do livro: ");
            titulo = Console.ReadLine();

            Console.WriteLine(" Digite o autor do livro: ");
            autor = Console.ReadLine();

            Console.WriteLine(" Digite o ISBN do livro: ");
            isbn = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o genero do livro: ");
            genero = Console.ReadLine();

            Console.WriteLine(" Digite o ano de lançamento do livro: ");
            ano_lancamento = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a quantidade de exemplares impressos: ");
            qtd_exemplares = int.Parse(Console.ReadLine());


            Console.WriteLine(" Cadastro realizado com Sucesso!!");
            Console.WriteLine(id);
            Console.WriteLine(titulo);
            Console.WriteLine(autor);
            Console.WriteLine(isbn);
            Console.WriteLine(genero);
            Console.WriteLine(ano_lancamento);
            Console.WriteLine(qtd_exemplares);
        }
        static void jogos()
        {

            int id, faixa_etaria, numMinJogadores, NumMaxJogadores, QuantidadeExemplares;
            string nome_jogo, categoria;

            Console.Clear();
            Console.WriteLine(@"
░░░░░██╗░█████╗░░██████╗░░█████╗░░██████╗
░░░░░██║██╔══██╗██╔════╝░██╔══██╗██╔════╝
░░░░░██║██║░░██║██║░░██╗░██║░░██║╚█████╗░
██╗░░██║██║░░██║██║░░╚██╗██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝██████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░╚═════╝░");
            Console.ResetColor();

            Console.WriteLine(" Digite o ID do jogo: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o nome do jogo: ");
            nome_jogo = Console.ReadLine();

            Console.WriteLine(" Digite a categoria do jogo: ");
            categoria = Console.ReadLine();

            Console.WriteLine(" Qual a faixa etaria indicada do jogo?: ");
            faixa_etaria = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o numero minimo de jogadores: ");
            numMinJogadores = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o numero máximos de jogadores: ");
            NumMaxJogadores = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite quantos exemplares disponiveis: ");
            QuantidadeExemplares = int.Parse(Console.ReadLine());

            Console.WriteLine(" Cadastro realizado com Sucesso!!");
            Console.WriteLine(id);
            Console.WriteLine(nome_jogo);
            Console.WriteLine(categoria);
            Console.WriteLine(faixa_etaria);
            Console.WriteLine(numMinJogadores);
            Console.WriteLine(NumMaxJogadores);
            Console.WriteLine(QuantidadeExemplares);



        }
        static void cliente()
        {
            int id;
            string Nome, CPF, telefone, Email, DataNascimento;
            bool ativo = false;


            Console.Clear();
            Console.WriteLine(@"
░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
            Console.ResetColor();

            Console.WriteLine(" Digite o ID do Usuario: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(" Nome completo do usuário: ");
            Nome = Console.ReadLine();

            Console.WriteLine(" Insira o seu CPF: ");
            CPF = Console.ReadLine();

            Console.WriteLine(" Insira o seu número de telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine(" Insira seu E-mail: ");
            Email = Console.ReadLine();

            Console.WriteLine(" Digite a sua data de nascimento: ");
            DataNascimento = Console.ReadLine();

            ativo = true;

            Console.WriteLine(" Cadastro realizado com Sucesso!!");
            Console.WriteLine(id);
            Console.WriteLine(Nome);
            Console.WriteLine(CPF);
            Console.WriteLine(telefone);
            Console.WriteLine(Email);
            Console.WriteLine(DataNascimento);

        }
        static void fornecedor()
        {

            int id;
            string RazaoSocial, CNPJ, telefone, Email, Endereco;

            Console.Clear();
            Console.WriteLine(@"
███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ResetColor();

            Console.WriteLine(" Digite o ID do Usuario: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(" Nome jurídico da empresa/editora: ");
            RazaoSocial = Console.ReadLine();

            Console.WriteLine(" Insira o CNPJ da empresa: ");
            CNPJ = Console.ReadLine();

            Console.WriteLine(" Insira o número do telefone corporativo: ");
            telefone = Console.ReadLine();

            Console.WriteLine(" Insira o E-mail comercial: ");
            Email = Console.ReadLine();

            Console.WriteLine(" Insira o endereço da empresa (Logradouro e cidade): ");
            Endereco = Console.ReadLine();


            Console.WriteLine(" Cadastro realizado com Sucesso!!");
            Console.WriteLine(id);
            Console.WriteLine(RazaoSocial);
            Console.WriteLine(CNPJ);
            Console.WriteLine(telefone);
            Console.WriteLine(Email);
            Console.WriteLine(Endereco);

        }
        static void emprestimo()
        {
            int id, ClienteId, ItemId;
            string TipoItem;
            DateTime DataEmprestimo, DataDevolucaoPrevista;
            bool devolvido;


            Console.Clear();
            Console.WriteLine(@"
███████╗███╗░░░███╗██████╗░██████╗░███████╗░██████╗████████╗██╗███╗░░░███╗░█████╗░
██╔════╝████╗░████║██╔══██╗██╔══██╗██╔════╝██╔════╝╚══██╔══╝██║████╗░████║██╔══██╗
█████╗░░██╔████╔██║██████╔╝██████╔╝█████╗░░╚█████╗░░░░██║░░░██║██╔████╔██║██║░░██║
██╔══╝░░██║╚██╔╝██║██╔═══╝░██╔══██╗██╔══╝░░░╚═══██╗░░░██║░░░██║██║╚██╔╝██║██║░░██║
███████╗██║░╚═╝░██║██║░░░░░██║░░██║███████╗██████╔╝░░░██║░░░██║██║░╚═╝░██║╚█████╔╝
╚══════╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═════╝░░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");
            Console.ResetColor();

            Console.WriteLine(" Digite o ID do Usuario: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(" Insira o código do cliente associado: ");
            ClienteId = int.Parse(Console.ReadLine());

            Console.WriteLine(" Selecione se é Livro ou Jogo: ");
            TipoItem = Console.ReadLine();

            Console.WriteLine(" Digite o código do livro ou jogo emprestado: ");
            ItemId = int.Parse(Console.ReadLine());

            Console.WriteLine(" Insira a Data/hora da retirada: ");
            DataEmprestimo = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a data de devolução prevista: ");
            DataDevolucaoPrevista = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(" O livro foi devolvido? (true/false): ");
            devolvido = bool.Parse(Console.ReadLine());


            Console.WriteLine(" Emprestimo realizado com Sucesso!!");
            Console.WriteLine(id);
            Console.WriteLine(ClienteId);
            Console.WriteLine(TipoItem);
            Console.WriteLine(ItemId);
            Console.WriteLine(DataEmprestimo);
            Console.WriteLine(DataDevolucaoPrevista);
            Console.WriteLine(devolvido);

            
        }

    }
}
