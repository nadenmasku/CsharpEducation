Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] massive = new int[m, n];

void FillMassive(int[,] mass){
    for (int i = 0; i < m;i++){
        for (int j = 0; j < n;j++){
            mass[i, j] = new Random().Next(0, 1000);
        }
    }
}

void PrintMassive(int[,] mas){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(mas[i, j]+" ");
        }
        Console.WriteLine();
    }
}

FillMassive(massive);
PrintMassive(massive);