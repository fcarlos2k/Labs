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
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Pedido()
        {
        }
        public Pedido(int codigo, string nome, int quantidade, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return "Codigo:" +Codigo + " Item: " +Nome + " Quantidade: " + Quantidade + " Preço: " + Preco;
        }

        /*
         public double ValorTotalPedido()
        { return Preco; 

        }
        */
    }
}

