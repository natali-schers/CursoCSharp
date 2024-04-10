using System.Globalization;

Console.WriteLine("Entre com as medidas do triângulo X: ");
double xLadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double xLadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double xLadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double x = (xLadoA + xLadoB + xLadoC) / 2.0;
double xArea = Math.Sqrt(x * (x - xLadoA) * (x - xLadoB) * (x - xLadoC));

Console.WriteLine("Área de X: " + xArea.ToString("F4", CultureInfo.InvariantCulture));

Console.WriteLine(" ");

Console.WriteLine("Entre com as medidas do triângulo Y: ");
double yLadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double yLadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double yLadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double y = (yLadoA + yLadoB + yLadoC) / 2.0;
double yArea = Math.Sqrt(y * (y - yLadoA) * (y - yLadoB) * (y - yLadoC));

Console.WriteLine("Área de Y: " + yArea.ToString("F4", CultureInfo.InvariantCulture));

if (xArea > yArea)
{
    Console.WriteLine("Maior área: X");
}
else if (yArea > xArea)
{
    Console.WriteLine("Maior área: Y");

} else
{
    Console.WriteLine("Áreas iguais!");
}