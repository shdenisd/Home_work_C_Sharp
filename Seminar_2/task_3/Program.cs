// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, обзначающее день недели - от 1 до 7: ");
int number = 0;

while (true)
{
    number = int.Parse(Console.ReadLine()!);
    if (0 < number && number < 8) break;
    else Console.Write("Перечитайте задание и введите число заново: ");
}
if (number == 6 || number == 7) Console.WriteLine("День является выходным");
else Console.WriteLine("День не является выходным");
