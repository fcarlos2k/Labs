using GestaoDePedidos.Entities;
using System;

namespace GestaoDePedidos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Lista de pedidos: ");
            Console.WriteLine(""); 
            Console.WriteLine("Sem pedidos registrados");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("");
            Console.WriteLine("1) Incluir um pedido ");
            Console.WriteLine("2) Remover itens do pedido");
            Console.WriteLine("3) Listar itens do pedido ");
            Console.WriteLine("");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Pedido> Pedido = new List<Pedido>();

            Pedido.Add(Item)
            

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