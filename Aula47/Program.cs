using Aula47;
using System.Globalization;

Console.Write("Entre com o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = Calculadora.Circunferencia(raio);
double vol = Calculadora.Volume(raio);

Console.WriteLine("Valor de Pi: " + Calculadora.Pi);
Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));