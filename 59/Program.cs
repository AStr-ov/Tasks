//59. В прямоугольной матрице найти строку
//    с наименьшей суммой элементов.
int m=10;//-число на 1 больше максимального рандома
void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, m);
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
int a = 6;//- количество строк
int b = 4;// -количество столбцов
int[,] array = new int[a, b];
FillArr(array);
PrintArr(array);
Console.WriteLine();
int min=m*b;//- число большее максимально возможной суммы элементов строки
int r = 0;// - индекс строки с мин суммой элементов строки
Console.WriteLine($"Индекс строки  Сумма элементов строки");
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;// - сумма элементов строки
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];  
    }   
    if (min > sum)
        {
            min = sum;
            r = i;
        }
    Console.WriteLine($"{i}              {sum}");    
}
Console.WriteLine($"В {r + 1} строке  (индекс {r}) минимальная сумма элементов ({min}) ");