using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GestaoDePedidos.Entities
{
    internal class Pedido
    {
        public int Id { get; set; }

        public List<Item> items { get; set; }

        public Pedido() { }

        public Pedido(int id)
        {
            Id = id;
        }
    }
}
