/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 17 -> такого числа в массиве нет */

System.Console.Write("Input num rows: ");
int n = int.Parse(Console.ReadLine());
System.Console.Write("Input num column: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Input row Index: ");
int row_search = Convert.ToInt32(Console.ReadLine()) - 1;
System.Console.Write("Input column Index: ");
int column_search = Convert.ToInt32(Console.ReadLine()) - 1;

Random random = new Random();
int[,] array = new int[n, m];
Console.WriteLine("array for searching: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}


if (row_search < 0 | row_search > array.GetLength(0) - 1 | column_search < 0 | column_search > array.GetLength(1) - 1)
{
    Console.WriteLine("item are absent  ");
}
else
{
    Console.WriteLine("Item value is {0}", array[row_search, column_search]);
}
Console.WriteLine();