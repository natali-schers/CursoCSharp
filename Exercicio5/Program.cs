// Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.
// A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

Console.WriteLine("Digite seu número de identificação: ");
int id = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da sua hora: ");
double vlr = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
double hrs = double.Parse(Console.ReadLine());

double ttl = vlr * hrs;

Console.WriteLine($"O funcionário {id} receberá R${ttl:F2}.");