//58. Написать программу,
//которая в двумерном массиве заменяет строки
// на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
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
int m = 5;
int n = 5;
int[,] array = new int[m, n];
FillArr(array);
PrintArr(array);
Console.WriteLine();
int[,] mass = new int[array.GetLength(0), array.GetLength(1)];
if (array.GetLength(0) == array.GetLength(1))
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = array[j, i];
        }
    }
    PrintArr(mass);
}
else
    Console.WriteLine(
        $"В данном массиве невозможно заменить строки на столбцы так как матрица не квадратная."
    );