// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


double[,] ToCreateRandomDoubleArray(int str, int col, int minValue, int maxValue)
{
    double[,] doubleArray = new double[str, col];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            double integerPart = new Random().Next(minValue, maxValue + 1);
            double doublePart = new Random().NextDouble();
            doubleArray[i, j] = integerPart + doublePart;
        }
    }
    return doubleArray;
}

void PrintDoubleArray(double[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write($"{doubleArray[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

double[,] CreateRandomDoubleArray()
{
    System.Console.Write("Введите кол-во строк: ");
    int numberOfStr = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите кол-во колонок: ");
    int numberOfCol = int.Parse(Console.ReadLine()!);

    System.Console.Write("Введите минимальное возможное число для элемента массива: ");
    int minValue = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите максимальное возможное число для элемента массива: ");
    int maxValue = int.Parse(Console.ReadLine()!);

    System.Console.WriteLine();

    return ToCreateRandomDoubleArray(numberOfStr, numberOfCol, minValue, maxValue);
}


PrintDoubleArray(CreateRandomDoubleArray());

