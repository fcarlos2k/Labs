using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificacaoBanco.Entities
{
    internal class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Notificacao { get; set; }

        public Cliente() { }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return "Id:" + Id + " Nome : " + Nome;
        }
    }
}
