// Classe: pode conter atributos e métodos -> Entidade lógica
// Pode prover: construtores, sobrecarga, encapsulamento, herança e polimorfismo
// Objeto: entidade física representada pela classe / instância da classe

using Aula39;
using System.Globalization;

Triangulo x = new Triangulo();

x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double xForm = (x.A + x.B + x.C) / 2.0;
double xArea = Math.Sqrt(xForm * (xForm - x.A) * (xForm - x.B) * (xForm - x.C));

Triangulo y = new Triangulo();

y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double yForm = (x.A + x.B + x.C) / 2.0;
double yArea = Math.Sqrt(yForm * (yForm - x.A) * (yForm - x.B) * (yForm - x.C));

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