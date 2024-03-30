using System.Globalization;

int i = int.Parse(Console.ReadLine()); 
Console.WriteLine("Você digitou: " + i);

char ch = char.Parse(Console.ReadLine());
Console.WriteLine("Você digitou: " + ch);

double db = double.Parse(Console.ReadLine());
Console.WriteLine("Você digitou: " + db);

Console.WriteLine("Digite seu nome, sexo, idade e altura: ");
string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3]);

Console.WriteLine(nome);
Console.WriteLine(sexo); 
Console.WriteLine(idade);
Console.WriteLine(altura);