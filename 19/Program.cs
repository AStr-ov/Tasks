//19. Определить номер четверти плоскости,
// в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите координату X");
int x=int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y=int.Parse(Console.ReadLine());
//Console.WriteLine($"Координаты : ({x};{y})");
if (x>0 && y>0)
{
    Console.WriteLine($"Точка с координатами ({x};{y}) находится в 1 четверти");
}
else if (x<0 && y>0)
{
    Console.WriteLine($"Точка с координатами ({x};{y}) находится во 2 четверти");
}

else if (x<0 && y<0)
{
    Console.WriteLine($"Точка с координатами ({x};{y}) находится в 3 четверти");
}

else if (x>0 && y<0)
{
    Console.WriteLine($"Точка с координатами ({x};{y}) находится в 4 четверти");
}