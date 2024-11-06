using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificacaoBanco.Entities
{
    internal class Eventos
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Eventos() 
        { 
        }

        public Eventos(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
