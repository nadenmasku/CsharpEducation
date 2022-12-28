int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int SumNum(int M, int N)
{
    int sum = 0;
    if (M == N)
    {
        return N;
    }
    else
    {
        sum = M + SumNum(M + 1, N);
    }
    return sum;
}

Console.WriteLine(SumNum(M, N));