//63. Сформировать трехмерный массив не повторяющимися
// двузначными числами показать его построчно на экран 
//выводя индексы соответствующего элемента
int a = 4;
int b = 5;
int c = 4;
if (a * b * c < 90)
{
    int[,,] array = new int[a, b, c];
    int q = 10;
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = q;
                q++;
                Console.WriteLine($"Элемент с индексом ({i},{j},{k} : {array[i, j, k]})");
            }
            
        }
    }
}
else
    Console.WriteLine("Не хватит уникальных двузнычных чисел для заполнения матрицы данного размера");
    