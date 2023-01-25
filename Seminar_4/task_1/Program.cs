// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Exponentiate(int number, int power)
{
    int result = number;
    for (int i = 1; i < power; i++)
    {
        result *= number;
    }
    return result;
}

System.Console.WriteLine("Введите 2 числа, сначала которое возводим в степень, потом саму степень в которую возводим: ");
int number_to_pow = int.Parse(Console.ReadLine()!);
int number_pow = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"Число {number_to_pow} в степень {number_pow} = {Exponentiate(number_to_pow, number_pow)}");


