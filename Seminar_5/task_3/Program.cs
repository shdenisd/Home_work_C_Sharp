// **Задача 38:** Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.23 7.1 22.4 2.1 78.54] -> 76.53


double[] get_random_double_array(int size, int minValue, int maxValue)
{
    double[] random_array = new double[size];
    double integer_part = 0;
    double double_part = 0;
    for (int i = 0; i < size; i++)
    {
        integer_part = new Random().Next(minValue, maxValue);
        double_part = new Random().NextDouble();
        random_array[i] = integer_part + double_part;
    }
    return random_array;
}


void find_max_min_diff(double[] array)
{
    double min_value = array[0];
    double max_value = array[0];
    foreach (var el in array)
    {
        min_value = el < min_value ? el : min_value;
        max_value = el > max_value ? el : max_value;
    }
    System.Console.WriteLine($"Разница между наимбольшим и наименьшим эелементами массива = {max_value - min_value}");
}


double[] array = get_random_double_array(3, 0, 100);
System.Console.WriteLine(string.Join(" ", array));

find_max_min_diff(array);


