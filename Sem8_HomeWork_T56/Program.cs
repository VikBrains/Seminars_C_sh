/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

int[,] array = new int [5,6];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
         array[i,j] = new Random().Next(1,10);
         Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
