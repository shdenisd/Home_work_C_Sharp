// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



 void FillSpiralArray(int[,] array)
{
    int n = array.GetLength(0);
    int num = 1;
    int row = 0;
    int col = 0;

    while (num <= n * n)
    {
        // заполнение верхней строки
        for (int i = col; i < n - col; i++)
        {
            array[row, i] = num;
            num++;
        }

        // заполнение правого столбца
        for (int i = row + 1; i < n - row; i++)
        {
            array[i, n - col - 1] = num;
            num++;
        }

        // заполнение нижней строки
        for (int i = n - col - 2; i >= col; i--)
        {
            array[n - row - 1, i] = num;
            num++;
        }

        // заполнение левого столбца
        for (int i = n - row - 2; i > row; i--)
        {
            array[i, col] = num;
            num++;
        }

        // переход к следующему кругу спирали
        row++;
        col++;
    }
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


int[,] array = new int[4,4];
FillSpiralArray(array);
PrintDoubleArray(array);