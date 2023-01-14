Console.Write("Дорогой друг, введи, пожалуйста, два числа, а я определю их размерность: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Теперь второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    Console.Write($"Число {numberA} является наибольшим, а число {numberB} является наименьшим");
}
else if (numberA < numberB)
{
    Console.Write($"Число {numberB} является наибольшим, а число {numberA} является наименьшим");
}
else
{
    Console.Write($"Числа равны");
}



