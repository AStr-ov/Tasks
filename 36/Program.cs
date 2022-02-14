//36. Задать массив, заполнить случайными 
//положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
int[] matrix=new int[15];
int even=0;
int odd=0;
for (int i = 0; i < matrix.Length; i++)
{
    matrix[i]=new Random().Next(100,1000);
    Console.Write(matrix[i]+";");
    if (matrix[i]%2==0)
    {
        even++;
    }
    else odd++;
}
Console.WriteLine();
Console.WriteLine($"В данном массиве присутсвует {odd} нечетных и {even} четных чисел");