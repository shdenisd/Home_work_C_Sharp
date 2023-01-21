// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет 
// 12821 -> да
// 23432 -> да


// Пользуемся только математикой

Console.Clear();

System.Console.Write("Введите любое пятизначное число: ");
int number = 0;

while (true)
{
    number = int.Parse(Console.ReadLine()!);
    if (number / 10000 == 0 || number / 10000 > 9) System.Console.Write("Введите пятизначное число! ");
    else break;
}

int polindrom = 0;
int do_number = number; // чтобы не затирать изначальное число


// вариант № 1

while (do_number != 0)
{
    polindrom = polindrom * 10 + do_number % 10; // Узнал что *= тут поставить не получиться, сначала будет вычесляться (10 + number % 10) и потом умножаться на переменную
    do_number /= 10;
}


// вариант № 2

int tens_thousands = number / 10000;
int thousands = number / 1000 % 10;
int tens = number / 10 % 10;
int units = number % 10;


if (tens_thousands == units && thousands == tens && polindrom == number) System.Console.WriteLine("Да");


