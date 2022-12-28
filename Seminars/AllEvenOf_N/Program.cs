Console.WriteLine("Эта программа показывает все четные число до числа N");
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < N + 1)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ",");
        i = i + 1;
    }
    else
    {
        i = i + 1;
    }
}

