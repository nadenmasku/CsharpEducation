int m = 5;
int n = 5;

int[,] massive = new int[m, n];

void FillMassive(int[,] mass)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mass[i, j] = new Random().Next(0, 1000);
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

FillMassive(massive);
PrintMassive(massive);

Console.Write("Введите номер строки: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());


if (str > m || column > n) Console.WriteLine("Error");
else Console.WriteLine(massive[str - 1, column - 1]);
