// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

int m = 4;
int n = 4;

int[,] massive = new int[m, n];


FillMassive(massive);
PrintMassive(massive);
Console.WriteLine();
Sort(massive);
PrintMassive(massive);


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

void Sort(int[,] mass)
{
    int[] tosortarr = new int[mass.GetLength(0)];
    int row = 0;
    while (row < mass.GetLength(0))
    {
        for (int columns = 0; columns < mass.GetLength(1); columns++)
        {
            tosortarr[columns] = mass[row, columns];
        }
        Array.Sort(tosortarr);
        Array.Reverse(tosortarr);

        for (int columns = 0; columns < mass.GetLength(1); columns++)
        {
            mass[row, columns] = tosortarr[columns];
        }

        row++;
    }

}



FillMassive(massive);
PrintMassive(massive);
Console.WriteLine();
Sort(massive);
PrintMassive(massive);

