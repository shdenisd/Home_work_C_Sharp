
// **Задача 36:** Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] get_random_array(int size, int minValue, int maxValue)
{
    int[] random_array = new int[size];
    for (int i = 0; i < size; i++)
    {
        random_array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return random_array;
}



void sum_of_uneven_numbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    System.Console.WriteLine($"Сумма всех элементов массива, находящихся на нечётных позициях  = {sum}");
}


int[] array = get_random_array(6, 0, 10);
System.Console.WriteLine(string.Join(" ", array));

sum_of_uneven_numbers(array);