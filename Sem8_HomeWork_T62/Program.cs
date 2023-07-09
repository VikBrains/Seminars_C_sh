/* Задача 62: Заполните спирально массив 4 на 4.
1  2  3  4
12 13 14 5
11 16 15 6
10  9  8 7 */


Console.Write("\nInput rows number: ");
int spiral = Convert.ToInt32(Console.ReadLine());
const int cellWitgh = 2;


int[,] array = new int[spiral, spiral];

int i = 0;
int j = 0;
int tmp = 1;

while (tmp <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = tmp;
    tmp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    {
        j++;
    }
    else if (i < j && i + j >= array.GetLength(0) - 1)
    {
        i++;
    }
    else if (i >= j && i + j > array.GetLength(1) - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
}

printArray(array);
Console.WriteLine("==");

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