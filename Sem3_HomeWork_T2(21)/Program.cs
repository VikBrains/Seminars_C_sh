// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// это 2D:
Console.Write("Input coordinates x1: ");
int ax = int.Parse(Console.ReadLine());

Console.Write("Input coordinates y1: ");
int ay = int.Parse(Console.ReadLine());

Console.Write("Input coordinates z1: ");
int az = int.Parse(Console.ReadLine());

Console.Write("Input coordinates x2: ");
int bx = int.Parse(Console.ReadLine());

Console.Write("Input coordinates y2: ");
int by = int.Parse(Console.ReadLine());

Console.Write("Input coordinates z2: ");
int bz = int.Parse(Console.ReadLine());

// double result = Math.Round(Math.Cbrt(Math.Pow((bx-ax),2) + Math.Pow((by-ay),2) + Math.Pow((bz-az),2)),3);
Console.WriteLine($"Distanse beetwin points is: {Math.Cbrt(Math.Pow((bx-ax),2) + Math.Pow((by-ay),2) + Math.Pow((bz-az),2))}");
