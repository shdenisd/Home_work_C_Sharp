// Напишите функцию, которая
// принимает одно число - высоту елочки и рисует ее в
// консоли звездочками.
// 3 ->  
//  * 
// ***
//*****
// 5 ->  
//     *
//    ***
//   *****
//  *******
// *********
//  
//  *
// ***

void print_fir (int number)
{
    for (int i = 1; i <= number; i++)
    {   
        for (int j = 0; j < number + i; j++)
        {
            if (j > number - i) System.Console.Write("*");
            else System.Console.Write(" ");
        }
        System.Console.WriteLine(" ");
    }
}

System.Console.WriteLine("Введите высоту ёлочки");

int number = int.Parse(Console.ReadLine()!);

print_fir(number);