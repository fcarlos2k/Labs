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
            List<Pedido> ListaDePedidos = new List<Pedido>();

            while (opcao != 9)
            {
                Console.Clear();
                Console.WriteLine("O que deseja fazer? ");
                Console.WriteLine("");
                Console.WriteLine("1) Incluir itens no pedido ");
                Console.WriteLine("2) Remover itens do pedido");
                Console.WriteLine("3) Listar itens do pedido ");
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
                        
                        ListaDePedidos.Add(Pedido);

                        Console.WriteLine("Item adiciodo! ");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;
                    
                    case 2:
                        //remover item do pedido
                        Console.WriteLine();
                        Console.WriteLine("Qual o nome do item que deseja remover? ");
                        foreach (Pedido obj in ListaDePedidos)
                        {
                            Console.WriteLine(obj);
                        };


                        Console.WriteLine();
                        //Console.WriteLine("Tem certeza? S/N");

                        if (Console.ReadLine() == "S" || Console.ReadLine() == "s")
                        {
                            //ListaDePedidos.Remove(Console.ReadLine());
                        };
                        Console.ReadLine();
                        break;
                    
                    case 3:
                        // Listar itens do pedido
                        Console.WriteLine("");
                        Console.WriteLine("Listar itens do pedido ");

                        double ValorTotal = 0;
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

                    case 9:
                        // Sair da aplicação
                        Console.WriteLine("Até mais!");
                        break;
                    default:
                        Console.WriteLine("Valor incorreto");
                        break;
                }

            };





            // Console.WriteLine(Pedido);

            /*
            if (n == 1) {

                List<Pedido> Pedido = new List<Pedido>();
                Pedido.Add(Item)


            }
            */



            /* int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            */

        }
    }
}