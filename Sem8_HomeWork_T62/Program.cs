﻿/* Задача 62: Заполните спирально массив 4 на 4.
1  2  3  4
12 13 14 5
11 16 15 6
10  9  8 7 */


int n = 4;
const int cellWitgh = 4;
int[,] array = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;





printArray(array);

void printArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
    Console.WriteLine();
    }
}