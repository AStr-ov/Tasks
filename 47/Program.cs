//47. Написать программу копирования массива
int[] mas=new int[10];
int[] arr=new int[mas.Length];
void FillArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,100);
    }
}
void PrintArr(int[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        Console.Write(array[i]+";");
    }
}
FillArr(mas);
PrintArr(mas);
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    arr[i]=mas[i];
}
PrintArr(arr);