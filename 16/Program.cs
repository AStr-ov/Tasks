//16. Дано число обозначающее день недели. 
//Выяснить является номер дня недели выходным 
int a=new Random().Next(1, 8);
if (a==6 ^ a==7)
{
    Console.WriteLine($"{a} день недели - выходной");
}
else
{
   Console.WriteLine($"{a} день недели - не является выходным днем"); 
}