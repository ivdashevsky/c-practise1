﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int c = 1;
Console.WriteLine("Список чётных чисел");
while (c <= N)
{
    if (c % 2 == 0)
    {
        Console.WriteLine(c);
    }
    c++;
}