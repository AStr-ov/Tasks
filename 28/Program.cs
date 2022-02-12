//28. Подсчитать сумму цифр в числе
int number=new Random().Next(1, 999999);
int n=number;
int result=0;
for (int i = 0; 1 <= number; i++)
{
    result=result+number%10;
    number=number/10;
}
Console.WriteLine($"Сумма цифр в числе {n}  {result}");