//53. В двумерном массиве показать позиции числа,
// заданного пользователем или указать, что такого элемента нет
int m=6;
int n=8;
Console.WriteLine("Введите искомое число");
int x=int.Parse(Console.ReadLine());
void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]=new Random().Next(0,50);
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
int[,] array=new int[m,n];
FillArr(array);
PrintArr(array);
bool result=false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j]==x) 
        {
            result=true;
            Console.Write($"индекс элемента {i},{j} ");
        }
    }    
}
Console.WriteLine();
if(result==false) Console.WriteLine($"В данном массиве числа {x} нет");