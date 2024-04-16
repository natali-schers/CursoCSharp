using Exercicio8;

Console.Write("Qual é a cotação do dólar? R$");
double cotacao = double.Parse(Console.ReadLine());

Console.Write("Quantos dólares você pretende comprar? U$");
double quantidade = double.Parse(Console.ReadLine());

Console.WriteLine("Valor a ser pago em reais: R$" + Conversor.TotalEmReais(cotacao, quantidade).ToString("F2"));