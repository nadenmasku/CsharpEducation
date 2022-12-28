Console.Clear();

void FillArray(float[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 1000);
    }
}

void PrintArray(float[] b)
{
    Console.Write("[");
    for (int j = 0; j < b.Length; j++)
    {
        if (j == (b.Length - 1))
        {
            Console.Write(b[j]);
        }
        else{
            Console.Write($"{b[j]}, ");
        }
    }
    Console.WriteLine("]");
}

float Diff(float[] arr)
{
    float diff = 0;
    float max = arr[0];
    float min = arr[0];
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k] > max) max = arr[k];
        for (int t = 0; t < arr.Length;t++){
            if (arr[t] < min) min = arr[k];
        }
    }
    diff = max - min;
    return diff;
}

Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

float[] array = new float[N];

FillArray(array);
PrintArray(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Diff(array)}");