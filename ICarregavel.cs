using System;

namespace LojaOnline
{
    public interface ICarriavel
    {
        
       void AdicionarProduto(Produto produto);
       void RemoverProduto(Produto produto);
       decimal CalcularTotal();

    }
}

