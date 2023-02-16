// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SumFromMToN(int M, int N)
{
    if (M == N) return N;
    else
    {
        return M + SumFromMToN(M + 1, N);
    }  

}


void main()
{
    int number = SumFromMToN(1, 15);
    System.Console.WriteLine(number);
}

main();