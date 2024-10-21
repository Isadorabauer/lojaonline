using System;
using System.Collections.Generic;

namespace LojaOnline
{
    public class Pedido : ICarriavel
    {
        public Cliente Cliente { get; set; }
        public DateTime DataPedido { get; set; }
        public List<Produto> Produtos { get; set; }
        public string Status { get; set; }

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            DataPedido = DateTime.Now;
            Produtos = new List<Produto>();
            Status = "Em Processamento";
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} adicionado.");
        }

        public void RemoverProduto(Produto produto)
        {
            Produtos.Remove(produto);
            Console.WriteLine($"Produto {produto.Nome} removido.");
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var produto in Produtos)
            {
                total += produto.CalcularPrecoFinal();
            }
            return total;
        }

        public void FinalizarPedido()
        {
            Status = "Concluído";
            Console.WriteLine("Pedido finalizado.");
        }
    }
}
