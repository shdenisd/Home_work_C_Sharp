Console.Write("Привет! Введи число, а я скажу чётное ли оно: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine("Твоё число чётное!");
}
else
{
    Console.WriteLine("Твоё число нечётно!");
}

Console.WriteLine("Test");