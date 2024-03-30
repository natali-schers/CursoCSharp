using System.Globalization;

Console.WriteLine("Entre com seu nome completo: ");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa? ");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
string dados = Console.ReadLine();
string[] vet = dados.Split(' ');

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco);
Console.WriteLine(vet[0]);
Console.WriteLine(vet[1]);
Console.WriteLine(vet[2]);