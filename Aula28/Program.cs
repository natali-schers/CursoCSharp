double preco = double.Parse(Console.ReadLine());

if(preco >= 100.00)
{
    double desconto = preco * 0.1;
    preco -= desconto;
}

Console.WriteLine($"R$ {preco}");