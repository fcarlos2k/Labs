using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificacaoBanco.Entities
{
    internal class Notificacao
    {

        public string notificacao { get; set; }
        public string tipo { get; set; }

        public Notificacao()
        {
        }

        public Notificacao(string notificacao, string tipo)
        {
            this.notificacao = notificacao;
            this.tipo = tipo;
        }
    }
}
