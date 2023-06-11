// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// Пример: a = 5; b = 7 -> max = 7

Console.WriteLine("Input first integer: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Input second integer: ");
int b = int.Parse(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);
