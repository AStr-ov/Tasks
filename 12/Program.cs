﻿//12. Удалить вторую цифру трёхзначного числа
int a=new Random().Next(100, 999);
Console.WriteLine($"Число {a} без второй цифры: {a/100}{a%10}");