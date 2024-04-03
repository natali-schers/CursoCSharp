Console.WriteLine("Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine());

while (num > 0)
{
    double raiz = Math.Sqrt(num);
    Console.WriteLine(raiz);

    Console.WriteLine("Digite outro número inteiro: ");
    num = int.Parse(Console.ReadLine());
}

Console.WriteLine("Entrada inválida!");