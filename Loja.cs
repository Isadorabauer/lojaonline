using System;
using System.Collections.Generic;

namespace LojaOnline
{
    public class Loja
    {
        public List<Produto> Produtos { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Loja()
        {
            Produtos = new List<Produto>();
            Clientes = new List<Cliente>();
            Pedidos = new List<Pedido>();
        }

        public void CadastrarProduto(Produto produto)
        {
            Produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} cadastrado.");
        }

        public void CadastrarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
            Console.WriteLine($"Cliente {cliente.Nome} cadastrado.");
        }

        public Pedido CriarPedido(Cliente cliente)
        {
            var pedido = new Pedido(cliente);
            Pedidos.Add(pedido);
            return pedido;
        }
    }
}
