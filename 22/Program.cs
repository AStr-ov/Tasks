//Задача 22: Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine(
    "Выберите количество плоскостей."
        + "Для решения задачи на плоскости нажмите 2,"
        + "для решения в пространстве нажмите 3"
);
int d = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Х точки А");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X точки B");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int by = int.Parse(Console.ReadLine());
double result = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
if (d == 2)
    Console.WriteLine($" Расстояние от точки А({ax};{ay}) до точки В({bx};{by}) = {result}");
if (d == 3)
{
    Console.WriteLine("Введите координату Z точки A");
    int az = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату Z точки B");
    int bz = int.Parse(Console.ReadLine());
    double results = Math.Sqrt(
        (bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az)
    );
    Console.WriteLine(
        $"Расстояние от точки А({ax};{ay};{az}) до точки В({bx};{by};{bz}) = {results}"
    );
}