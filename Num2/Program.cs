//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (b > a) {max = b; min = a;}
Console.Write("Максимальное число равно ");
Console.WriteLine(max);
Console.Write("Минимальное число равно ");
Console.WriteLine(min);
/*
int a1 = 5, b1 = 7,
    a2 = 2, b2 = 10,
    a3 = -9, b3 = -3;

Console.WriteLine("Список чисел 1");
Console.Write("a = "); Console.WriteLine(a1);
Console.Write("b = "); Console.WriteLine(b1);
int max = a1;
if (a1>b1) {max = a1;}
else {max = b1;}
Console.Write("Максимальное число равно ");
Console.WriteLine(max);
Console.WriteLine();

Console.WriteLine("Список чисел 2");
Console.Write("a = "); Console.WriteLine(a2);
Console.Write("b = "); Console.WriteLine(b2);
max = a2;
if (a2>b2) {max = a2;}
else {max = b2;}
Console.Write("Максимальное число равно ");
Console.WriteLine(max);
Console.WriteLine();

Console.WriteLine("Список чисел 3");
Console.Write("a = "); Console.WriteLine(a3);
Console.Write("b = "); Console.WriteLine(b3);
max = a3;
if (a3>b3) {max = a3;}
else {max = b3;}
Console.Write("Максимальное число равно ");
Console.WriteLine(max);
*/