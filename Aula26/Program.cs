// Ordem de procedência: ! && ||

bool t1 = 4 != 5 && 2 > 3;
bool t2 = 4 != 5 || 2 > 3;
bool t3 = 4 != 5 && !(2 > 3);

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);