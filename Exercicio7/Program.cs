using Exercicio7;

Funcionario funcionario = new Funcionario();

Console.Write("Digite o nome do funcionário: ");
funcionario.Nome = Console.ReadLine();

Console.Write("Digite o valor do salário bruto: R$");
funcionario.SalarioBruto = double.Parse(Console.ReadLine());

Console.Write("Digite o valor do imposto: R$");
funcionario.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine(funcionario);

Console.WriteLine(" ");
Console.Write("Digite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine());

funcionario.AumentarSalario(porcentagem);

Console.WriteLine(" ");
Console.WriteLine("Dados atualizados: " + funcionario);