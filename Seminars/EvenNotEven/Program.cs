﻿Console.WriteLine("Эта программа показывает является ли число чётным");
Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
