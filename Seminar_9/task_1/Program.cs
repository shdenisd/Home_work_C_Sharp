// задать число N, вывести все числа от N до 1 рекурсивно.


string FromNToOne(int n)
{
    if (n == 1) return n.ToString();
    else
    {
        return n.ToString() + " " + FromNToOne(n - 1);
    }
}


void main()
{   
    System.Console.Write("Введите число!: ");
    int n = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine(FromNToOne(n));
}

main();