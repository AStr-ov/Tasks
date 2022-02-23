//51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
int a=5;
int b=8;
int[,] mass=new int[a,b];
for (int m = 0; m < mass.GetLength(0); m++)
{
    for (int n = 0; n < mass.GetLength(1); n++)
    {
        Console.Write($"{mass[m,n]=m+n} ");
    }
    Console.WriteLine();
}