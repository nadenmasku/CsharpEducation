// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Clear();

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + ",");
    }
    Console.WriteLine("]");
}

int Count(int[] ary)
{
    int result = 0;
    for (int k = 0; k < ary.Length; k++)
    {
        if (ary[k] > 0) result++;
    }
    return result;
}



int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

FillArray(array);
PrintArray(array);
Console.WriteLine(Count(array));
