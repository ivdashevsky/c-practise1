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