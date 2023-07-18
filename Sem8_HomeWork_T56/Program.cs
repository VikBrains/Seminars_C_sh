/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

Console.Write("\nInput rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns number: ");
int columns = Convert.ToInt32(Console.ReadLine());
const int cellWitgh = 4;

int[,] array = new int[rows,columns];

Console.WriteLine();

createArray(array);
printArray(array);

int minSumLine = 0;
int sumLine = sumString(array, 0);
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    int temp = sumString(array, i);
    if (sumLine > temp)
    {
        sumLine = temp;
        minSumLine = i;
    }
}

int sumString(int[,] array, int i)
{
    int sumString = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumString = sumString + array[i,j];
    }
    return sumString;
}

Console.WriteLine($"\nRow with minimal sum is {minSumLine + 1} ({sumLine})");
Console.WriteLine();

void createArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-5,15);
    }
  }
}

void printArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j] + " ", cellWitgh}");
    }
    Console.WriteLine();
  }
}
