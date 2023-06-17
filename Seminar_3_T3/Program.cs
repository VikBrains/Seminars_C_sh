// Задача 21. Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// 2D координаты

Console.Write("Input coordinates x1: ");
int ax = int.Parse(Console.ReadLine());

Console.Write("Input coordinates y1: ");
int ay = int.Parse(Console.ReadLine());

Console.Write("Input coordinates x2: ");
int bx = int.Parse(Console.ReadLine());

Console.Write("Input coordinates y2: ");
int by = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((bx-ax),2) + Math.Pow((by-ay),2));
Console.WriteLine($"Distanse beetwin points is: {result}");