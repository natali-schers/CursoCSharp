// this: é uma referência para o próprio objeto
// Usos comuns: diferenciar atributos de parâmetros, referenciar um construtor em outro ou passar o próprio objeto como argumento na chamada de um método/construtor

// Exemplo 1:
// public Produto(string Nome, double Preco)
// {
//     this.Nome = Nome;
//     this.Preco = Preco;
//     Quantidade = 0;
// }

// Exemplo 2: 
// public Produto() 
// {
//     Quantidade = 0;
// }
//
// public Produto(string nome, double preco) : this() -> indica que o construtor padrão deve ser executado também 
// {
//      Nome = nome;
//      Preco = preco;
// }

// Exemplo 3: 
// public Produto(string nome, double preco)
// {
//      Nome = nome;
//      Preco = preco;
// }
//
// public Produto(string nome, double preco, int quantidade) : this(nome, preco) -> indica que os atributos do construtor padrão será reaproveitados
// {
//      Quantidade = quantidade;
// }

namespace Aula53
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}