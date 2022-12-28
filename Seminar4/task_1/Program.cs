int N = Convert.ToInt32(Console.ReadLine());
int result = 0;

int GetSumNum(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}

result = GetSumNum(N);
Console.WriteLine(result);


