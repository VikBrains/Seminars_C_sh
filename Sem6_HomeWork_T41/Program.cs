// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2  ///  -1, -7, 567, 89, 223-> 3

Console.Write("Input number with comma: ");
int[] numbers = GetArrayFromString(Console.ReadLine());

int[] GetArrayFromString(string stringArray)
{
    string[] numbers = stringArray.Split(",", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}

int sumPositive = 0;
Console.Write("[ ");
for (int i = 0; i < numbers.Length; i++)
{
    //Console.Write(numbers[i] + " ");
    if (numbers[i] > 0)
    {
        sumPositive++;
    }
}
Console.WriteLine("] ");
Console.WriteLine($"Quantity of positive is {sumPositive}");
Console.WriteLine();

