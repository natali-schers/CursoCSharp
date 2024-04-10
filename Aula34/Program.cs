// Início (executa somente na primeira vez); condição; incremento

Console.Write("Quantos números inteiros você quer digitar? ");
int qntd = int.Parse(Console.ReadLine());

int soma = 0;

for (int i = 1; i <= qntd; i++)
{
    Console.Write($"Valor: #{i}: ");
    int valor = int.Parse(Console.ReadLine());

    soma += valor;
}

Console.WriteLine("Soma = " + soma);