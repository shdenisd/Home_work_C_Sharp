// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();

System.Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine()!);

System.Console.Write($"Кубы чисел от 1 до {number}:  ");

int counter = 1;
while (counter <= number)
{
    System.Console.Write(Math.Pow(counter, 3));
    if (counter != number) System.Console.Write(", ");
    counter++; 
}
