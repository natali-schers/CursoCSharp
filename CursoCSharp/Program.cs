sbyte n1 = 100; // Não aceita números maiores que 127 e pode ir até -128
Console.WriteLine(n1);

byte n2 = 255; // Não aceita números negativos e números maiores que 255
Console.WriteLine(n2);

// Overflow: quando um cálculo resulta em um número maior que o permitido pela variável
n2++;
Console.WriteLine(n2);

int n3 = 2147483647;
long n4 = 2147483648;