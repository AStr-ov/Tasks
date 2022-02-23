//46. Написать программу масштабирования фигуры
Console.WriteLine("Введите через пробел координаты точек в формате -  x1,y1 x2,y2");
string coordinates = Console.ReadLine();
Console.WriteLine("Ведите коэффициент масштабирования");
double k = double.Parse(Console.ReadLine());
Console.WriteLine($"Координаты точек в результате массштабирования с коэффициентом {k}:");
var data = coordinates
    .Split(' ')
    .Select(point => point.Split(','))
    .Select(c => (x: int.Parse(c[0]), y: int.Parse(c[1])))
    .ToArray();
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine($"({data[i].x * k};{data[i].y * k})");
}