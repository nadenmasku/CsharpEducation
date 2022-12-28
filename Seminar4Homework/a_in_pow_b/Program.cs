// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int Pow(int a, int b)
{
    int result = a;

    for (int i = 1; i < b; i++)
    {

        result *= a;
    }
        return result;
}

int answer = Pow(a, b);
Console.WriteLine(answer);