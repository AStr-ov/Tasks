//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
int a=new Random().Next(20, 100);
int b=new Random().Next(1, 10);
if (a%b==0)
{
    Console.WriteLine($"Число {a} кратно числу {b}");
}
else
{
    Console.WriteLine($"Остаток деления числа {a} на число {b} : {a%b}");
}
