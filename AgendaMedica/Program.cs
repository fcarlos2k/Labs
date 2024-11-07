using System;
using System.ComponentModel;
using System.Linq;
using AgendaMedica.Entities;

namespace AgendaMedica // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            int contador = 0;
            List<Consulta> consultas = new List<Consulta>();

            for (int i = 0; i < 5; i++)
            {
                Consulta d = new Consulta();
                d.Id = i;
                d.Nome = "Paciente" + i;
                d.Hora = TimeOnly.Parse("15:" + i + "0");
                d.Prioridade = "Normal";
                consultas.Add(d);
                contador ++;
            }
            
            while (opcao != 9)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE AGENDA MEDICA COM PRIORIDADES");
                Console.WriteLine("");
                Console.WriteLine("O que deseja fazer? ");
                Console.WriteLine("");
                Console.WriteLine("1) Agendar uma consulta");
                Console.WriteLine("2) Reprogramar uma consulta");
                Console.WriteLine("3) Listar a agenda NORMAL do dia");
                Console.WriteLine("4) Listar a agenda COM PRIORIDADES do dia");
                Console.WriteLine("9) Sair da aplicação");
                Console.WriteLine("");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Consulta c = new Consulta();

                        Console.WriteLine("Digite o nome do Paciente: ");
                        c.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a hora da consulta: (HH:mm) ");
                        c.Hora = TimeOnly.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a prioridade da consulta (Normal, Alta): ");
                        c.Prioridade = Console.ReadLine();

                        Console.WriteLine("Item adiciodo! ");
                        c.Id = contador;
                        consultas.Add(c);
                        contador ++;
                        Console.WriteLine();
                        Console.ReadLine();
                        break;


                    case 2:
                        //Reprogramar uma consulta

                        int AlterarId = 0;

                        Console.WriteLine("Reprogramar uma consulta");
                        //Console.WriteLine();
                        foreach (Consulta obj in consultas)
                        {
                            Console.WriteLine(obj);
                        };
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Qual consulta deseja alterar o horario (ID)? ");
                        //Console.WriteLine();
                        //Console.WriteLine();
                        AlterarId = int.Parse(Console.ReadLine());

                        Console.Write("Novo horario (HH:mm)? ");
                        consultas[AlterarId].Hora = TimeOnly.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Horario alterado!");
                        Console.ReadLine();

                        break;

                    case 3:
                        // Listar agenda do NORMAL dia
                        Console.WriteLine("");
                        Console.WriteLine("Listar Consultas");

                        var ConsultaOrdenadaHora = consultas.OrderBy(x => x.Hora).ToList();

                        foreach (Consulta obj in ConsultaOrdenadaHora)
                        {
                            Console.WriteLine(obj);
                        };

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    case 4:
                        // Listar agenda com PRIORIDADES do dia
                        Console.WriteLine("");
                        Console.WriteLine("Listar Consultas");

                        //var ConsultaOrdenadaHora = consultas.OrderBy(x => x.Hora).OrderBy(x => x.Prioridade).ToList();
                        var ConsultaOrdenadaPrioridadeHora = consultas.OrderBy(x => x.Prioridade).OrderBy(x => x.Hora).ToList();

                        foreach (Consulta obj in ConsultaOrdenadaPrioridadeHora)
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