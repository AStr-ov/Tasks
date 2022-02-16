//43. Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int x1 = x;
int count = 0;
Console.WriteLine($"Число {x} в двоичной системе:");
for (int i = 1; x > 0; i++)//определяем количество цифр в 2-й системе
{
    x = x / 2;
    count = i;
}
int[] r = new int[count];
for (int i = 0; i < count; i++)//заполняем массив значениями
{
    if (x1 % 2 == 0)
        r[i] = 0;
    else
        r[i] = 1;
    x1 = x1 / 2;
    //Console.Write(r[i] + " ");  -результат наполнения массива
}
Console.WriteLine();
for (int i = count - 1; i >= 0; i--)//выводим в обратном порядке
    Console.Write(r[i] + " ");
Console.WriteLine();