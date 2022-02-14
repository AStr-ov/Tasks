//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int[] arr = new int[10];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-100, 100);
    Console.Write(arr[i] + " ");
}
int max = arr[0];
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным элементом массива ({max}) и его минимальным элементом ({min}) составляет  {max-min}");