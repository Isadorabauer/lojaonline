using System;

namespace LojaOnline
{
    public class ProdutoFisico : Produto
    {
        public double Peso { get; set; }
        public string Categoria { get; set; }

        public ProdutoFisico(string nome, string codigo, decimal preco, double peso, string categoria)
            : base(nome, codigo, preco)
        {
            Peso = peso;
            Categoria = categoria;
        }

        public override decimal CalcularPrecoFinal()
        {
            decimal imposto = Preco * 0.10m;
            decimal custoEnvio = (decimal)(Peso * 5); 
            return Preco + imposto + custoEnvio;
        }
    }
}
