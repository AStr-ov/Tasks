//46. Написать программу масштабирования фигуры
Console.WriteLine("Введите координаты точек");
var data = Console.ReadLine()
                  .Replace("(", "")
                  .Replace(")", "")
                  .Replace(",", " ")
                  .Split(" ")
                  .Select(double.Parse)
                  .ToArray();
Console.WriteLine("Введите коэффициент масшатабирования");
double k = double.Parse(Console.ReadLine());
Console.WriteLine("Координаты точек в результате масштабирования с коэффицентом" + " " + k);
for (int i = 0; i < data.Length; i = i + 2)
    Console.WriteLine($"({data[i] * k} , {data[i + 1] * k})");
