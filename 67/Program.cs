//67. Показать натуральные числа от N до 1, N задано

void Metod(int n)
{
    Console.Write(n+";");
    if (n==1)return ;
    Metod(n-1);
}
Console.WriteLine("Введите чмсло");
int N=int.Parse(Console.ReadLine());
Metod(N);