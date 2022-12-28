// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33-> [6, 1, 33]
Console.Clear();

int n = 8;

// Если хотим сделать массив с n кол-вом элементов:

// int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100000, 100000);
    }
}


//Если нужен ввод массива с клавиатуры:
// void FillArray(int[] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }


void PrintArray(int[] arr)
{
    int len = arr.Length;
    for (int j = 0; j < len; j++)
    {

        if (j == len - 1)
        {
            Console.Write(arr[j] + "");
        }
        else
        {
            Console.Write(arr[j] + ", ");
        }

    }
}

FillArray(array);

Console.Write("[");
PrintArray(array);
Console.Write("]");