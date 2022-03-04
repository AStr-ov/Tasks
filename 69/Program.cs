//69. Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Введите первое число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = int.Parse(Console.ReadLine());
int SumElements(int a, int b)
{
    int sum = 0;
    if (b >= a)
        sum += b + SumElements(a, b - 1);
    return sum;
}
Console.WriteLine($"Сумма элементов от {m} до {n} = {SumElements(m, n)}");
