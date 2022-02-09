//24. Найти кубы чисел от 1 до N
Console.WriteLine("Введите число границы таблицы");
int N=int.Parse(Console.ReadLine());
Console.WriteLine($"Число  Куб числа");
for (int i = 1; i <= N; i++)
{
        Console.WriteLine($" {i}      {i*i*i}");
}
