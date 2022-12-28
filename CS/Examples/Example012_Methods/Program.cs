void Method1()
{
    Console.WriteLine("author");
}

Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "Text", count: 4);

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();

Console.WriteLine(year);

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "afdasdz");
Console.WriteLine(res);