// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetDoubleArray(int str, int col, int minValue, int maxValue)
{
    int[,] doubleArray =  new int[str,col]; 
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            doubleArray[i, j] = new Random().Next(minValue, maxValue + 1); 
        }
    }
    return doubleArray;
}   

void PrintDoubleArray(int[,] doubleArray)
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


void AverageInDoubleArray(int[,] array)
{
    double sum = 0;
    double[] allAverage = new double[array.GetLength(1)];
    int counter = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {  
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i]; 
            counter = j + 1;
        }
        allAverage[i] = sum / counter;
        sum = 0;
    }
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    System.Console.WriteLine(String.Join("; ", allAverage));
}

int[,] array = GetDoubleArray(3, 4, 0, 20);
PrintDoubleArray(array);

AverageInDoubleArray(array);
