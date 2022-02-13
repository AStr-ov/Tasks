//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] mas = new int[8];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 2);
        Console.Write(mas[i]+";");
    }
    Console.WriteLine();