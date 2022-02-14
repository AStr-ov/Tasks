//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.WriteLine("Масив");
void fill(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}
void print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }
}
int[] array = new int[8];
fill(array);
print(array);
Console.WriteLine();