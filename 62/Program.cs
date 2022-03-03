//62. В двумерном массиве целых чисел.
//Удалить строку и столбец, на пересечении которых
//расположен наименьший элемент.

void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
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
int n = 7;
int[,] array = new int[m, n];
FillArr(array);
PrintArr(array);
Console.WriteLine();

int minString = 0;
int minColum = 0;
int minElement = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < minElement)
        {
            minElement = array[i, j];
            minString = i;
            minColum = j;
        }
    }
}
Console.WriteLine(
    $"Наименьший элемент - <{minElement}>  в строке с индексом {minString}  в столбце с индексом {minColum} "
);
Console.WriteLine(
    "Данный массив, с удаленными строкой и столбцом, на пересечении которых расположен наименьший элемент."
);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i != minString && j != minColum)
            Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
