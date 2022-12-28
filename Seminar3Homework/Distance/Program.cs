Console.WriteLine("Distance between 2 dots in 3d");
Console.WriteLine("Введите координаты точки A");
Console.Write("x= ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("y= ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("z= ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("x= ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("y= ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("z= ");
int bz = Convert.ToInt32(Console.ReadLine());


double res = Math.Round(Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az)),2);

Console.WriteLine($"Result = {res}");