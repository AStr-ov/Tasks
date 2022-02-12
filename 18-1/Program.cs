//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool fun(bool x, bool y)
{
    bool Tr=true;
    bool Left = !(x || y);
    bool Right = !x && !y;
    if(Left==Right) Tr=true;
    else Tr=false;
    return Tr;
}
bool a=fun(false, false);
Console.WriteLine($"при X=false  Y=false значение !(x || y)=!x && !y - {a}");
bool b=fun(true,true);
Console.WriteLine($"при X=true   Y=true  значение !(x || y)=!x && !y - {a}");
bool c=fun(false,true);
Console.WriteLine($"при X=false  Y=true  значение !(x || y)=!x && !y - {a}");
bool d=fun(true,false);
Console.WriteLine($"при X=true   Y=false значение !(x || y)=!x && !y - {a}");
if (a && b && c && d==true) Console.WriteLine($"Тождество верно при любых значениях X и Y");
else Console.WriteLine("Существуют значения Х и Y, при которых тождество не верно");