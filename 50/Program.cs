//50. В двумерном массиве n×k заменить четные элементы на противоположные

void FillArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(-99,100);
        }
    }
}
void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ") ;
        }
        Console.WriteLine();
    }
}
int[,] arr= new int[4,6];
FillArr(arr);
PrintArr(arr);
Console.WriteLine();
for (int i = 0; i < arr.GetLength(0); i=i+2)
{
    for (int j = 0; j < arr.GetLength(1); j=j+2)
    {
        arr[i,j]=-arr[i,j];
    }
}
PrintArr(arr);
