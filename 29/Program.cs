//29. Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите конечное число");
int N = int.Parse(Console.ReadLine());
double result = 1;
for (int i = 1; i <= N; i++)
{
    result = result * i;
}
Console.WriteLine($"произведениt чисел от 1 до {N} = {result}");
