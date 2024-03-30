// Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa

Console.WriteLine("Digite um número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
int num2 = int.Parse(Console.ReadLine());

int soma = num1 + num2;
Console.WriteLine("Soma = " + soma);