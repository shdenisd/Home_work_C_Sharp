Console.Write("Введите натуральное число, программа покажет все чётные числа от 1 до вашего числа: ");
int UserNumber = int.Parse(Console.ReadLine()!);

if (UserNumber < 2)
{
    Console.WriteLine("Таких чисел нет :(");
}

int counter = 2;
while (counter <= UserNumber)
{
    if (counter % 2 == 0)
    {
        Console.Write($"{counter} ");
    }
    counter++;
}

