//35. Определить, присутствует ли в заданном массиве, некоторое число
int[] mas = { -5, 0, 11, 8, -4 };
bool result = false;
Console.WriteLine("Введите искомое число");
int x = int.Parse(Console.ReadLine());
for (int i = 0; i < mas.Length; i++)
{
    //Console.Write($"{mas[i]};");
    if (mas[i] == x) result=true;
}
Console.WriteLine();
if (result)
Console.WriteLine("Искомое число  присутствует в заданном массиве");
else
Console.WriteLine("Искомого числа   нет в заданном массиве");