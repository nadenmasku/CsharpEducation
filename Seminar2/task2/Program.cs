int num = new Random().Next(100, 999);
Console.WriteLine(num);

int a2 = num / 10;
int a1 = a2 / 10;
int a3 = num % 10;
//int result = a3 + a;
Console.WriteLine("a1= " + a1);
Console.WriteLine("a2= " + a2);
Console.WriteLine("a3= " + a3);

int result = (a1 * 10) + a3;
Console.WriteLine(result);