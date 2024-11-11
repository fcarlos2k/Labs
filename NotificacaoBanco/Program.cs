using NotificacaoBanco.Entities;
using System;
using System.Collections.Generic;



namespace NotificacaoBanco // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            int contador = 0;
            List<Notificacao> notificacoes = new List<Notificacao>();
            Notificacao d = new Notificacao();

            d = new Notificacao();
            d.Id = 1;
            d.Descricao = "Abertura";
            notificacoes.Add(d);

            d = new Notificacao();
            d.Id = 2;
            d.Descricao = "Encerramento";
            notificacoes.Add(d);

            d = new Notificacao(); 
            d.Id = 3;
            d.Descricao = "Saque"; 
            notificacoes.Add(d);

            d = new Notificacao(); 
            d.Id = 4;
            d.Descricao = "Deposito";
            notificacoes.Add(d);

            List<Cliente> clientes = new List<Cliente>();
            Cliente c = new Cliente();

            c = new Cliente();
            c.Id = 1;
            c.Nome = "Primeiro cliente";
            clientes.Add(c);

            c = new Cliente();
            c.Id = 2;
            c.Nome = "Segundo cliente";
            clientes.Add(c);

            c = new Cliente();
            c.Id = 3;
            c.Nome = "Terceiro cliente";
            clientes.Add(c);




            while (opcao != 9)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE NOTIFICAÇÃO PARA BANCO DIGITAL");
                Console.WriteLine("");
                Console.WriteLine("O que deseja fazer? ");
                Console.WriteLine("");
                Console.WriteLine("1) Notificar um cliente: ");
                Console.WriteLine("2) Consultar notificações enviadas");
                //Console.WriteLine("");
                Console.WriteLine("7) Consultar Notificacoes cadastradas");
                Console.WriteLine("8) Consultar Clientes cadastrados");
                Console.WriteLine("9) Sair da aplicação");
                Console.WriteLine("");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        //Notificar um cliente

                        //Dictionary<int,Cliente> dicionario = new Dictionary<int,List<Cliente>();

                        //Dictionary<1,"Primeiro elemento">;

                        break;

                    case 7:
                        //Consultar notificações Cadastradas;

                        Console.WriteLine("");
                        Console.WriteLine("Notificações enviadas");

                        foreach (Notificacao obj in notificacoes)
                        {
                            Console.WriteLine(obj);
                        };

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ReadLine();
                        break;


                    case 8:
                        //Consultar clientes cadastrados;

                        Console.WriteLine("");
                        Console.WriteLine("Clientes cadastrados");

                        foreach (Cliente obj in clientes)
                        {
                            Console.WriteLine(obj);
                        };

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    case 9:
                        // Sair da aplicação
                        Console.WriteLine("Até mais!");
                        break;

                    default:
                        Console.WriteLine("Valor incorreto");
                        break;

                }
            }
        }
    }
}