// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] FindMinIndexOrIndexisInArray(int[] array)
{
    int minValue = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
            minIndex = i;
        } 
    }

    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(minValue == array[i]) counter++;
    }
    int[] minIndexOrIndexis = new int[counter];

    counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(minValue == array[i])
        {
            minIndexOrIndexis[counter] = i;
            counter++;
        }
    }
    return minIndexOrIndexis;

}

void FindRowWithMinSumOfElement(int[,] array)
{
    int[] sumOfRow = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumOfRow[i] = sum;
        sum = 0;
    }

    System.Console.WriteLine("Cуммы строк:");
    System.Console.WriteLine(String.Join(" ", sumOfRow));

    int[] minIndexOrIndexis = FindMinIndexOrIndexisInArray(sumOfRow);

    System.Console.Write("Строка (строки) с минимальным значением: ");
    for (int i = 0; i < minIndexOrIndexis.Length; i++)
    {
        System.Console.Write($"{minIndexOrIndexis[i] + 1} ");
    }

}

int[,] array = GetDoubleArray(10, 4, 0, 5);

PrintDoubleArray(array);

FindRowWithMinSumOfElement(array);





