Console.Clear();
int numberWrite = Convert.ToInt32(Console.ReadLine());
int number = numberWrite;
int numLength = 0;
int thirdNum = 0;
int num = number;



while (number > 0)
{
    number = number / 10;
    numLength++;
}

for (int i = 0; i < numLength; i++)
{
    if (i == (numLength-3))
    {
        thirdNum = num % 10;
    }
    num = num / 10;
}


if (numLength <= 2)
{
    Console.WriteLine("Error");
}
else
{
    Console.WriteLine("Third number is = " + thirdNum);
}