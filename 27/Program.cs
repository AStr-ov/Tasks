//27. Определить количество цифр в числе
int num = new Random().Next(1, 1000000);
Console.WriteLine(num);
int i = 0;
for (i = 0; 1 <= num; i++)
{
    num = num / 10;
}
Console.WriteLine($" {i} цифр(ы)");
