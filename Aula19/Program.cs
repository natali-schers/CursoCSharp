// Operadores de atribuição
int a = 10; // a recebe 10

a += 2; // a recebe a + 2;

a -= 2; // a recebe a - 2;

a *= 2; // a recebe a * 2;

a /= 2; // a recebe a / 2;

a %= 2; // a recebe a % 2;

string s = "ABC";
Console.WriteLine(s);
s += "DEF";
Console.WriteLine(s);

// Operadores aritméticos de atribuição
++a; // a = a + 1 --> primeiro incrementa, depois atribui
a++; // a = a + 1 --> primeiro atribui, depois incrementa

--a; // a = a - 1 --> primeiro decrementa, depois atribui
a--; // a = a - 1 --> primeiro atribui, depois decrementa

int b = 10;
int c = b++;

Console.WriteLine(b);
Console.WriteLine(c);

int d = 10;
int e = ++d;

Console.WriteLine(d);
Console.WriteLine(e);