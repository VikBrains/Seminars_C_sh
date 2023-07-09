/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

Console.Write("\nInput matrix 1 rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of matrix_1 columns and matrix_2 rows: ");
int rowsColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input matrix_2 columns number: ");
int columns = Convert.ToInt32(Console.ReadLine());
const int cellWitgh = 3;

int[,] arrayA = new int [rows,rowsColumns];
createArray(arrayA);
printArray(arrayA);
Console.WriteLine("= =");

int[,] arrayB = new int [rowsColumns,columns];
createArray(arrayB);
printArray(arrayB);
Console.WriteLine("= =");

int[,] resultMatrix = new int[rows,columns];
MultiplyMatrix(arrayA, arrayB, resultMatrix);
Console.WriteLine($"\Multiply result for both matrix: ");
printArray(resultMatrix);
Console.WriteLine("= =");

void MultiplyMatrix(int[,] arrayA, int[,] arrayB, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < arrayA.GetLength(1); k++)
      {
        sum = sum + arrayA[i,k] * arrayB[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void createArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
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