//38. Найти сумму чисел одномерного массива
// стоящих на нечетной позиции
int[] mas=new int[11];
int result=0;
Console.WriteLine("В массиве");
for (int i = 0; i < mas.Length; i++)
{
    mas[i]=new Random().Next(-10,10);
    Console.Write(mas[i]+";");
}
Console.WriteLine();
for (int i = 0; i < mas.Length; i=i+2)
{
    result=result+mas[i];
}
Console.WriteLine($"Сумма чисел на нечетных позициях  = {result}");