//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.WriteLine($"Значение Х  Значеие Y  Значение !(x || y)  Значение !x && !y  Тождество");
bool x = false;
bool y = false;
bool Tr1 = true;
bool Tr2 = true;
bool Tr3 = true;
for (int i = 0; i < 2; i++)
{
    bool Left = !(x || y);
    bool Right = !x && !y;
    if (Left == Right)
        Tr1 = true;
    else
        Tr1 = false;
    Tr3 = Tr3 && Tr1;
    Console.WriteLine($"{x}          {y}       {Left}               {Right}              {Tr1}");
    x = !x;
    y = !y;
}
y = !y;
for (int i = 0; i < 2; i++)
{
    bool Left = !(x || y);
    bool Right = !x && !y;
    if (Left == Right)
        Tr2 = true;
    else
        Tr2 = false;
    Tr3 = Tr3 && Tr2;
    Console.WriteLine($"{x}          {y}       {Left}               {Right}              {Tr2}");
    y = !y;
    x = !x;
}
if (Tr3 == true)
{
    Console.WriteLine($"Тождество верно при любых значениях X и Y");
}
else
{
    Console.WriteLine($"Существуют значения Х и Y, при которых тождество не верно");
}