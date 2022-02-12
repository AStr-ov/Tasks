//30. Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine($"Четное число    Куб числа");
int a=1;
int n=100;
double res=1;
for (int i = 0; i <=n; i++)
{
    res=a*a*a;
    if (a%2==0)
    {
        Console.WriteLine($"{a}               {res}");
    }
    a++;
}