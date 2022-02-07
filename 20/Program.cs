//20. Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер интересующей четверти");
int a=int.Parse(Console.ReadLine());
string b="бесконечность";
string c="Диапазон возможных координат";
if (a==1) Console.WriteLine($"{c} в {a} четверти X=[0;+{b}[, Y=[0;+{b}[");
else if (a==2) Console.WriteLine($"{c} вo {a} четверти X=]-{b};0], Y=[0;+{b}[");
else if (a==3) Console.WriteLine($"{c} в {a} четверти X=]-{b};0], Y=]-{b};0]");
else
Console.WriteLine($"{c} в {a} четверти X=[0;+{b}[, Y=]-{b};0]");
