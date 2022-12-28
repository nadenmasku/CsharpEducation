// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int SumOfDigits(int num)
{
    while (num > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }


    return sum;
}

sum = SumOfDigits(number);

Console.WriteLine(sum);