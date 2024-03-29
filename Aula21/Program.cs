// * / % tem precedência maior que + -
// %: resto da divisão. Por exemplo: 17 / 3 = 5 -> 17 % 3 = 0

int n1 = 3 + 4 * 2;
int n2 = (3 + 4) * 2;
Console.WriteLine(n1);
Console.WriteLine(n2);

int n3 = 17 / 3;
int n4 = 17 % 3;
Console.WriteLine(n3);
Console.WriteLine(n4);

double n5 = (double)10 / 8;
double n6 = 10.0 / 8;
Console.WriteLine(n5);
Console.WriteLine(n6);

double a = 1.0;
double b = -3.0;
double c = -4.0;

double delta = Math.Pow(b, 2) - 4 * a * c; // Pow é a abreviação de power, que é o equivalente a "elevado a"/potência
double bhaskara = (-b + Math.Sqrt(delta)) / (2.0 * a); // Sqrt é a abreviação de square root, que significa raiz quadrada
Console.WriteLine(delta);
Console.WriteLine(bhaskara);