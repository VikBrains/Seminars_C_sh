﻿/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] array = new int [5,5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
         array[i,j] = new Random().Next(0,10);
         Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    double averageResult = 0.0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[j,i];
    }
    averageResult = (double) sum / array.GetLength(1);
    Console.WriteLine($"column average {i} is {averageResult}");
}
