//61. Найти произведение двух матриц

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]+"   ");
        }
        Console.WriteLine();
    }
}
int a=3;
int b=4;
int c=3;
int[,] matrixA=new int[a,b];
int[,] matrixB=new int[b,c];
int[,] matrixResult=new int[a,c];
FillArray(matrixA);
Console.WriteLine("Первая матрица:");
PrintArray(matrixA);
FillArray(matrixB);
Console.WriteLine("Вторая матрица");
PrintArray(matrixB);
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        for (int e = 0; e < matrixB.GetLength(0); e++)
        {
            matrixResult[i,j]+=matrixA[i,e]*matrixB[e,j];
        }
    }
}
Console.WriteLine("Результирующая матрица:");
PrintArray(matrixResult);