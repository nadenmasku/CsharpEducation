Console.Clear();

void FillArray(int[] a) 
{
    for (int i = 0; i < a.Length;i++) 
    {
        a[i] = new Random().Next(0, 100000);
    }

}
void PrintArray(int[] b)
{
    Console.Write("[");
    for (int k = 0; k < b.Length;k++)
    {
        Console.Write(b[k]+" ");
    }
    Console.WriteLine("]");
}
int CountOfEven(int[] array){
    int count = 0;
    for (int j = 0; j < array.Length;j++)
    {
        if (array[j] % 2==0) count++;
    }
    return count;
}
Console.WriteLine("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

FillArray(array);
PrintArray(array);

Console.WriteLine($"Кол-во четных элементов массива = {CountOfEven(array)} ");
