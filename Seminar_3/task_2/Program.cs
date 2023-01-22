// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

System.Console.WriteLine("Введите точку 1");
System.Console.Write("X :");
int x1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Y :");
int y1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Z :");
int z1 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите точку 2");
System.Console.Write("X :");
int x2 = int.Parse(Console.ReadLine()!);
System.Console.Write("Y :");
int y2 = int.Parse(Console.ReadLine()!);
System.Console.Write("Z :");
int z2 = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

System.Console.WriteLine($"Расстояние между точками равно {distance:F2}");

