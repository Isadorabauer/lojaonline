using System;

namespace LojaOnline
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Loja loja = new Loja();

            ProdutoFisico eletronicos = new ProdutoFisico("MacBook", "001", 12000m, 1.2, "Eletrônicos");
            ProdutoDigital eBook = new ProdutoDigital("ebook C#", "002", 40m, 2.5, "PDF");

            loja.CadastrarProduto(eletronicos);
            loja.CadastrarProduto(eBook);

            Cliente cliente = new Cliente("Isadora Bauer", "123456789", "Rua A, 123", "isatb@gmail.com");
            loja.CadastrarCliente(cliente);

            Pedido pedido = loja.CriarPedido(cliente);
            pedido.AdicionarProduto(eletronicos);
            pedido.AdicionarProduto(eBook);

            Console.WriteLine($"Total do pedido: {pedido.CalcularTotal()}");
            pedido.FinalizarPedido();
        }
    }
}
