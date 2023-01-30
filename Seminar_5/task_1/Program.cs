// **Задача 34**: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] get_random_array(int size, int minValue, int maxValue)
{
    int[] random_array = new int[size];
    for (int i = 0; i < size; i++)
    {
        random_array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return random_array;
}


void count_even_numbers(int[] array)
{
    int counter = 0;
    foreach(int el in array)
    {
        if(el % 2 == 0) counter++;
    }
    System.Console.WriteLine($"Колличество чётных, трёхзнычных элементов в массиве = {counter}");
}



int[] array = get_random_array(5, 100, 999);
System.Console.WriteLine(string.Join(" ", array));

count_even_numbers(array);