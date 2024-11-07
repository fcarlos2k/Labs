using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TimeOnly Hora { get; set; }
        public string Prioridade { get; set; }



        public Consulta()
        {
        }

        public Consulta(int id, string nome, TimeOnly hora, string prioridade)
        {
            Id = id;
            Nome = nome;
            Hora = hora;
            Prioridade = prioridade;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return "Id:" + Id + " Paciente: " + Nome + " Hora: " + Hora + " Prioridade: " + Prioridade;
        }
    }
}
