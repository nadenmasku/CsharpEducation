int m = 4;
int n = 4;

int[,] massive = new int[m, n];
int[,] massive2 = new int[m, n];

FillMassive(massive);
FillMassive(massive2);
Console.WriteLine();
PrintMassive(massive);
Console.WriteLine();
PrintMassive(massive2);
Console.WriteLine();

int[,] result = Multiple(massive, massive2);

PrintMassive(result);

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

static int[,] Multiple(int[,] a, int[,] b)
{
    int[,] arr = new int[a.GetLength(0), a.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = a[i, j] * b[i, j];
        }
    }
    return arr;
}