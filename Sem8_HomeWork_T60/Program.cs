/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

Console.Write("\Input array size X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("\Input array size X: ");
int yx = Convert.ToInt32(Console.ReadLine());
Console.Write("\Input array size X: ");
int z = Convert.ToInt32(Console.ReadLine());
const int cellWitgh = 4;


int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
printArray(array3D);

void CreateArray(int[,,] array3D)
{
    
}

void printArray (int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write( $"Z({k})={array3D[i,j,k]}; ");
            }
        }
        Console.WriteLine();
    }
}