int[] array = { 11, 22, 31, 44, 46, 4, 74, 82, 19 };

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
}