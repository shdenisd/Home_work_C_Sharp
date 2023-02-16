// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



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

void MatrixMultiplication(int[,]array_1, int[,]array_2)
{
    if (array_1.GetLength(1) != array_2.GetLength(0))
    {
        System.Console.WriteLine("Данные матрицы нельзя умножить кол-во столбцов первой не равно кол-ву строк второй");
        return;
    }

    int[,] multiplication = new int[array_1.GetLength(0), array_2.GetLength(1)];
    for (int i = 0; i < multiplication.GetLength(0); i++)
    {
        for (int j = 0; j < multiplication.GetLength(1); j++)
        {
           for (int k = 0; k < array_1.GetLength(1); k++)
           {
                multiplication[i, j] += array_1[i, k] * array_2[k, j];
           }
        }
    }
    System.Console.WriteLine("Умножение матриц: ");
    System.Console.WriteLine();
    PrintDoubleArray(multiplication);
}

Console.Clear();

int[,] array_1 = GetDoubleArray(1, 3, 1, 5);
int[,] array_2 = GetDoubleArray(3, 2, 1, 5);

System.Console.WriteLine("Матрица 1");
System.Console.WriteLine();
PrintDoubleArray(array_1);
System.Console.WriteLine("Матрица 2");
System.Console.WriteLine();
PrintDoubleArray(array_2);

MatrixMultiplication(array_1, array_2);
