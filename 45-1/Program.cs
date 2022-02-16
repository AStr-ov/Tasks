//45. Показать числа Фибоначчи
Console.WriteLine("Введите количество показываемых чисел");
int n = int.Parse(Console.ReadLine());
int Fibonacci(int num)
{
    if (num == 1 || num == 2)
        return 1;
    else
        return Fibonacci(num - 1) + Fibonacci(num - 2);
}
for (int i = 1; n>=i; i++)
{
    Console.WriteLine(Fibonacci(i));
}