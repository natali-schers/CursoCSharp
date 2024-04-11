using Exercicio6;

Pessoa pessoa1 = new Pessoa();

Console.Write("Digite o nome da primeira pessoa: ");
pessoa1.Nome = Console.ReadLine();

Console.Write("Digite o salário da primeira pessoa: R$");
pessoa1.Salario = double.Parse(Console.ReadLine());

Console.WriteLine(" ");

Pessoa pessoa2 = new Pessoa();

Console.Write("Digite o nome da segunda pessoa: ");
pessoa2.Nome = Console.ReadLine();

Console.Write("Digite o salário da segunda pessoa: R$");
pessoa2.Salario = double.Parse(Console.ReadLine());

double media = (pessoa1.Salario + pessoa2.Salario) / 2.00;

Console.WriteLine(" ");

Console.WriteLine("A média dos salários é de: R${0}", media);