/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


Console.Write("Input integer: ");
int numM = int.Parse(Console.ReadLine());

int numN = 1;
string PrintNumbers(int start, int end)
{
    if (start == 1) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}
Console.WriteLine(PrintNumbers(numM, numN));