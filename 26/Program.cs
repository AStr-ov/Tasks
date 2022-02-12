//26. Возведите число А в натуральную степень B используя цикл
int A=new Random().Next(1,100);
int B=new Random().Next(0,20);
double res=1;
for (int i = 1; i <= B; i++)
{
    res=res*A;
}
Console.WriteLine($"Число {A} в степени {B} ={res}");