Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N<0) Console.WriteLine("Error");

for (int i = 1; i <= N;i++)
{
    Console.WriteLine($"{i} в степени 3 = {i*i*i}");
}