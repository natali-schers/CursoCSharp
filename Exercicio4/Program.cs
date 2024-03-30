// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
// Fórmula da área: area = π.raio2 (Considere o valor de π = 3.14159)

Console.WriteLine("Digite o valor do raio: ");
double raio = double.Parse(Console.ReadLine());

double pi = 3.14159;

double area = pi * Math.Pow(raio, 2);
Console.WriteLine("A = " + area.ToString("F4"));