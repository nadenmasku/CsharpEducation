int m = 4;
int n = 4;

int[,] massive = new int[m, n];

void FillMassive(int[,] mass)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mass[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMassive(int[,] mas)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(mas[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] mass)
{
    double result = 0;

    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            result += mass[i, j];
        }
        Console.Write($"{j+1}) {result/m} ");
    }

}


FillMassive(massive);
PrintMassive(massive);
Console.WriteLine();
ArithmeticMean(massive);

