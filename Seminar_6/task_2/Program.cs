// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] user_points()
{
    int[] points_array = new int[4]; 

    System.Console.Write("Введите первую точку первовой прямой: ");
    points_array[0] = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите вторую точку первовой прямой: ");
    points_array[1] = int.Parse(Console.ReadLine()!);

    System.Console.Write("Введите первую точку второй прямой: ");
    points_array[2] = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите вторую точку второй прямой: ");
    points_array[3] = int.Parse(Console.ReadLine()!);

    
    return points_array;
}

void intersection_points(int[] points_array)
{
    double b1 = points_array[0];
    double k1 = points_array[1];
    double b2 = points_array[2];
    double k2 = points_array[3];
    
    double X = (b2 - b1) / (k1 - k2);
    double Y = k1 * X + b1;
    System.Console.WriteLine($"({X}; {Y})");
}


int[] points_array = user_points();
intersection_points(points_array);

