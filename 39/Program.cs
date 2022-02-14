//39. Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] mat=new int[7];
int result=1;
for (int i = 0; i < mat.Length; i++)
{
    mat[i]=new Random().Next(-10,10);
    Console.Write(mat[i]+";");
}
Console.WriteLine();
for (int i = 0; i < (mat.Length+1)/2; i++)
{
    result=mat[i]*mat[mat.Length-1-i];
    Console.Write(result+" ");
}
Console.WriteLine();