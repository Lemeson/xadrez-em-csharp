
namespace tabuleiro
{
     class Posicao{
        //encapsulamento
        public int linha { get; set;  }
        public int coluna { get; set; }

        //construtor
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha
                + " , "
                + coluna;
        }
    }
}
