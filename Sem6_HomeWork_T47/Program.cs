// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

System.Console.WriteLine();
System.Console.Write("Input rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input columns number: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = InitMatrix(rows,columns);

System.Console.WriteLine();
Print(matrix);
System.Console.WriteLine();

double[,] InitMatrix(int rows, int columns)
{
    double[,] tmp = new double[rows,columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            tmp[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return tmp;
}


void Print(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j] }  ");
        }
        System.Console.WriteLine();
    }
}