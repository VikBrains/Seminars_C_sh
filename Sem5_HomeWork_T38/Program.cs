// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void FillArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];

Console.WriteLine("Array are: ");
FillArray(numbers);
Console.WriteLine(" -- ");

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > max)
    {
        max = numbers[j];
    }
    if (numbers[j] < min)
    {
        min = numbers[j];
    }
}

Console.WriteLine($"Total {numbers.Length} numbers.");
Console.WriteLine($"Max value = {max}, Min value = {min}");
Console.WriteLine($"Difference max - min = {max - min}");
Console.WriteLine(" -- ");
