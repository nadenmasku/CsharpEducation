// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int m = 2;
int n = 2;
int b = 2;

int[,,] massive = new int[m, n, b];

FillMassive(massive);
PrintMassive(massive);


void FillMassive(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                mass[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
}

void PrintMassive(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                Console.WriteLine($"({i},{j},{k}) {mass[i, j, k]}");
            }
        }
        
    }
}