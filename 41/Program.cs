//41. Выяснить являются ли три числа сторонами треугольника
Console.WriteLine("Введите длину первой стороны");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны");
int c = int.Parse(Console.ReadLine());
if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine($"Числа {a}, {b}, {c} могут составлять стороны треугольника");
}
else
    Console.WriteLine($"Числа {a}, {b}, {c} не могут составлять стороны треугольника");
