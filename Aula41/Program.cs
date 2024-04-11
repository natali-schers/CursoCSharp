using Aula41;
using System.Globalization;

Triangulo x = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X: ");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double xArea = x.CalculaArea();

Triangulo y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double yArea = y.CalculaArea();

Console.WriteLine(" ");

if (xArea > yArea)
{
    Console.WriteLine("Maior área: X");
}
else if (yArea > xArea)
{
    Console.WriteLine("Maior área: Y");
}
else
{
    Console.WriteLine("Áreas iguais!");
}