//14. Найти третью цифру числа или сообщить, что её нет
int a=new Random().Next(1, 199);
if (a/100>0)
{
    Console.WriteLine($"Третья цифра числа {a} : {a%10}");
}
else
{
    Console.WriteLine($"Число {a} не имеет третьей цифры");
}
