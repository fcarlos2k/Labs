using NotificacaoBanco.Entities;
using System;


namespace NotificacaoBanco // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            List<Eventos> Eventos = new List<Eventos>();

            Eventos e; 
            e.Id = 1;
            e.Nome = "Deposito";
            Eventos.Add(e);

            e.Id = 2;
            e.Nome = "Saque";
            Eventos.Add(e);



            while (opcao != 9)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE NOTIFICAÇÃO PARA BANCO DIGITAL");
                Console.WriteLine("");
                Console.WriteLine("O que deseja fazer? ");
                Console.WriteLine("");
                Console.WriteLine("1) Notificar um clinte: ");
                Console.WriteLine("2) Consultar notificações enviadas");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("9) Sair da aplicação");
                Console.WriteLine("");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        //Pedido Pedido = new Pedido();

                        break;


                    default:
                        Console.WriteLine("Valor incorreto");
                        break;

                }
            }
        }
    }
}