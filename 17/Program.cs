//17. По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=int.Parse(Console.ReadLine());
if (a>b)
{
    if (a==b*b)
    {
        Console.WriteLine($"Число {a} является квадратом числа {b}");
    }
    else
    {
        Console.WriteLine("Ни одно из этих чисел не является квадратом дгугого");
    }
}

if (b>a)
{
    if (b==a*a)
    {
        Console.WriteLine($"Число {b} является квадратом числа {a}");
    } 
    else
    {
        Console.WriteLine("Ни одно из этих чисел не является квадратом дгугого");
    }

}

