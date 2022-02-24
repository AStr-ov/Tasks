//55. Дан целочисленный массив. 
//Найти среднее арифметическое каждого из столбцов.

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
Console.Write("Cреднее арифметическое столбцов : ");   
for (int i = 0; i < array.GetLength(1);i++)
{
    double result=0;
    for (int j = 0; j <array.GetLength(0) ;j++)
   {    
       result=(result+array[j,i]);      
    }  
    Console.Write($"{result/m};  ");   
}
Console.WriteLine();   
