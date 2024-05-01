using Exercicio9;

ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Entre com o nome do titular: ");
string titular =  Console.ReadLine();

Console.Write("Haverá depósito inicial? (S / N) ");
char resp = char.Parse(Console.ReadLine());

if (resp == 'S' || resp == 's')
{
    Console.Write("Entre com o valor do depósito: R$");
    double deposito = double.Parse(Console.ReadLine());

    conta = new ContaBancaria(numero, titular, deposito);
} else
{
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine(conta);

Console.WriteLine(" ");

Console.Write("Entre um valor para depósito: R$");
double valor = double.Parse(Console.ReadLine());
conta.Deposito(valor);
Console.WriteLine("Dados da conta atualizados: " + conta);

Console.WriteLine(" ");

Console.Write("Entre um valor para Saque (taxa de 5 reais): R$");
valor = double.Parse(Console.ReadLine());
conta.Saque(valor);

Console.WriteLine("Dados da conta atualizados: " + conta);