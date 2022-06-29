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