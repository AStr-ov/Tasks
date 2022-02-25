//57. Написать программу, упорядочивания по убыванию
// элементы каждой строки двумерной массива.
void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 4;
int n = 6;
int[,] array = new int[m, n];
FillArr(array);
PrintArr(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(1) - 1; i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int k=i+1; k < array.GetLength(1); k++)//
        {
            if (array[j, i] < array[j, k])
            {
                int temp = array[j, i];
                array[j, i] = array[j, k];
                array[j, k] = temp;
            }
        }
    }
}
Console.WriteLine("Массив, упорядоченный по убыванию элементы каждой строки:");
PrintArr(array);
