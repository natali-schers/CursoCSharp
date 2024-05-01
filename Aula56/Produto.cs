
namespace Aula56
{
    class Produto
    {        
        private string _nome;
        private double _preco;
        private int _quantidade;

        public string Nome { 
            get { return _nome; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }
    }
}
