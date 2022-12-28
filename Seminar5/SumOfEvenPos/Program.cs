// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0
Console.Clear();
void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-100, 100);
    }

}
void PrintArray(int[] b)
{
    Console.Write("[");
    for (int k = 0; k < b.Length; k++)
    {
        Console.Write(b[k] + " ");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumOfNotEvenPos(int[] arr)
{
    int sum = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (j % 2 != 0) sum += arr[j];
    }
    return sum;
}
int[] array = new int[N];

FillArray(array);
PrintArray(array);

Console.WriteLine($"Сумма элементов массива с нечетными индексами = {SumOfNotEvenPos(array)}");