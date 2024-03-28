using System.Globalization;

//Saídas padrão
Console.Write("Não pular linha");
Console.WriteLine("Pular linha");

char genero = 'F';
int idade = 19;
double saldo = 104.980856;
string nome = "Natali";

Console.WriteLine(genero);
Console.WriteLine(idade);
Console.WriteLine(saldo.ToString("F2")); // F2: limitar a quantidade de casas decimais
Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); // InvariantCulture: invalida qualquer formatação específica de país
Console.WriteLine(nome);

Console.WriteLine("{0} tem {1} anos e saldo igual a {2:F2} reais.", nome, idade, saldo); // Placeholder

Console.WriteLine($"{nome} tem {idade} anos e saldo igual a {saldo:F2} reais."); // Interpolação

Console.WriteLine(nome + " tem " + idade + " anos e saldo igual a " + saldo.ToString("F2") + " reais."); // Concatenação