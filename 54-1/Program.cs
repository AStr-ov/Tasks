//54. В матрице чисел найти сумму элементов главной диагонали
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
int m = 6;
int n = 5;
int[,] array = new int[m, n];
FillArr(array);
PrintArr(array);
int sum = 0;
int size = 0;
if (m > n)
    size = n;
else
    size = m;
for (int i = 0; i < size; i++)
{
    sum += array[i, i];
}
Console.WriteLine($"Сумма элементов глаиной диоганали = {sum}");
