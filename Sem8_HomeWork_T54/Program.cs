/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

Console.Write("\nInput rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns number: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows,columns];
Console.WriteLine();

Console.WriteLine($"Random array: ");
createArray(array);
printArray(array);
Console.WriteLine();

Console.WriteLine($"Sorted array: ");
sortedArray(array);
printArray(array);
Console.WriteLine();

void sortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            /* if (array[i, j] < array[i, j + 1])
            {
                int temp = array[i, j + 1];
                array[i, j + 1] = array[i, j];
                array[i, j] = temp;*/

            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void createArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(10,100);
    }
  }
}

void printArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
