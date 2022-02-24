//52. В двумерном массиве заменить элементы,
// у которых оба индекса чётные на их квадраты
void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]=new Random().Next(0,10);
        }
    }
}
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+" ");
        }
        Console.WriteLine();
    }
}
int m=4;
int n=6;
int[,] array=new int[m,n];
FillArr(array);
PrintArr(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i+=2)
{
    for (int j = 0; j < array.GetLength(1); j+=2)
    {
        {
            array[i,j]=array[i,j]*array[i,j];
        }
    }
}
PrintArr(array);