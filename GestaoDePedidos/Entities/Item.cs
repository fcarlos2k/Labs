using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDePedidos.Entities
{
    internal class Item
    {

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Item()
        {
        }

        public Item(string nome, int quantidade, double preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }


    }
}
