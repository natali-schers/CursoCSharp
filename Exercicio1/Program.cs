﻿using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos: ");
Console.WriteLine($"{produto1}, cujo preço é ${preco1.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"{produto2}, cujo preço é ${preco2.ToString("F2", CultureInfo.InvariantCulture)}");

Console.WriteLine(" ");

Console.WriteLine($"Registro: {idade} anos de idade, cujo código é {codigo} e o gênero é {genero}");

Console.WriteLine(" ");

Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
Console.WriteLine($"Separador decimail invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");