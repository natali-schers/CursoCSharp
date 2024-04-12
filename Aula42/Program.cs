using Aula42;

Console.WriteLine("Entre os dados do produto: ");

Produto produto = new Produto();

Console.Write("Nome: ");
produto.Nome = Console.ReadLine();

Console.Write("Preço: R$");
produto.Preco = double.Parse(Console.ReadLine());

Console.Write("Estoque: ");
produto.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine(produto);