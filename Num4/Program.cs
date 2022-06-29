//Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a) {max = b;}
if (c > a) {max = c;}
Console.Write("Максимальное число равно ");
Console.WriteLine(max);

/*
int a1 = 2, b1 = 3, c1 = 7,
    a2 = 44, b2 = 5, c2 = 78,
    a3 = 22, b3 = 3, c3 = 9;

Console.WriteLine("Список чисел 1");
Console.Write("a = "); Console.WriteLine(a1);
Console.Write("b = "); Console.WriteLine(b1);
Console.Write("c = "); Console.WriteLine(c1);
int max = a1;
if (b1>max) {max = b1;}
if (c1>max) {max = c1;}
Console.Write("Максимальное число равно ");
Console.WriteLine(max);
Console.WriteLine();

Console.WriteLine("Список чисел 2");
Console.Write("a = "); Console.WriteLine(a2);
Console.Write("b = "); Console.WriteLine(b2);
Console.Write("c = "); Console.WriteLine(c2);
max = a2;
if (b2>max) {max = b2;}
if (c2>max) {max = c2;}
Console.Write("Максимальное число равно ");
Console.WriteLine(max);
Console.WriteLine();

Console.WriteLine("Список чисел 3");
Console.Write("a = "); Console.WriteLine(a3);
Console.Write("b = "); Console.WriteLine(b3);
Console.Write("c = "); Console.WriteLine(c3);
max = a3;
if (b3>max) {max = b3;}
if (c3>max) {max = c3;}
Console.Write("Максимальное число равно ");
Console.WriteLine(max);
Console.WriteLine();
*/