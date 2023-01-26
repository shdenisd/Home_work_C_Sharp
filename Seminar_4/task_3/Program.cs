// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// на вход принимается срока, состоящая из 8 цифр, разделенные "," и " ". При этом нельзя использовать метод split.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



// Ваирант 1 - можно вводить 8 цифр через "," + любое между другое кол-во любых символов

int[] Create_Array(string numerals)
{
    string work_string = "";
    string work_string_2 = "";
    string integer = "0123456789";
    string[] Array_for_numbers = new string[8];
    int count = 0;
    int[] result = new int [8];
    for (int i = 0; i < numerals.Length; i++)
    {
        work_string += numerals[i];
        if (numerals[i] == ','|| i + 1 == numerals.Length)
        {
            for (int j = 0; j < work_string.Length; j++)
            {

                if(integer.Contains(work_string[j])) work_string_2 += work_string[j];
            }

            Array_for_numbers[count] = work_string_2;
            count++;
            work_string = "";
            work_string_2 = "";
        }

    }
    for (int i = 0; i < Array_for_numbers.Length; i++)
    {
        result[i] = int.Parse(Array_for_numbers[i]);
    }
    return result;
}


// Вариант 2, простой, через ", " последнее число без ",", как по условию.
 

int[] Create_Array_2(string numerals)
{
    int[] result = new int [8];
    string work_string = "";
    int count = 0;
    for (int i = 0; i <= numerals.Length; i++)
    {
        if (i == numerals.Length || numerals[i] == ',')  // Кажется, это самое гениальное что я делал! numeralas[i] в последней итерации цикла выходит за границу массива и я не                                                                                            
        {                                                // мог добавить в массив последнее число, логику было переписывать лень - и я вспомнил, 
            result[count] = int.Parse(work_string);      // что условный опреатор || не обращается к второму операнду, если первый даёт true и достаточно просто поменять было условие местами.
            count++;                                                                                
            work_string = "";
        }
        else if (numerals[i] == ' ') continue;
        else work_string += numerals[i];
        
    }



    return result;
}

System.Console.Write("Введите 8 цифр в одну строку: ");
string number = Console.ReadLine()!;


//int[] array = Create_Array(number);

int[] array_2 = Create_Array_2(number);

//System.Console.WriteLine(String.Join(", ", array));

System.Console.WriteLine(String.Join(", ", array_2));

