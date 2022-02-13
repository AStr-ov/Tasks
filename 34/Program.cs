//34. Написать программу замену элементов массива на противоположные
int[] array=new int[6];
Console.WriteLine("Заданный массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i]=new Random().Next(-100,101);
    Console.Write(array[i]+";");
}
Console.WriteLine();
Console.WriteLine("Массив с противоположными элементами:");
for (int i = 0; i < array.Length; i++)
{
    array[i]=-array[i];
    Console.Write(array[i]+";");
}
Console.WriteLine();