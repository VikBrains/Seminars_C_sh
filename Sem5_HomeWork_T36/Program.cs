// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//  [3, 7, 23, 12] -> 19    [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,20);
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

Console.WriteLine(" -- ");
Console.Write("Sum of odd in Array  ");

FillArray(array);

int sum = 0;

for (int j = 1; j < array.Length; j+=2)
{
    sum = sum + array[j];
}

Console.WriteLine($" > {sum} ");
Console.WriteLine(" -- ");
