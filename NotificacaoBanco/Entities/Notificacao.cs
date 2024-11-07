using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificacaoBanco.Entities
{
    internal class Notificacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Notificacao()
        {
        }

        public Notificacao(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return "Id:" + Id + " Descricao: " + Descricao;
        }
    }
}
