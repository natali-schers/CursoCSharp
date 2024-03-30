// Console.ReadLine(): lê da entrada padrão até a quebra de linha e retorna os dados na forma de string.

string frase = Console.ReadLine();
string cor1 = Console.ReadLine();
string cor2 = Console.ReadLine();
string cor3 = Console.ReadLine();

Console.WriteLine("Você digitou: ");
Console.WriteLine(frase);
Console.WriteLine(cor1);
Console.WriteLine(cor2);
Console.WriteLine(cor3);

string[] vet = frase.Split(" ");
Console.WriteLine(vet[0]);