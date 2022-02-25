//56. Написать программу, которая обменивает 
//элементы первой строки и последней строки
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

/* for (int i = 0; i < array.GetLength(1); i++)
{
    Console.Write(array[0,i]+" ");//- первая строка
}  
 Console.WriteLine(); 
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write(array[array.GetLength(0)-1,i]+" ");// - последняя строка
    } 
Console.WriteLine();  */ 
int temp=0;
for (int i = 0; i < array.GetLength(1); i++)
    {
        temp= array[0,i];
        array[0,i]=array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i]=temp;
    }
Console.WriteLine();
PrintArr(array);

        
/* for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[n,j]+" ");
    }
    Console.WriteLine();
} */