// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



System.Console.Write("Введите первую точку первовой прямой: ");
double b1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите вторую точку первовой прямой: ");
double k1 = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите первую точку второй прямой: ");
double b2 = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите вторую точку второй прямой: ");
double k2 = int.Parse(Console.ReadLine()!);

double X = (b2 - b1) / (k1 - k2);

double Y = k1 * X + b1;


System.Console.WriteLine($"({X}; {Y})");
