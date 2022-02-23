//42. Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Введите через пробел числа");
var a=Console.ReadLine().Split(" ");
int count=0;
for (int i = 0; i < a.Length; i++)
{
        int number=int.Parse(a[i]);
        if (number>0) count++;
}
Console.WriteLine($"Введено {count} чисел(a) больше нуля");