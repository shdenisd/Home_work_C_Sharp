// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] Get3DArray(int arrLength, int arrWidth, int arrHeight, int minValue, int maxValue)
{
    int[] trueRandomArray = TrueRandomArray(arrLength * arrWidth * arrHeight, minValue, maxValue);
    int[,,] array3D = new int[arrLength, arrWidth, arrHeight];
    int counter = 0;
    for (int i = 0; i < arrLength; i++)
    {
        for (int j = 0; j < arrWidth; j++)
        {
            for (int k = 0; k < arrHeight; k++)
            {
                array3D[i, j, k] = trueRandomArray[counter];
                counter++;
            }
        }
    }
    return array3D;
}

int[] TrueRandomArray(int size, int minValue, int maxValue)
{
    int[] trueRandomArray = new int[size];
    trueRandomArray[0] = new Random().Next(minValue, maxValue + 1);
    for (int i = 1; i < trueRandomArray.Length; i++)
    {
        trueRandomArray[i] = new Random().Next(minValue, maxValue + 1);
        while (true)
        {
            int flag = 0;
            for (int j = 0; j < i; j++)
            {
                if (trueRandomArray[j] == trueRandomArray[i])
                {
                    trueRandomArray[i] = new Random().Next(minValue, maxValue + 1);
                    flag = 1;
                }

            }

            if (flag == 0) break;
        }
    }
    return trueRandomArray;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.WriteLine($" {i} {j} {k} || {array[i, j, k]}");
            }
        }
    }
}




int[,,] array = Get3DArray(2, 2, 2, 10, 17);


Print3DArray(array);
