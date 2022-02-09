//23. Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введите число границы таблицы");
int N=int.Parse(Console.ReadLine());
for (int i = 1; i<= N; i++)
{
    Console.WriteLine($"{i}x{i}={i*i}");
}