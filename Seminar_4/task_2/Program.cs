// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void sum_of_numeral(int number)
{   
    int result = 0;
    int initial_number = number;    // тут хотел найти метод, который будет значение аргуметна переданного функции возвращать в первоначальный вид в момент передачи функции
    while (number > 0)              // и прописать после цикла, но нашёл, потому костыль. Есть ли такой метод, чтобы после цикла While получить снова исходное значение number?
    {
        result += number % 10;
        number /= 10; 
    }
    System.Console.WriteLine($"Сумма цифр числа {initial_number} = {result}");
}

System.Console.Write("Введите число, а я посчтаю сумму его цифр: ");
int number = int.Parse(Console.ReadLine()!);
sum_of_numeral(number);
