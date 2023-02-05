// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
    System.Console.WriteLine();
}

void ShowElement(double[,] array, int numberOfElement)
{
    int str = array.GetLength(0);
    int col = array.GetLength(1);

    if (numberOfElement > str * col)
    {
        System.Console.WriteLine("Такого числа нет в массиве");
    }
    else
    {
        int counter = 0;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < col; j++)
            {
                counter++;
                if (counter == numberOfElement) Console.WriteLine($"Элемент под номером {numberOfElement} = {array[i, j]}");
            }
        }
    }


}

double[,] array = ToCreateRandomDoubleArray(3, 5, 0, 20);

PrintDoubleArray(array);

ShowElement(array, 15);


