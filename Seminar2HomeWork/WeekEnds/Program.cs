int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Ура! Выходной!");
}
else if (day > 7)
{
    Console.WriteLine("В неделе 7 дней!!!");
}
else
{
    Console.WriteLine("Будни :(");
}