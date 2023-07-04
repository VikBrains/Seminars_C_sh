// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.  
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input array size:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

Console.WriteLine("Our array: ");
FillArray(array);
Console.WriteLine(" -- ");

int count = 0;

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) 
    count++;
}
Console.WriteLine($"Total {array.Length} digits, {count} of even");
Console.WriteLine(" -- ");
