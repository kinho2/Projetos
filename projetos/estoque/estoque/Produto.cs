using System;
using System.Globalization;

namespace estoque {
    public class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            //Quantidade = Quantidade + quantidade;
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome 
                + " ,R$" 
                + Preco.ToString("F2",CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades e total: " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
