//Задача 22: Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите координату Х точки А");
int ax=int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
int ay=int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Х точки B");
int bx=int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int by=int.Parse(Console.ReadLine());
double result=Math.Sqrt((bx-ax)*(bx-ax)+(by-ay)*(by-ay));
Console.WriteLine($"Расстояние от точки А({ax};{ay}) до точки В({bx};{by}) = {result}");
