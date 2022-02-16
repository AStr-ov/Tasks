//45. Показать числа Фибоначчи
int a = 1;
int b = 1;
int count = 10;
for (int i = 0; i <= count; i++)
{
    Console.Write($"{a},{b},");
    a = a + b;
    b = b + a;
}
Console.WriteLine();
