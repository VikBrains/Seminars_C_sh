﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9      m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine();
Console.Write("Input integer m: ");
int m = Math.Abs(int.Parse(Console.ReadLine()));
Console.Write("Input integer n: ");
int n = Math.Abs(int.Parse(Console.ReadLine()));

int result = Ack(m, n);

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else 
    if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else return Ack(m - 1, Ack(m, n - 1));
}

Console.Write($"Akkerman function = {result} ");
Console.WriteLine("\n");