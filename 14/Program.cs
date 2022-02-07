//14. Найти третью цифру числа или сообщить, что её нет
int a=new Random().Next(0, 9999999);
int b=a;
int c=a;
int count=0;
while (b>0)
{
    b=a/10;
    a=b;
    count++;
}
a=c;
if (count>3)
{
    while (count>3)
    {
        c=c/10;
        count--;
    }
}
if (count>=3) Console.WriteLine($"третьей цифрой числа {a} является {c%10}");
else Console.WriteLine($"третьей цифры в числе {a} нет");
    

