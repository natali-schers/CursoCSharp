using Aula42;

Console.WriteLine("Entre os dados do produto: ");

Produto produto = new Produto();

Console.Write("Nome: ");
produto.Nome = Console.ReadLine();

Console.Write("Preço: R$");
produto.Preco = double.Parse(Console.ReadLine());

Console.Write("Estoque: ");
produto.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine(produto);

Console.WriteLine(" ");
Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
int qntd = int.Parse(Console.ReadLine());
produto.AdicionarEstoque(qntd);

Console.WriteLine(" ");
Console.WriteLine("Dados atualizados: " + produto);

Console.WriteLine(" ");
Console.Write("Digite o número de produtos a serem removidos no estoque: ");
qntd = int.Parse(Console.ReadLine());
produto.RemoverEstoque(qntd);

Console.WriteLine(" ");
Console.WriteLine("Dados atualizados: " + produto);