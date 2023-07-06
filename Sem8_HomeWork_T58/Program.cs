/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

int[,] arrayA = new int [5,4];

for (int i = 0; i < arrayA.GetLength(0); i++)
{
    for (int j = 0; j < arrayA.GetLength(1); j++)
    {
         arrayA[i,j] = new Random().Next(1,10);
         Console.Write(arrayA[i,j] + " ");
    }
    Console.WriteLine();
}

int[,] arrayB = new int [5,4];

for (int i = 0; i < arrayB.GetLength(0); i++)
{
    for (int j = 0; j < arrayB.GetLength(1); j++)
    {
         arrayB[i,j] = new Random().Next(1,10);
         Console.Write(arrayB[i,j] + " ");
    }
    Console.WriteLine();
}