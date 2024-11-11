using GestaoDePedidos.Entities;
using System;
using System.Collections.Generic;

namespace GestaoDePedidos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            int contagem = 1;
            double ValorTotal = 0;
            char op = 'x';
            int remover = 0;
            List<Pedido> ListaDePedidos = new List<Pedido>();
            
            while (opcao != 9)
            {
                
                Console.Clear();
                Console.WriteLine("O que deseja fazer? ");
                Console.WriteLine("");
                Console.WriteLine("1) Incluir itens no pedido ");
                Console.WriteLine("2) Remover itens do pedido");
                Console.WriteLine("3) Listar itens do pedido ");
                Console.WriteLine("4) Finalizar pedido ");
                Console.WriteLine("");
                Console.WriteLine("9) Sair da aplicação");
                Console.WriteLine("");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Pedido Pedido = new Pedido();

                        Console.WriteLine("Digite o nome do produto: ");
                        Pedido.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a quantidade do produto: ");
                        Pedido.Quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o preço unitario do produto: ");
                        Pedido.Preco = double.Parse(Console.ReadLine());

                        Console.WriteLine("Item adiciodo! ");
                        Pedido.Codigo = contagem;
                        ListaDePedidos.Add(Pedido);
                        contagem = contagem +1 ;
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    case 2:
                        //remover item do pedido
                        Console.WriteLine();
                        Console.Write("Qual o nome do item que deseja remover? ");
                        foreach (Pedido obj in ListaDePedidos)
                        {
                            Console.WriteLine(obj);
                        };

                        remover = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("Tem certeza? S/N");
                        op = char.Parse(Console.ReadLine());
                        if (op == 'S' || op == 's')
                        {
                            ListaDePedidos.RemoveAt(remover -1);
                        };

                        Console.WriteLine("Item Removido!");
                        Console.ReadLine();

                        break;

                    case 3:
                        // Listar itens do pedido
                        Console.WriteLine("");
                        Console.WriteLine("Listar itens do pedido ");

                        ValorTotal = 0;
                        foreach (Pedido obj in ListaDePedidos)
                        {
                            ValorTotal += obj.Preco * obj.Quantidade;
                            Console.WriteLine(obj);
                        };
                        Console.WriteLine();
                        Console.WriteLine("Valor total do pedido: " + ValorTotal);
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    case 4:
                        // finalizar pedido
                        ValorTotal = 0;
                        foreach (Pedido obj in ListaDePedidos)
                        {

                            ValorTotal += obj.Preco * obj.Quantidade;
                            Console.WriteLine(obj);
                        };

                        Console.WriteLine();
                        Console.WriteLine("Quantidade de itens: " + ListaDePedidos.Count);
                        Console.WriteLine("");
                        Console.WriteLine("Valor total do pedido: " + ValorTotal);
                        Console.WriteLine();
                        Console.Write("Deseja finalizar o pedido: (S/N)");
                        op = char.Parse(Console.ReadLine());
                        if (op == 'S' || op == 's')
                        {
                            if (ListaDePedidos.Count == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Não é possivel finalizar o pedido sem itens");
                                Console.WriteLine();
                                Console.WriteLine();
                            }

                            if (ValorTotal >= 1000)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"O valor total do seu pedido foi de: " + ValorTotal);
                                Console.WriteLine();
                                Console.WriteLine("Voce obteve um desconto de 10%");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine($"Valor final do pedido é: " + ValorTotal * 0.9);
                                ListaDePedidos.Clear();
                                ValorTotal = 0;
                                Console.WriteLine("Pedido Finalizado!");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"O valor total do seu pedido foi de: " + ValorTotal);
                                Console.WriteLine();
                                ListaDePedidos.Clear();
                                ValorTotal = 0;
                                Console.WriteLine("Pedido Finalizado!");

                            }
                        }
                        else
                        {
                            Console.WriteLine("Cancelado");
                        };

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

            };
        }
    }
}