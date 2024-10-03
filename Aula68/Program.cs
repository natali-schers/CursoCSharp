// Tornando a variável opcional de duas formas:
Nullable<double> x = null;
double? y = null;

// Pegando o valor da variável ou o default do tipo da variável
Console.WriteLine(x.GetValueOrDefault());

// Verificando se a variável tem valor
Console.WriteLine(x.HasValue);

// Operador de calescência nula: se x não for nulo, pegará o valor da variável. Do contrário, o valor será 0
double z = x ?? 0;

Console.WriteLine(z);