int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
Console.WriteLine(num);
if (max < a2)
{
    max = a2;
}

Console.WriteLine($"Max figure in number {num} is {max}");