// Напишите программу, которая принимает на вход координаты точки (X и Y)
// причём (X !=0) и (Y !=0) и выдаёт номер четверти плоскости, в которой находится эта точка

// ! организация Метода (даём название и загоняем в фигурные скобки типовое решение типовой задачи)
// int GetAreaNumber(int number_1, int number_2)   
// {
//    if (number_1 < 0 || number_2 < 0)
//        Console.WriteLine("quarter 3");
// }


Console.Write("input coordinate X: ");
int x =  int.Parse(Console.ReadLine());

Console.Write("input coordinate Y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Incorrect data: X & Y != 0");
    Environment.Exit(0);
    // return;
}

if (x > 0 && y > 0)
{
    Console.Write("quarter 1");
}

if (x < 0 && y > 0)
{
    Console.Write("quarter 2");
}
if (x < 0 && y < 0)
{
    Console.Write("quarter 3");
}
if (x > 0 && y < 0)
{
    Console.Write("quarter 4");
}