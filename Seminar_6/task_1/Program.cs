// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 22-3-> 3





// числа можно вводить как угодно, числом явлется слитная последовательность цифр.

int[] String_to_array(string numbers)
{
    numbers = numbers + " ";                                         // присваиваем к строке дополнительный пробел, чтобы последнее введенное пользоваталем число обработалось в любом случае, не важно как оно будет введено с разделителем после или без.
    bool flag = false;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)                         // в данном цикле получаем размер массива который нам понадобится
    {
        if (Char.IsNumber(numbers[i])) flag = true;                  
        else
        {
            if (flag) count++;                                        
            flag = false;
        }
    }

    string work_string = string.Empty;
    int[] array_of_numbers = new int[count];
    count = 0;
    for (int i = 0; i < numbers.Length; i++)                        // в данном цикле создаем из введенных цифр массив
    {
        if (Char.IsNumber(numbers[i]) || (numbers[i] == '-')) work_string += numbers[i];     // крашится если ввести например так  85-87, чё нить потом придумюа 
        else
        {       
            if (work_string != string.Empty)
            {
                array_of_numbers[count] = int.Parse(work_string);
                count++;
                work_string = string.Empty;
            }
        }
    }

    return array_of_numbers;
}


int count_el_greater_zero(int[] array)
{
    int counter = 0;
    foreach (int el in array)
    {
        if (el > 0) counter++;
    }
    return counter;
}





System.Console.Write("Введите числа через любой разделитель: ");
string user_string = Console.ReadLine();

int[] array_from_user_string = String_to_array(user_string);
int gretater_than_zero = count_el_greater_zero(array_from_user_string);


System.Console.Write("Вы ввели слeдующие числа: ");
System.Console.WriteLine(String.Join("  ", array_from_user_string));
System.Console.WriteLine($"Из них {gretater_than_zero} больше 0");






