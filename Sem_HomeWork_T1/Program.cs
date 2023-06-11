// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// Пример: a = 5; b = 7 -> max = 7

Console.WriteLine("Input first integer: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Input second integer: ");
int b = int.Parse(Console.ReadLine());

int max = a;
int min = b;

if (a > max) max = a; min = b;

if (b > max) max = b; min = a;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
