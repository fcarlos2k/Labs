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

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Pedido()
        {
        }
        public Pedido(string nome, int quantidade, double preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return "Item: " +Nome + " Quantidade: " + Quantidade + " Preço: " + Preco;
        }

        public double ValorTotalPedido()
        { return Preco; 

        }

    }

    /*
     * a adicionar, remover e listar itens no pedido.
     * Crie uma função para calcular o valor total do pedido, considerando os itens e suas quantidades.
     * Implemente uma função de validação que verifique se um pedido contém pelo menos um item antes de poder ser concluído.
     * Implemente um desconto percentual ou fixo, aplicável a pedidos que atingem um valor mínimo
    */
}

