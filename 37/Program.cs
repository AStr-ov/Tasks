//37. В одномерном массиве из 123 чисел
// найти количество элементов из отрезка [10,99]
int[] array=new int[123];
int result=0;
for (int i = 0; i < array.Length; i++)
{
    array[i]=new Random().Next(-100,200);
    Console.Write(array[i]+";");
    if (array[i]>9 && array[i]<100)
    {
        result++;
    }
}
Console.WriteLine();
Console.WriteLine($"В данном массиве {result} элементов принадлежат отрезку [10,99]");