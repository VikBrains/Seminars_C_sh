/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Input integer M: ");
int numStart = int.Parse(Console.ReadLine());
Console.Write("Input integer N: ");
int numEnd = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = numStart; i <= numEnd; i++) sum = sum + i;
Console.Write(sum);