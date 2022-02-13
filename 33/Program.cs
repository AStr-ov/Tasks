//33. Задать массив из 12 элементов,
// заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Console.WriteLine("массив:");
int[] array = new int[12];
int sumP = 0;
int sumN = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i]+";");
    if (array[i] > 0)
        sumP = sumP + array[i];
    else
        sumN = sumN + array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива = {sumP}");
Console.WriteLine($"Сумма отрицательных элементов массива = {sumN}");