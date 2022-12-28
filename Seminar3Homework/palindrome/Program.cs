int Revers(int num)
{
    int result = 0;
    while(num!=0)
    {
        result = result * 10;
        result += num % 10;
        num /= 10;
    }
    return result;
}

int number = Convert.ToInt32(Console.ReadLine());
int reversNum = Revers(number);

if (reversNum==number) Console.WriteLine("Palindrome");
else Console.WriteLine("Not a palindrome");
//Console.WriteLine(Revers(number));
