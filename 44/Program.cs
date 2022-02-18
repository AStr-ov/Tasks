//44. Найти точку пересечения двух прямых, заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

//k1*x + b1= k2*x + b2 =>  x=(b2-b1)/(k1-k2);
Console.WriteLine("Введите значение k1");
double k1=double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2=double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b1");
double b1=double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2=double.Parse(Console.ReadLine());
double x=(b2-b1)/(k1-k2);
double y=k1*x + b1;
Console.WriteLine($"Заданные прямые пересекаются в точке с координатами ({x};{y})");