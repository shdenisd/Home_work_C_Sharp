Console.WriteLine("Введите ниже 3 числа подряд, а я узнаю наибольшее:");

int numberA = int.Parse(Console.ReadLine()!);
int numberB = int.Parse(Console.ReadLine()!);
int numberC = int.Parse(Console.ReadLine()!);


if (numberA >= numberB && numberA >= numberC)
{
    Console.WriteLine($"Наибольшим числом является {numberA}");
}
else if (numberB >= numberA && numberB >= numberC)
{
    Console.WriteLine($"Наибольшим числом является {numberB}");
}
else 
{
    Console.WriteLine($"Наибольшим числом является {numberC}");
}
