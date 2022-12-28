//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//456 -> 5
//782 -> 8
//918 -> 1
Console.Clear();

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);

int num1 = number % 10;
number = number / 10;
int num2 = number % 10;

Console.WriteLine(num2);

