using Aula51;

Console.WriteLine("Entre os dados do produto: ");


Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Preço: R$");
double preco = double.Parse(Console.ReadLine());

Console.Write("Estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto produto = new Produto(nome, preco, quantidade);

Console.WriteLine(" ");
Console.WriteLine(produto);

Console.WriteLine(" ");
Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
int estoque = int.Parse(Console.ReadLine());
produto.AdicionarEstoque(estoque);

Console.WriteLine(" ");
Console.WriteLine("Dados atualizados: " + produto);

Console.WriteLine(" ");
Console.Write("Digite o número de produtos a serem removidos no estoque: ");
estoque = int.Parse(Console.ReadLine());
produto.RemoverEstoque(estoque);

Console.WriteLine(" ");
Console.WriteLine("Dados atualizados: " + produto);