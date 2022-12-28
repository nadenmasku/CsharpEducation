int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int AccermanFunc(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    if (M > 0 && N == 0)
    {
        return AccermanFunc(M - 1, 1);
    }
    if (M > 0 && N > 0)
    {
        return AccermanFunc(M - 1, AccermanFunc(M, N - 1));
    }
    else
    {
        return N + 1;
    }
    
}

Console.WriteLine(AccermanFunc(M, N));