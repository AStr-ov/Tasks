
Console.WriteLine("Введите через пробел пять чисел");
string a = Console.ReadLine();
char x = ' ';
string b = String.Empty;
string c = String.Empty;
string d = String.Empty;
string e = String.Empty;
string f = String.Empty;
//nt[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray()  - переводит ввод в массив, разделяя по пробелам
for (int i = 0; a[i] != x; i++)
{
    b = b + a[i];
}
int b1 = int.Parse(b);
Console.WriteLine(b1);
for (int i = b.Length+1; a[i] != x; i++)
{
    c=c+a[i];
}
int c1 = int.Parse(c);
Console.WriteLine(c1);
for (int i = b.Length+1+c.Length+1; a[i] != x; i++)
{
    d=d+a[i];
}
int d1 = int.Parse(d);
Console.WriteLine(d1);
for (int i = b.Length+1+c.Length+1+d.Length+1; a[i] != x; i++)
{
    e=e+a[i];
}
int e1 = int.Parse(e);
Console.WriteLine(e1);
for (int i = b.Length+1+c.Length+1+d.Length+1+e.Length+1; i<a.Length; i++)
{
    f=f+a[i];
}
int f1 = int.Parse(f);
Console.WriteLine(f1);
int countGreat=0;
int countLess=0;
if (b1>0) countGreat++;
else countLess++;
if (c1>0) countGreat++;
else countLess++;
if (d1>0) countGreat++;
else countLess++;
if (e1>0) countGreat++;
else countLess++;
if (f1>0) countGreat++;
else countLess++;
Console.WriteLine($"Из предложенных чисел {countGreat} чисел больше нуля и {countLess} меньше нуля");