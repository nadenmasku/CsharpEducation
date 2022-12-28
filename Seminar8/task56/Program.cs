int m = 5;
int n = 4;

int[,] massive = new int[m, n];

FillMassive(massive);
PrintMassive(massive);
Console.WriteLine();
Console.WriteLine(FindIndex(massive));



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

int FindIndex(int[,] mass)
{
    int min = 1000000;
    int sum = 0;
    int index = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            sum += mass[i, j];
        }
        if (sum < min)
        {
            min = sum;
            index = i;
        }
        sum = 0;
    }
    return index+1;

}

