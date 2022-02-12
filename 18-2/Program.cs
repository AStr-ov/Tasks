//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.WriteLine($"Значение Х  Значеие Y  Значение !(x || y)  Значение !x && !y Тождество");
bool x = true;
bool y = true;
bool T1 = true;
bool L = !(x || y);
bool R = !x && !y;
if (L == R)
    T1 = true;
else
    T1 = false;

Console.WriteLine($"{x}          {y}       {L}               {R}            {T1}");
x = !x;
bool T2 = true;
L = !(x || y);
R = !x && !y;
if (L == R)
    T2 = true;
else
    T2 = false;
Console.WriteLine($"{x}         {y}       {L}               {R}            {T2}");
y = !y;
bool T3 = true;
L = !(x || y);
R = !x && !y;
if (L == R)
    T3 = true;
else
    T3 = false;
Console.WriteLine($"{x}         {y}      {L}                {R}             {T3}");
x = !x;
bool T4 = true;
L = !(x || y);
R = !x && !y;
if (L == R)
    T4 = true;
else
    T4 = false;
Console.WriteLine($"{x}          {y}      {L}               {R}            {T4}");

if (T1 && T2 && T3 && T4 == true)
    Console.WriteLine($"Тождество верно при любых значениях X и Y");
else
    Console.WriteLine("Существуют значения Х и Y, при которых тождество не верно");