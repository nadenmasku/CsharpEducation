int N = Convert.ToInt32(Console.ReadLine());

void ShowNum(int N)
{
    if (N==1)
    {
        Console.WriteLine(N);
    }
    else
    {
        Console.Write(N+",");
        ShowNum(N - 1);
    }
    
}

ShowNum(N);