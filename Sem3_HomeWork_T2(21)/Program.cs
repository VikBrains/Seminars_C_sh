// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

double GetDistance3D(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Round(Math.Cbrt(Math.Pow((bx-ax),2) + Math.Pow((by-ay),2) + Math.Pow((bz-az),2)),3);
    return result;
}

Console.Write("Input coordinate x1: ");
int ax = int.Parse(Console.ReadLine());

Console.Write("Input coordinate y1: ");
int ay = int.Parse(Console.ReadLine());

Console.Write("Input coordinate z1: ");
int az = int.Parse(Console.ReadLine());

Console.Write("Input coordinate x2: ");
int bx = int.Parse(Console.ReadLine());

Console.Write("Input coordinate y2: ");
int by = int.Parse(Console.ReadLine());

Console.Write("Input coordinate z2: ");
int bz = int.Parse(Console.ReadLine());

Console.WriteLine(GetDistance3D(ax, ay, az, bx, by, bz));

// без Метода:
Console.WriteLine($"Distanse beetwin points is: {Math.Cbrt(Math.Pow((bx-ax),2) + Math.Pow((by-ay),2) + Math.Pow((bz-az),2))}"); 

