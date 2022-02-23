//49. Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().NextDouble()*200-100;
        Console.Write(array[i, j] + ";");
    }
    Console.WriteLine();
}
